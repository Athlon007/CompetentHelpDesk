using System;
using System.Linq;
using System.Windows.Forms;
using Logic;
using Model;
using System.Drawing;
using System.Collections.Generic;
using DemoApp.Common;

namespace DemoApp
{
    public partial class Main : Form
    {
        private readonly TicketsService ticketService;
        private readonly EmployeeService employeeService;
        private readonly TicketEscalationService ticketEscalationService;
        private List<Ticket> allTickets;

        private readonly Employee employee;

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
            None = 0, All = 1, Open = 2, PastDeadline = 3, Unresolved = 4, Resolved = 5
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
                splitContainer1.SplitterDistance = btn_Display_Tickets_Resolved.Right + 10;
            }
        }

        /// <summary>
        /// Loads combo boxes data of Add Ticket page.
        /// </summary>
        private void InitAddTicketComboBoxes()
        {
            foreach (IncidentTypes incidentType in Enum.GetValues(typeof(IncidentTypes)))
            {
                cmbIncidentTypeCT.Items.Add(incidentType.ToString().Prettify());
            }

            foreach (TicketPriority priority in Enum.GetValues(typeof(TicketPriority)))
            {
                cmbPriorityCT.Items.Add(priority.ToString().Prettify());
            }

            foreach (KeyValuePair<string, int> kvp in deadlineDays)
            {
                cmbDeadlineCT.Items.Add(kvp.Key.ToString());
            }
        }

        private void InitTicketDetailsView()
        {
            foreach (IncidentTypes incidentType in Enum.GetValues(typeof(IncidentTypes)))
            {
                cmbDetailsIncidentType.Items.Add(incidentType.ToString().Prettify());
            }

            foreach (TicketPriority priority in Enum.GetValues(typeof(TicketPriority)))
            {
                cmbDetailsPriority.Items.Add(priority.ToString().Prettify());
            }

            foreach (TicketStatus status in Enum.GetValues(typeof(TicketStatus)))
            {
                cmbDetailsStatus.Items.Add(status.ToString().Prettify());
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

        private void LoadDashboardData()
        {
            // Variables (using long due to it being NoSQL/"Big Data")
            long ticketSum = -1, openTickets = -1, pastDeadlineTickets = -1, unresolvedTickets = -1, resolvedTickets = -1;

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
                // Display error, probably want to use a logger
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
            btnDetailsEscalate.Enabled = false;

            lblDetailsWarning.Text = "";
        }



        public void hideControlsForViewingTickets()
        {
            btn_Display_Tickets_All.Hide();
            btn_Display_Tickets_Open.Hide();
            btn_Display_Tickets_PastDeadline.Hide();
            btn_Display_Tickets_Resolved.Hide();
            btn_Display_Tickets_Unresolved.Hide();
        }


        public void DisplayDashboardForEmployee(Employee employee)
        {
            if (employee.Type == EmployeeType.Regular)
            {
                splitContainer1.Panel2.Hide();
                hideControlsForViewingTickets();
                btn_Dashboard.Hide();
                btn_TicketManagement.Text = "Show my tickets";
                btn_CreateTicket.Text = "Report incident";
                btn_UserManagement.Hide();
                btn_CreateUser.Hide();
                tabControl.SelectedIndex = 1;
                LoadTickets(TicketLoadStatus.Open);
                CleanTicketDetails();
                SetDashboardButtonStyling(1);
            }

            else if (employee.Type == EmployeeType.Specialist)
            {
                hideControlsForViewingTickets();
                btn_UserManagement.Hide();
                btn_CreateUser.Hide();

            }
        }



        public void DisplayTicketFormForEmployee(Employee employee)
        {

            if (employee.Type == EmployeeType.Regular)
            {
                lbl_HeaderCreateTicket.Text = "Report incident";
                lblDateTimeReportedCT.Hide();
                lblPriorityCT.Hide();
                lblReportedByUserCT.Hide();
                lblDeadlineCT.Text = "Please provide a short description also specifing when the problem occured.";
                dtpReportedCT.Hide();
                cmbUserCT.Hide();
                cmbPriorityCT.Hide();
                cmbDeadlineCT.Hide();
                btnSubmitTicketCT.Text = "Submit incident";
            }
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
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "log out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        // Tab control
        private void TabControl_IndexChanged(object sender, EventArgs e)
        {
            // Set active button
            SetDashboardButtonStyling(tabControl.SelectedIndex);
        }



        // Styling
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

        // Methods
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

                item.Tag = ticket;

                // Add item to listview
                listView_TicketManagement.Items.Add(item);
            }

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

            int followUpDays;
            TicketPriority priority;
            DateTime dateTimeReported;
            Employee reportingUser;

            if (employee.Type == EmployeeType.Regular)
            {
                followUpDays = 0;
                priority = 0;
                dateTimeReported = DateTime.Now;
                reportingUser = employee;
            }
            else
            {
                followUpDays = cmbDeadlineCT.SelectedIndex == -1 ? -1 : deadlineDays[cmbDeadlineCT.SelectedItem.ToString()];
                priority = (TicketPriority)cmbPriorityCT.SelectedIndex;
                dateTimeReported = dtpReportedCT.Value;
                reportingUser = (Employee)cmbUserCT.SelectedItem;
            }

            var submitted = ticketService.InsertTicket(dateTimeReported,
                txtSubjectOfIncidentCT.Text,
                (IncidentTypes)cmbIncidentTypeCT.SelectedIndex,
                reportingUser,
                priority,
                followUpDays,
                txtDescriptionCT.Text);

            if (submitted.Code == 0)
            {
                // Clean text boxes.
                LoadAddTicketPage();

                lblWarningsCT.Text = "Submission succeeded!";
                lblWarningsCT.ForeColor = Color.Green;
            }
            else if (submitted.Code == 1)
            {
                lblWarningsCT.Text = "Unable to submit a ticket:\n" + submitted.Message;
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
            cmbDetailsStatus.SelectedIndex = (int)detailedTicket.Status;
            cmbDetailsReporter.SelectedItem = detailedTicket.Reporter;

            txtDetailsSubject.Enabled = true;
            txtDetailsDescription.Enabled = true;
            cmbDetailsIncidentType.Enabled = true;
            cmbDetailsPriority.Enabled = true;
            cmbDetailsStatus.Enabled = true;
            cmbDetailsReporter.Enabled = true;

            btnDetailsDelete.Enabled = true;
            btnDetailsUpdate.Enabled = true;
            btnDetailsEscalate.Enabled = ticketEscalationService.IsTicketEscalatable(ticket);
        }

        private void btnDetailsUpdate_Click(object sender, EventArgs e)
        {
            var status = ticketService.UpdateTicket(detailedTicket,
                                      txtDetailsSubject.Text,
                                      txtDetailsDescription.Text,
                                      (IncidentTypes)cmbDetailsIncidentType.SelectedIndex,
                                      (TicketPriority)cmbDetailsPriority.SelectedIndex,
                                      (TicketStatus)cmbDetailsStatus.SelectedIndex,
                                      (Employee)cmbDetailsReporter.SelectedItem);

            if (status.Code == 1)
            {
                lblDetailsWarning.Text = status.Message;
            }
            else
            {
                LoadTickets(currentTicketLoadStatus);
                CleanTicketDetails();
                lblDetailsWarning.Text = "";
            }
        }

        private void btnDetailsDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete ticket:\n\n" +
                                                  $"ID: {detailedTicket.Id}\n" +
                                                  $"Subject: {detailedTicket.Subject}\n\n" +
                                                  $"This operation is irreversible!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var response = ticketService.DeleteTicket(detailedTicket);

                if (response.Code == 0)
                {
                    LoadTickets(currentTicketLoadStatus);
                    CleanTicketDetails();
                    lblDetailsWarning.Text = "";
                }
                else
                {
                    lblDetailsWarning.Text = response.Message;
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
            DialogResult result = MessageBox.Show($"This will escalete the ticket {ticket.Id} to {(EmployeeType)ticket.EscalationLevel + 2} department.\n" +
                                                 $"Continue?", "Quiestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var reply = ticketEscalationService.EscalateTicket(ticket);

                if (reply.Code == 0)
                {
                    LoadTickets(currentTicketLoadStatus);
                    CleanTicketDetails();
                    lblDetailsWarning.Text = "";
                }
                else
                {
                    lblDetailsWarning.Text = reply.Message;
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
        }
    }
}
