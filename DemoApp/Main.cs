using System;
using System.Linq;
using System.Windows.Forms;
using Logic;
using Model;
using System.Drawing;
using System.Collections.Generic;
using DemoApp.Common;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DemoApp
{
    public partial class Main : Form
    {
        private readonly TicketsService ticketService;
        private readonly EmployeeService employeeService;
        private readonly TicketEscalationService ticketEscalationService;
        private readonly IncidentService incidentService = new IncidentService();
        private readonly TicketTransferService ticketTransferService;
        private LoginService loginService;
        private readonly ArchivedTicketService archivedTicketService = new ArchivedTicketService();
        private readonly IncidentFilteringService incidentFilterService = new IncidentFilteringService();

        // Tickets
        private List<Ticket> allTickets;

        // Incidents
        private List<Incident> incidentList;
        private List<Incident> filteredIncidents;

        /// <summary> Currently logged-in employee.</summary>
        private readonly Employee employee;

        //Generated password
        private HashedPasswordWithSalt password;

        // Styling variables
        readonly Color themeGreen = ColorTranslator.FromHtml("#3E8061");
        readonly Color lightGreen = ColorTranslator.FromHtml("#479B74");
        readonly Color buttonHighLight = ColorTranslator.FromHtml("#FFF6DE");
        readonly Color buttonLightHightLight = ColorTranslator.FromHtml("#59C190");

        // Ticket that currently is shown in details.
        private Ticket detailedTicket;

        // Stores where was the splitter set before resizing started.
        private double splitPercentage;

        // For capturing maximizing and restoring window.
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_RESTORE = 0xF120;

        // Dictionary of all possible days for the deadline.
        private readonly Dictionary<string, int> deadlineDays = new Dictionary<string, int>()
        {
            { "7 days", 7 },
            { "14 days", 14 },
            { "28 days" , 28 },
            { "6 months", 180 }
        };

        private TicketLoadStatus currentTicketLoadStatus;
        private enum TicketLoadStatus
        {
            None = 0, All = 1, Open = 2, PastDeadline = 3, Unresolved = 4, Resolved = 5, Closed = 6
        }

        //public Main(Employee employee)
        public Main(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            lbl_Username.Text = employee.FirstName + " " + employee.LastName;
            lbl_Role.Text = employee.Type.ToString().Prettify();

            ticketService = new TicketsService();
            employeeService = new EmployeeService();
            ticketEscalationService = new TicketEscalationService();

            DisplayDashboardForEmployee(employee);

            // Set tab control panel tabs to invisible
            tabControl.ItemSize = new Size(0, 1);

            // Invert standard image icon
            btn_Dashboard.Image = btn_Dashboard.Image.InvertImage();

            InitAddTicketComboBoxes();
            InitTicketDetailsView();

            // A small workaround for splitter in Table Management to be correctly positioned.
            if (this.employee.Type == EmployeeType.Regular)
            {
                splitContainer1.Panel2MinSize = 0;
                splitContainer1.SplitterDistance = splitContainer1.Width;
            }
            else
            {
                int buttons = flowPnl_TicketManagement_SearchButtons.Controls.Count;
                splitContainer1.SplitterDistance = btn_Display_Tickets_All.Width * buttons + 50;
                splitContainer1.Panel1MinSize = splitContainer1.SplitterDistance;
            }
        }

        /// <summary>
        /// Loads combo boxes data of Add Ticket page.
        /// </summary>
        private void InitAddTicketComboBoxes()
        {
            cmbIncidentTypeCT.DataSource = Enum.GetValues(typeof(IncidentTypes));

            foreach (TicketPriority priority in Enum.GetValues(typeof(TicketPriority)))
            {
                cmbPriorityCT.Items.Add(priority);
            }

            foreach (KeyValuePair<string, int> kvp in deadlineDays)
            {
                cmbDeadlineCT.Items.Add(kvp.Key);
            }
        }

        public void InItAddTicketByRegularEmployeeComboBoxes()
        {
            cmbIncidentType.DataSource = Enum.GetValues(typeof(IncidentTypes));

        }

        private void InitTicketDetailsView()
        {
            cmbDetailsIncidentType.DataSource = Enum.GetValues(typeof(IncidentTypes));

            cmbDetailsPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            cmbDetailsPriority.FormattingEnabled = true;
            cmbDetailsPriority.Format += (object s, ListControlConvertEventArgs e) => e.Value = e.Value.ToString().Prettify();

            foreach (TicketStatus status in Enum.GetValues(typeof(TicketStatus)))
            {
                if (status == TicketStatus.PastDeadline) continue;
                cmbDetailsStatus.Items.Add(status);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Just a small performance optimization...
            if (this.employee.Type == EmployeeType.Regular)
            {
                return;
            }
            LoadDashboardData();
        }

        /// <summary>
        /// Loads the dashboard data into the circle progression bars.
        /// </summary>
        private void LoadDashboardData()
        {
            // Sums of each ticket type 
            int ticketSum = -1, openTickets = -1, pastDeadlineTickets = -1, unresolvedTickets = -1, resolvedTickets = -1;

            try
            {
                // Get amount of total, open, past deadline, unresolved and resolved tickets
                ticketSum = ticketService.GetTotalTicketCount();
                openTickets = ticketService.GetTicketCountByType(TicketStatus.Open);
                pastDeadlineTickets = ticketService.GetTicketCountByType(TicketStatus.PastDeadline);
                unresolvedTickets = ticketService.GetTicketCountByType(TicketStatus.Unresolved);
                resolvedTickets = ticketService.GetTicketCountByType(TicketStatus.Resolved);
            }
            catch (Exception ex)
            {
                // Display error
                MessageBox.Show($"{ex}: error message");
            }
            finally
            {
                // Fill circle progression bars values
                circleBar_Open.ValueMax = ticketSum;
                circleBar_Open.ValueSize = openTickets;

                circleBar_PastDeadline.ValueMax = ticketSum;
                circleBar_PastDeadline.ValueSize = pastDeadlineTickets;

                circleBar_Unresolved.ValueMax = ticketSum;
                circleBar_Unresolved.ValueSize = unresolvedTickets;

                circleBar_Resolved.ValueMax = ticketSum;
                circleBar_Resolved.ValueSize = resolvedTickets;
            }
        }

        // Navigation buttons
        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 0)
            {
                tabControl.SelectedIndex = 0;

                // Load dashboard data
                LoadDashboardData();
            }
        }

        private void Btn_TicketManagement_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 1)
            {
                tabControl.SelectedIndex = 1;

                // Load all tickets
                LoadTickets(TicketLoadStatus.All);
                CleanTicketDetails();
                //Fill assigned employee combobox
                LoadAssignedEmployees();
                lblValidationForArchiving.Hide();
            }
        }

        private void CleanTicketDetails()
        {
            // First clean selection of ticket.
            listView_TicketManagement.SelectedIndices.Clear();

            // Load employees to the employees list (as it might've been changed)
            cmbDetailsReporter.DataSource = employeeService.GetEmployees();

            // Then clean fields.
            txtDetailsSubject.Text = "";
            txtDetailsDescription.Text = "";
            cmbDetailsIncidentType.SelectedIndex = -1;
            cmbDetailsPriority.SelectedIndex = -1;
            cmbDetailsReporter.SelectedIndex = -1;
            cmbDetailsStatus.SelectedIndex = -1;

            // And disable input boxes (as we can't use them just yet).
            txtDetailsSubject.Enabled = false;
            txtDetailsDescription.Enabled = false;
            cmbDetailsIncidentType.Enabled = false;
            cmbDetailsPriority.Enabled = false;
            cmbDetailsReporter.Enabled = false;
            cmbDetailsStatus.Enabled = false;

            btnDetailsDelete.Enabled = false;
            btnDetailsUpdate.Enabled = false;
            btnDetailsClose.Enabled = false;
            btnDetailsEscalate.Enabled = false;

            lblDetailsWarning.Text = "";
            btnDetailsUpdate.Text = "Update";
        }



        public void hideControlsForViewingTickets()
        {
            btn_Display_Tickets_All.Hide();
            btn_Display_Tickets_Open.Hide();
            btn_Display_Tickets_PastDeadline.Hide();
            btn_Display_Tickets_Resolved.Hide();
            btn_Display_Tickets_Unresolved.Hide();
            flowPnl_TicketManagement_SearchButtons.Hide();
        }


        private void DisplayDashboardForEmployee(Employee employee)
        {
            if (employee.Type == EmployeeType.Regular)
            {
                splitContainer1.Panel2.Hide();
                hideControlsForViewingTickets();
                btn_Dashboard.Hide();
                btn_TicketManagement.Text = "My requests";
                btn_CreateTicket.Text = "Report incident";
                lbl_HeaderTicketManagement.Text = "My Requests";
                btn_UserManagement.Hide();
                btn_CreateUser.Hide();
                btnIncidentManagement.Hide();
                btnTicketArchive.Hide();
                pnlArchiveTickets.Hide();
                tabControl.SelectedIndex = 1;
                LoadTickets(TicketLoadStatus.Open);
                CleanTicketDetails();
                SetDashboardButtonStyling(1);
            }

            else if (employee.Type >= EmployeeType.Specialist)
            {
                tblCreateIncident.Hide();
                btnCreateIncident.Hide();
            }
        }



        public void DisplayTicketFormForEmployee(Employee employee)
        {
            InItAddTicketByRegularEmployeeComboBoxes();

            if (employee.Type >= EmployeeType.ServiceDesk)
            {
                tblCreateIncident.Hide();
                tblCreateTicket.Show();
                btnCreateIncident.Hide();
                btnSubmitTicketCT.Show();
            }

            if (employee.Type == EmployeeType.Regular)
            {
                lbl_HeaderCreateTicket.Text = "Report incident";

                tblCreateTicket.Hide();
                tblCreateIncident.Show();
                btnSubmitTicketCT.Hide();
                btnCreateIncident.Show();
                cmbIncidentType.SelectedIndex = -1;

            }

            lblValidationMessageForIncident.Hide();

        }



        private void Btn_CreateTicket_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 2)
            {
                tabControl.SelectedIndex = 2;
            }


            LoadAddTicketPage();
            DisplayTicketFormForEmployee(employee);

        }

        private void Btn_UserManagement_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 3)
            {
                tabControl.SelectedIndex = 3;
            }
        }

        private void Btn_CreateUser_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 4)
            {
                tabControl.SelectedIndex = 4;
                LoadCreateTicketPage();
            }
        }

        private void LoadCreateTicketPage()
        {
            LoadUserTypes();
            ClearRegisterForm();
            btnCreatePassword.Enabled = true;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "log out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TabControl_IndexChanged(object sender, EventArgs e)
        {
            // Set active button
            SetDashboardButtonStyling(tabControl.SelectedIndex);
        }

        /// <summary>
        /// Edits the navigation button styling when a tab change occurs. 
        /// </summary>
        /// <param name="buttonIndex">Navigation button to adjust.</param>
        private void SetDashboardButtonStyling(int buttonIndex)
        {
            int index = 0;

            // Set button colors
            foreach (Button button in flowPnl_Navigation.Controls.OfType<Button>())
            {
                if (index != buttonIndex) // Reset color to default
                {
                    button.ForeColor = Color.White;
                    button.BackColor = themeGreen;
                    button.FlatAppearance.MouseOverBackColor = lightGreen;
                }
                else // Set color to active
                {
                    button.ForeColor = themeGreen;
                    button.BackColor = buttonHighLight;
                    button.FlatAppearance.MouseOverBackColor = buttonHighLight;
                }

                index++;
            }

            // Set button images
            SetButtonImage(buttonIndex);
        }

        /// <summary>
        /// Inverts the color of the button image.
        /// </summary>
        /// <param name="buttonIndex">Button to adjust.</param>
        private void SetButtonImage(int buttonIndex)
        {
            // Reset all navigation buttons to default
            btn_Dashboard.Image = Properties.Resources.icon_Home_Normal;
            btn_TicketManagement.Image = Properties.Resources.icon_Ticket_Management_Normal;
            btn_CreateTicket.Image = Properties.Resources.icon_Ticket_Create_Normal;
            btn_UserManagement.Image = Properties.Resources.icon_User_Management_Normal;
            btn_CreateUser.Image = Properties.Resources.icon_User_Create_Normal;

            switch (buttonIndex)
            {
                case 0:
                    btn_Dashboard.Image = btn_Dashboard.Image.InvertImage();
                    break;
                case 1:
                    btn_TicketManagement.Image = btn_TicketManagement.Image.InvertImage();
                    break;
                case 2:
                    btn_CreateTicket.Image = btn_CreateTicket.Image.InvertImage();
                    break;
                case 3:
                    btn_UserManagement.Image = btn_UserManagement.Image.InvertImage();
                    break;
                case 4:
                    btn_CreateUser.Image = btn_CreateUser.Image.InvertImage();
                    break;
            }
        }

        // Dashboard buttons
        private void Btn_ShowAllIncidents_Click(object sender, EventArgs e)
        {
            // Open ticket overview
            tabControl.SelectedIndex = 1;

            // Load all tickets
            LoadTickets(TicketLoadStatus.All);
            SetTicketManagementButtonStyling(0);
        }

        private void RPnl_D1_Open_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all open incidents
            LoadTickets(TicketLoadStatus.Open);
            SetTicketManagementButtonStyling(1);
        }

        private void RPnl_D2_Past_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all past deadline incidents
            LoadTickets(TicketLoadStatus.PastDeadline);
            SetTicketManagementButtonStyling(2);
        }

        private void RPnl_D3_Unresolved_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all unresolved incidents
            LoadTickets(TicketLoadStatus.Unresolved);
            SetTicketManagementButtonStyling(3);
        }

        private void RPnl_D4_Resolved_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all resolved incidents
            LoadTickets(TicketLoadStatus.Resolved);
            SetTicketManagementButtonStyling(4);
        }

        /// <summary>
        /// Loads the tickets from the database.
        /// </summary>
        /// <param name="loadStatus">Status to filter by.</param>
        private void LoadTickets(TicketLoadStatus loadStatus)
        {
            List<Ticket> tickets;

            // Load type of tickets
            switch (loadStatus)
            {
                case TicketLoadStatus.Open:
                    // Load open tickets
                    tickets = ticketService.GetTicketsByStatus(TicketStatus.Open, employee);
                    break;
                case TicketLoadStatus.PastDeadline:
                    // Load tickets past deadline
                    tickets = ticketService.GetTicketsByStatus(TicketStatus.PastDeadline, employee);
                    break;
                case TicketLoadStatus.Unresolved:
                    // Load unresolved tickets
                    tickets = ticketService.GetTicketsByStatus(TicketStatus.Unresolved, employee);
                    break;
                case TicketLoadStatus.Resolved:
                    // Load resolved tickets
                    tickets = ticketService.GetTicketsByStatus(TicketStatus.Resolved, employee);
                    break;
                case TicketLoadStatus.Closed:
                    // Load Closed tickets
                    tickets = ticketService.GetClosedTickets(employee);
                    break;
                default:
                    ticketService.GetTickets(out tickets, employee);
                    // Load all tickets
                    break;
            }

            currentTicketLoadStatus = loadStatus;

            // Display tickets
            allTickets = tickets;
            DisplayTickets(tickets);
        }

        private void DisplayTickets(List<Ticket> tickets)
        {
            // Clear before filling list
            listView_TicketManagement.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                // Create listview item and fill details
                ListViewItem item = new ListViewItem(ticket.Id.ToString(), 0);
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.Reporter.FirstName);
                item.SubItems.Add(ticket.Date.ToString());
                item.SubItems.Add(ticket.Status.ToString());
                if (ticket.IsClosed == true)
                {
                    item.SubItems.Add("Yes");
                }
                else
                {
                    item.SubItems.Add("No");
                }

                item.Tag = ticket;

                // Add item to listview
                listView_TicketManagement.Items.Add(item);
            }

            UpdateTicketManagementColumnWidths();
        }

        /// <summary>
        /// Resizes the columns in ticket management to fit the entire list view width.
        /// </summary>
        private void UpdateTicketManagementColumnWidths()
        {
            // Resize columns
            listView_TicketManagement.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_TicketManagement.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_TicketManagement.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);

            int widthOfAllColumns = 0;
            for (int i = 0; i < listView_TicketManagement.Columns.Count; ++i)
            {
                if (i > 0)
                {
                    listView_TicketManagement.Columns[i].Width += 20;
                }
                widthOfAllColumns += listView_TicketManagement.Columns[i].Width;
            }
            listView_TicketManagement.Columns[1].Width += listView_TicketManagement.Width - widthOfAllColumns - 4;
        }

        /// <summary>
        /// Loads ticket submitting page data.
        /// </summary>
        private void LoadAddTicketPage()
        {
            txtSubjectOfIncidentCT.Text = "";
            txtDescriptionCT.Text = "";
            cmbIncidentTypeCT.SelectedIndex = -1;
            cmbDeadlineCT.SelectedIndex = -1;
            cmbPriorityCT.SelectedIndex = -1;
            lblWarningsCT.Text = "";

            dtpReportedCT.Value = DateTime.Now;

            cmbUserCT.DataSource = employeeService.GetEmployees();
            cmbUserCT.SelectedIndex = -1;
        }

        private void btnSubmitTicketCT_Click(object sender, EventArgs e)
        {
            //setting the attributes that are different based on employee type
            var text = new TicketTextTransfer(txtSubjectOfIncidentCT.Text, txtDescriptionCT.Text);
            int followUpDays = cmbDeadlineCT.SelectedIndex == -1 ? -1 : deadlineDays[cmbDeadlineCT.SelectedItem.ToString()];
            var date = new TicketDateTransfer(dtpReportedCT.Value, followUpDays);
            var enums = new TicketEnumsTransfer((IncidentTypes)(cmbIncidentTypeCT.SelectedItem ?? -1), (TicketPriority)(cmbPriorityCT.SelectedItem ?? -1));
            var employeeData = new TicketEmployeeTransfer((Employee)cmbUserCT.SelectedItem, null);

            StatusStruct status = ticketService.InsertTicket(text, date, enums, employeeData);

            if (status.Code == 0)
            {
                // Clean text boxes.
                LoadAddTicketPage();

                lblWarningsCT.Text = "Submission succeeded!";
                lblWarningsCT.ForeColor = Color.Green;
            }
            else
            {
                lblWarningsCT.Text = "Unable to submit a ticket:\n" + status.Message;
                lblWarningsCT.ForeColor = Color.Red;
            }
        }

        private void btnCancelCT_Click(object sender, EventArgs e)
        {
            LoadAddTicketPage();
        }

        private void Btn_Display_Tickets_All_Click(object sender, EventArgs e)
        {
            LoadTickets(TicketLoadStatus.All);
            SetTicketManagementButtonStyling(0);
        }

        private void Btn_Display_Tickets_Open_Click(object sender, EventArgs e)
        {
            LoadTickets(TicketLoadStatus.Open);
            SetTicketManagementButtonStyling(1);
        }

        private void Btn_Display_Tickets_PastDeadline_Click(object sender, EventArgs e)
        {
            LoadTickets(TicketLoadStatus.PastDeadline);
            SetTicketManagementButtonStyling(2);
        }

        private void Btn_Display_Tickets_Unresolved_Click(object sender, EventArgs e)
        {
            LoadTickets(TicketLoadStatus.Unresolved);
            SetTicketManagementButtonStyling(3);
        }

        private void btn_Display_Tickets_Resolved_Click(object sender, EventArgs e)
        {
            LoadTickets(TicketLoadStatus.Resolved);
            SetTicketManagementButtonStyling(4);
        }

        private void SetTicketManagementButtonStyling(int buttonIndex)
        {
            int index = 0;

            foreach (Button button in flowPnl_TicketManagement_SearchButtons.Controls.OfType<Button>())
            {
                if (index != buttonIndex) // Reset color to default
                {
                    button.ForeColor = Color.White;
                    button.BackColor = themeGreen;
                    button.FlatAppearance.MouseOverBackColor = lightGreen;
                }
                else // Set color to active
                {
                    button.ForeColor = Color.White;
                    button.BackColor = buttonLightHightLight;
                    button.FlatAppearance.MouseOverBackColor = buttonLightHightLight;
                }

                index++;
            }
        }

        private void txtBox_SearchBar_TextChanged(object sender, EventArgs e)
        {
            var query = txtBox_SearchBar.Text.ToLower();
            var tickets = allTickets;
            if (!String.IsNullOrEmpty(query))
            {
                tickets = tickets.Where(x => x.Status.ToString().ToLower().Contains(query)
                                    || x.Description.ToLower().Contains(query)
                                    || x.Reporter.FirstName.ToLower().Contains(query)
                                    || x.Subject.ToLower().Contains(query)
                                    || x.Date.ToString().Contains(query)
                                    )
               .OrderByDescending(x => x.Date).ToList<Ticket>();
            }
            DisplayTickets(tickets);
        }

        private void listView_TicketManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_TicketManagement.SelectedItems.Count == 0)
            {
                CleanTicketDetails();
            }
            else
            {
                Ticket ticket = (Ticket)listView_TicketManagement.SelectedItems[0].Tag;
                LoadSelectedTicketDetails(ticket);
            }
        }

        private void LoadSelectedTicketDetails(Ticket ticket)
        {
            detailedTicket = ticket;

            txtDetailsSubject.Text = detailedTicket.Subject;
            txtDetailsDescription.Text = detailedTicket.Description;
            cmbDetailsIncidentType.SelectedIndex = (int)detailedTicket.IncidentType;
            cmbDetailsPriority.SelectedIndex = (int)detailedTicket.Priority;
            cmbDetailsStatus.SelectedItem = detailedTicket.Status;
            cmbDetailsReporter.SelectedItem = detailedTicket.Reporter;

            btnDetailsEscalate.Enabled = ticketEscalationService.IsTicketEscalatable(ticket, employee);

            // Do not let editing, if ticket's closed.
            if (ticket.IsClosed)
            {
                btnDetailsClose.Enabled = false;
                return;
            }

            txtDetailsSubject.Enabled = true;
            txtDetailsDescription.Enabled = true;
            cmbDetailsIncidentType.Enabled = true;
            cmbDetailsPriority.Enabled = true;
            cmbDetailsStatus.Enabled = true;
            cmbDetailsReporter.Enabled = true;

            btnDetailsDelete.Enabled = true;
            btnDetailsUpdate.Enabled = true;
            btnDetailsClose.Enabled = true;
        }

        private void btnDetailsUpdate_Click(object sender, EventArgs e)
        {
            var text = new TicketTextTransfer(txtDetailsSubject.Text, txtDetailsDescription.Text);
            var enums = new TicketEnumsTransfer((IncidentTypes)cmbDetailsIncidentType.SelectedItem,
                                                (TicketPriority)cmbDetailsPriority.SelectedItem,
                                                (TicketStatus)cmbDetailsStatus.SelectedItem);
            var employeeTransfer = new TicketEmployeeTransfer((Employee)cmbDetailsReporter.SelectedItem);

            StatusStruct status = ticketService.UpdateTicket(detailedTicket, text, enums, employeeTransfer);

            if (status.Code == 0)
            {
                LoadTickets(currentTicketLoadStatus);
                CleanTicketDetails();
                lblDetailsWarning.Text = "";
            }
            else
            {
                lblDetailsWarning.Text = status.Message;
            }
        }

        private void btnDetailsDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete ticket:\n\n" +
                                                  $"[{detailedTicket.Id}]{detailedTicket.Subject}\n\n" +
                                                  $"This operation is irreversible!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                StatusStruct status = ticketService.DeleteTicket(detailedTicket);

                if (status.Code == 0)
                {
                    LoadTickets(currentTicketLoadStatus);
                    CleanTicketDetails();
                    lblDetailsWarning.Text = "";
                }
                else
                {
                    lblDetailsWarning.Text = status.Message;
                }
            }
        }

        private void btnDetailsEscalate_Click(object sender, EventArgs e)
        {
            if (listView_TicketManagement.SelectedItems.Count == 0)
            {
                return;
            }

            Ticket ticket = listView_TicketManagement.SelectedItems[0].Tag as Ticket;
            DialogResult result = MessageBox.Show($"This will escalete the ticket {ticket.Id} to " +
                $"{((EmployeeType)ticket.EscalationLevel + 2).Prettify()} department.\n" +
                $"Continue?", "Quiestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                StatusStruct status = ticketEscalationService.EscalateTicket(ticket, employee);

                if (status.Code == 0)
                {
                    LoadTickets(currentTicketLoadStatus);
                    CleanTicketDetails();
                    lblDetailsWarning.Text = "";
                }
                else
                {
                    lblDetailsWarning.Text = status.Message;
                }
            }
        }

        private void Main_ResizeBegin(object sender, EventArgs e)
        {
            PreResize();
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            PostResize();
        }

        protected override void WndProc(ref Message m)
        {
            // Overrides the default behaviour of Maximize/Minimize buttons.
            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_MAXIMIZE || (int)m.WParam == SC_RESTORE))
            {
                // Main_ResizeBegin doesn't seem to be called when Maximize/Restore button is clicked.
                // So we do that before resize behaviour is called.
                PreResize();
                base.WndProc(ref m);
                // And now postresize.
                PostResize();
                return;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Called before resize happens. Saves the position of splitter in split container inside of Ticket Management.
        /// Then it pauses the drawing rPnl_TicketManagement, to prevent slow resizing.
        /// </summary>
        private void PreResize()
        {
            splitPercentage = splitContainer1.SplitterDistance / (double)splitContainer1.Width;
            rPnl_TicketManagement.SuspendLayout();
            rPnl_TicketManagement.SuspendDrawing();
            rPnl_TicketManagement.Invalidate(true);
        }

        /// <summary>
        /// Resumes rPnl_TicketManagement to operating state, and recalculates the position of splitter in Ticket Management.
        /// </summary>
        private void PostResize()
        {
            rPnl_TicketManagement.ResumeLayout();
            rPnl_TicketManagement.ResumeDrawing();
            splitContainer1.SplitterDistance = (int)(splitContainer1.Width * splitPercentage);
            UpdateTicketManagementColumnWidths();
        }

        private void btnDetailsClose_Click(object sender, EventArgs e)
        {
            StatusStruct status = ticketService.CloseTicket(detailedTicket);

            if (status.Code == 0)
            {
                LoadTickets(currentTicketLoadStatus);
                CleanTicketDetails();
                lblDetailsWarning.Text = "";
            }
            else
            {
                lblDetailsWarning.Text = status.Message;
            }
        }

        private void btn_Display_Tickets_Closed_Click(object sender, EventArgs e)
        {
            LoadTickets(TicketLoadStatus.Closed);
            SetTicketManagementButtonStyling(5);
        }


        public void SetInitialValuesForIncidentData()
        {
            cmbNewIncidentType.SelectedIndex = -1;
            cmbUser.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbDeadlineInterval.SelectedIndex = -1;

        }

        private void btnIncidentManagement_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 5)
            {
                tabControl.SelectedIndex = 5;

                lblValidationForIncidentList.Hide();

                try
                {
                    CreateIncidentsListView();
                }
                catch (Exception exception)
                {
                    lblValidationForIncidentList.Show();
                    lblValidationForIncidentList.Text = exception.Message;
                }

                InItCreateTicketFromIncidentComboBoxes();
                SetInitialValuesForIncidentData();
                lblValidationCreateTicket.Hide();

            }
        }


        public void InItCreateTicketFromIncidentComboBoxes()
        {
            cmbNewIncidentType.DataSource = Enum.GetValues(typeof(IncidentTypes));

            List<Employee> employees = employeeService.GetEmployees();

            foreach (Employee employee in employees)
            {
                cmbUser.Items.Add(employee.Username);
            }

            cmbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            cmbStatus.DataSource = Enum.GetValues(typeof(TicketStatus));

            foreach (KeyValuePair<string, int> interval in deadlineDays)
            {
                cmbDeadlineInterval.Items.Add(interval.Key);

            }
        }


        public void CreateIncidentsListView()
        {

            // clear the listview before adding data
            listViewIncidents.Clear();

            //set the listView to details view

            listViewIncidents.View = View.Details;

            // Allow the user to rearrange columns.

            listViewIncidents.AllowColumnReorder = false;


            // Select the item and subitems when selection is made.
            listViewIncidents.FullRowSelect = true;

            // Display grid lines.
            listViewIncidents.GridLines = true;


            //created the columns for the attributes of the incident class
            listViewIncidents.Columns.Add("Id", 70, HorizontalAlignment.Left);
            listViewIncidents.Columns.Add("Subject", 475, HorizontalAlignment.Left);
            listViewIncidents.Columns.Add("UserId", 270, HorizontalAlignment.Left);
            listViewIncidents.Columns.Add("Incident type", 270, HorizontalAlignment.Left);
            listViewIncidents.Columns.Add("Logged on", 270, HorizontalAlignment.Left);
            listViewIncidents.Columns.Add("Description", 150, HorizontalAlignment.Left);

            listViewIncidents.Columns[2].Width = 0;
            listViewIncidents.Columns[5].Width = 0;

            // Get all incidents
            List<BsonDocument> incidents = incidentService.GetAllIncidents();
            incidentList = incidentService.ConvertAllDocumentsToIncidentList(incidents);

            // Create a filtered list of incidents for display, avoids messing with the pre-loaded list for filtering.
            filteredIncidents = incidentList;

            // Populate listview
            PopulateIncidentList();
        }

        private void PopulateIncidentList()
        {
            if (incidentList.Count == 0)
            {
                throw new Exception("There are currently no incidents");
            }

            // Clear listview before populating to avoid duplicates.
            listViewIncidents.Items.Clear();

            // Populate the listview
            for (int i = 0; i < filteredIncidents.Count; i++)
            {
                ListViewItem incident = new ListViewItem(filteredIncidents[i].Id.ToString());

                //Add the tag used to update a record in the database
                incident.Tag = filteredIncidents[i];

                incident.SubItems.Add(filteredIncidents[i].Subject.ToString());
                incident.SubItems.Add(filteredIncidents[i].UserId.ToString());
                incident.SubItems.Add(filteredIncidents[i].IncidentType.ToString());
                incident.SubItems.Add(filteredIncidents[i].LoggedOn.ToString());
                incident.SubItems.Add(filteredIncidents[i].Description.ToString());

                listViewIncidents.Items.Add(incident);
            }
        }

        private void listViewIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIncidents.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listViewIncidents.SelectedItems[0];
                Incident incident = (Incident)selectedItem.Tag;
                Employee reportingUser = employeeService.GetById(incident.UserId);
                lblSubmittedByUser.Text = $" Submitted by {reportingUser.FirstName} " + $" {reportingUser.LastName}";
                txtSubjectOfIncident.Text = incident.Subject.ToString();
                txtTypeOfIncident.Text = incident.IncidentType.ToString();
                txtDescriptionOfIncident.Text = incident.Description.ToString();

            }

            else
            {
                return;
            }

        }

        public void CreateIncident()
        {
            int incidentId = incidentService.RetrievePreviousIncidentId();
            string subject = txtIncidentSubject.Text;
            int userId = employee.Id;
            int idxCmbIncidentType = cmbIncidentType.SelectedIndex;
            IncidentTypes incidentType = (IncidentTypes)idxCmbIncidentType;
            DateTime loggedOn = DateTime.Now;
            string description = txtIncidentDescription.Text;
            Incident incident = new Incident(incidentId, subject, userId, incidentType, loggedOn, description);

            if (subject.Length == 0 || idxCmbIncidentType == -1 || description.Length == 0) { throw new Exception("All fields are required"); }

            else
            {
                incidentService.CreateIncident(incident);

            }
        }

        /// <summary>
        /// Attempts to filter the pre-loaded incident list.
        /// </summary>
        private void btnFilterIncidents_Click(object sender, EventArgs e)
        {
            // If values have been entered, filter the list
            if (!string.IsNullOrWhiteSpace(txtBox_IncidentKeywords.Text))
            {
                // Get string out of the keywords textbox
                string filter = txtBox_IncidentKeywords.Text;

                // Filter the list
                filteredIncidents = incidentFilterService.FilterIncidents(incidentList, filter);
            }
            else
            {
                // Set filtered list to display all
                filteredIncidents = incidentList;
            }

            // Repopulate list
            PopulateIncidentList();
        }

        /// <summary>
        /// Removes all filters and loads the default pre-loaded incident list.
        /// </summary>
        private void btnClearIncidentFilters_Click(object sender, EventArgs e)
        {
            // Remove filters
            txtBox_IncidentKeywords.Text = "";

            // Load default pre-loaded list
            filteredIncidents = incidentList;

            // Repopulate listview
            PopulateIncidentList();
        }

        public void CleanIncidentFormFields()
        {
            txtIncidentSubject.Clear();
            cmbIncidentType.SelectedIndex = -1;
            txtIncidentDescription.Clear();
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            try
            {
                CreateIncident();
                CleanIncidentFormFields();
                lblValidationMessageForIncident.Show();
                lblValidationMessageForIncident.ForeColor = Color.Green;
                lblValidationMessageForIncident.Text = "Your request was registered";
            }

            catch (Exception exp)
            {
                lblValidationMessageForIncident.Show();
                lblValidationMessageForIncident.Text = exp.Message;

            }
        }

        public void createTicketFromIncident()
        {

            int cmbNewIncidentTypeValue = (int)cmbNewIncidentType.SelectedIndex;
            int cmbSelectedUserValue = (int)cmbUser.SelectedIndex;
            int cmbPriorityValue = (int)cmbPriority.SelectedIndex;
            int cmbStatusValue = (int)cmbStatus.SelectedIndex;
            int deadlineIntervalValue = (int)cmbDeadlineInterval.SelectedIndex;
            if (cmbNewIncidentTypeValue == -1 ||
                cmbSelectedUserValue == -1 ||
                cmbPriorityValue == -1 ||
                cmbStatusValue == -1 ||
                deadlineIntervalValue == -1) { throw new Exception("All fields are required"); }

            else
            {
                int ticketCount = ticketService.GetTotalTicketCount();
                int previousTicketId = ticketService.GetHighestId();
                int ticketId;
                if (ticketCount == 0) { ticketId = 0; }
                else { ticketId = ++previousTicketId; }
                IncidentTypes incidentType = (IncidentTypes)cmbNewIncidentType.SelectedIndex;
                string subject = txtSubjectOfIncident.Text;
                string description = txtDescriptionOfIncident.Text;
                Employee reporter = employeeService.GetByUsername(cmbUser.SelectedItem.ToString());
                DateTime date = DateTime.Now;
                int deadlineDays = (int)cmbDeadlineInterval.SelectedIndex;
                DateTime deadline = date.AddDays(deadlineDays);
                TicketPriority priority = (TicketPriority)cmbPriority.SelectedIndex;
                TicketStatus status = (TicketStatus)cmbStatus.SelectedIndex;
                int escalationLevel = 0;


                Ticket ticket = new Ticket();
                ticket.Id = ticketId;
                ticket.IncidentType = incidentType;
                ticket.Subject = subject;
                ticket.Description = description;
                ticket.Reporter = reporter;
                ticket.Date = date;
                ticket.Deadline = deadline;
                ticket.Priority = priority;
                ticket.Status = status;
                ticket.EscalationLevel = escalationLevel;
                ticket.IsClosed = false;

                incidentService.CreateTicketFromIncident(ticket);
            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                createTicketFromIncident();
                SetInitialValuesForIncidentData();
                lblValidationCreateTicket.Show();
                lblValidationCreateTicket.ForeColor = Color.Green;
                lblValidationCreateTicket.Text = "The ticket was created";
            }
            catch (Exception exp)
            {
                lblValidationCreateTicket.Show();
                lblValidationCreateTicket.Text = exp.Message;
            }
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (IsTextBoxesEmpty())
            {
                lblWarning.Text = "Please fill in all the blanks.";
            }
            else
            {
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string firsname = txtFirstName.Text;
                string lastname = txtLastName.Text;
                EmployeeType type = (EmployeeType)comboEmployeeType.SelectedIndex;
                string passwordHash = password.HashedPassword;
                string salt = password.Salt;

                StatusStruct status = employeeService.CreateUser(email, username, firsname, lastname, type, passwordHash, salt);

                if (status.Code == 0)
                {
                    password = null;
                    LoadCreateTicketPage();
                }
                else
                {
                    MessageBox.Show(status.Message);
                }
            }
        }

        private void LoadUserTypes()
        {
            comboEmployeeType.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(EmployeeType)))
            {
                comboEmployeeType.Items.Add(item);
            }
        }

        private bool IsTextBoxesEmpty()
        {
            bool empty = false;

            foreach (Control tb in rPnl_CreateUser.Controls)
            {
                if (tb is TextBox)
                {
                    if (string.IsNullOrEmpty(tb.Text))
                    {
                        empty = true;
                        break;
                    }
                }
            }
            return empty;
        }

        private void ClearRegisterForm()
        {
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            comboEmployeeType.SelectedIndex = -1;
            txtPassword.Text = "";
        }
        private void LoadAssignedEmployees()
        {
            cmbEmployees.Items.Clear();
            List<Employee> employees = employeeService.GetEmployeesByType(EmployeeType.ServiceDesk);
            foreach (var item in employees)
            {
                cmbEmployees.Items.Add(item);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Ticket ticket = (Ticket)listView_TicketManagement.SelectedItems[0].Tag;
            if(ticket.AssignedEmployee == employee)
            {
                Employee transferEmployee = (Employee)cmbEmployees.SelectedItem;
                StatusStruct status = ticketTransferService.TransferTicket(ticket, transferEmployee);
                if (status.Code == 0)
                {
                    cmbEmployees.SelectedIndex = -1;
                    listView_TicketManagement.SelectedIndices.Clear();
                }
                else
                {
                    MessageBox.Show(status.Message);
                }
            }
            else
            {
                MessageBox.Show("You are not the assigned employee of selected ticket.");
            }

        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (loginService == null)
            {
                loginService = new LoginService();
            }
            int length = 8;
            string passwrd = employeeService.GetRandomPassword(length);
            password = loginService.CreateHashedPasswordWithSalt(passwrd);
            txtPassword.Text = passwrd;
            btnCreatePassword.Enabled = false;
        }

        private void btnArchiveTickets_Click(object sender, EventArgs e)
        {
            lblValidationForArchiving.Show();
            try
            {
                archivedTicketService.ArchiveTickets(this.employee);

                lblValidationForArchiving.ForeColor = Color.Green;
                lblValidationForArchiving.Text = "The tickets were archived";
            }
            catch (Exception exception)
            {
                lblValidationForArchiving.Text = exception.Message;
            }
        }

        public void CreateArchivedTicketsListView()
        {

            // clear the listview before adding data
            listViewArchivedTickets.Clear();

            //set the listView to details view

            listViewArchivedTickets.View = View.Details;

            // Allow the user to rearrange columns.

            listViewArchivedTickets.AllowColumnReorder = false;


            // Select the item and subitems when selection is made.
            listViewArchivedTickets.FullRowSelect = true;

            // Display grid lines.
            listViewArchivedTickets.GridLines = true;


            //created the columns for the attributes of the incident class
            listViewArchivedTickets.Columns.Add("Id", 70, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Type", 100, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Subject", 280, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Description", 70, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("TicketId", 70, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Date", 200, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Deadline", 70, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Priority", 70, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("Escalation level", 70, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("IsClosed", 100, HorizontalAlignment.Left);
            listViewArchivedTickets.Columns.Add("ArchivingDate", 200, HorizontalAlignment.Left);

            listViewArchivedTickets.Columns[3].Width = 0;
            listViewArchivedTickets.Columns[4].Width = 0;
            listViewArchivedTickets.Columns[6].Width = 0;
            listViewArchivedTickets.Columns[7].Width = 0;
            listViewArchivedTickets.Columns[9].Width = 0;

            List<BsonDocument> archivedTickets = archivedTicketService.GetAllArchivedTickets();
            List<ArchivedTicket> archivedTicketList = archivedTicketService.ConvertAllDocumentsToArchivedTicketList(archivedTickets);

            if (archivedTicketList.Count == 0)
            {
                throw new Exception("There are currently no archived tickets");
            }

            for (int i = 0; i < archivedTicketList.Count; i++)
            {
                ListViewItem archivedTicket = new ListViewItem(archivedTicketList[i].Id.ToString());

                //Add the tag used to update a record in the database
                archivedTicket.Tag = archivedTicketList[i];

                archivedTicket.SubItems.Add(archivedTicketList[i].IncidentType.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].Subject);
                archivedTicket.SubItems.Add(archivedTicketList[i].Description);
                archivedTicket.SubItems.Add(archivedTicketList[i].TicketId.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].Date.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].Deadline.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].Priority.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].Status.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].EscalationLevel.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].IsClosed.ToString());
                archivedTicket.SubItems.Add(archivedTicketList[i].ArchivingDate.ToString());

                listViewArchivedTickets.Items.Add(archivedTicket);
            }
        }

        private void btnTicketArchive_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex != 6)
            {
                tabControl.SelectedIndex = 6;

                lblValidationForArchivedTicketList.Hide();

                try
                {
                    CreateArchivedTicketsListView();
                }
                catch (Exception exception)
                {
                    lblValidationForArchivedTicketList.Show();
                    lblValidationForArchivedTicketList.Text = exception.Message;
                }

            }
        }

        private void listViewArchivedTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BsonDocument> archivedTickets = archivedTicketService.GetAllArchivedTickets();

            List<ArchivedTicket> archivedTicketList = archivedTicketService.ConvertAllDocumentsToArchivedTicketList(archivedTickets);

            if (listViewArchivedTickets.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewArchivedTickets.SelectedItems[0];
                ArchivedTicket archivedTicket = (ArchivedTicket)selectedItem.Tag;
                txtSubject.Text = archivedTicket.Subject.ToString();
                txtIncidentType.Text = archivedTicket.IncidentType.ToString();
                txtDescription.Text = archivedTicket.Description.ToString();
            }

            else
            {
                return;
            }
        }

        private void btnSelectAllIncidents_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewIncidents.Items)
            {
                item.Selected = true;
            }

        }

        private void btnDeleteSelectedIncidents_Click(object sender, EventArgs e)
        {

            if (listViewIncidents.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewIncidents.Items)
                {
                    if (item.Selected == true)
                    {
                        Incident incident = (Incident)item.Tag;
                        incidentService.RemoveIncidentFromIncidentDb(incident.Id);
                        listViewIncidents.Items.Remove(item);

                    }
                }

                txtSubjectOfIncident.Clear();
                txtTypeOfIncident.Clear();
                txtDescriptionOfIncident.Clear();
            }
        }


        private void btnSelectAllArchivedTickets_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewArchivedTickets.Items)
            {
                item.Selected = true;
            }
        }

        private void btnDeleteSelectionFromArchive_Click(object sender, EventArgs e)
        {
            if (listViewArchivedTickets.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewArchivedTickets.Items)
                {
                    if (item.Selected == true)
                    {
                        ArchivedTicket archivedTicket = (ArchivedTicket)item.Tag;
                        archivedTicketService.RemoveArchivedTicketFromArchivedTicketDb(archivedTicket.Id);
                        listViewArchivedTickets.Items.Remove(item);
                    }
                }

                txtSubject.Clear();
                txtIncidentType.Clear();
                txtDescription.Clear();
            }
        }
    }
}
