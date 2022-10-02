using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using System.Drawing;

namespace DemoApp
{
    public partial class Main : Form
    { 
        private Databases databases;
        private TicketsService ticketService;
        private Employee employee;

        // Styling variables
        readonly Color themeGreen = ColorTranslator.FromHtml("#3E8061");
        readonly Color lightGreen = ColorTranslator.FromHtml("#479B74");
        readonly Color buttonHighLight = ColorTranslator.FromHtml("#FFF6DE");


        public Main()
        {
            InitializeComponent();

            //!! Probably should have an Employee parameter to display user data and for future references
            //this.employee = employee;
            //databases = new Databases();
            ticketService = new TicketsService();

            // Set tab control panel tabs to invisible
            tabControl.ItemSize = new Size(0, 1);

            // Invert standard image icon
            btn_Dashboard.Image = InvertImage(btn_Dashboard.Image);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //var dbList = databases.Get_All_Databases();

            //foreach (var db in dbList)
            //{
            //    listBox1.Items.Add(db.name);
            //}

            // Load dashboard data
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
                LoadTickets("");
            }
        }

        private void Btn_CreateTicket_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 2)
            {
                tabControl.SelectedIndex = 2;
            }
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
            // Log out
        }



        // Tab control
        private void TabControl_IndexChanged(object sender, EventArgs e)
        {
            // Set active button
            SetButtonStyling(tabControl.SelectedIndex);
        }



        // Styling
        private void SetButtonStyling(int buttonIndex)
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
                    btn_Dashboard.Image = InvertImage(btn_Dashboard.Image);
                    break;
                case 1:
                    btn_TicketManagement.Image = InvertImage(btn_TicketManagement.Image);
                    break;
                case 2:
                    btn_CreateTicket.Image = InvertImage(btn_CreateTicket.Image);
                    break;
                case 3:
                    btn_UserManagement.Image = InvertImage(btn_UserManagement.Image);
                    break;
                case 4:
                    btn_CreateUser.Image = InvertImage(btn_CreateUser.Image);
                    break;
            }
        }

        /// <summary>
        /// Inverts the image.
        /// </summary>
        /// <param name="image">Input image.</param>
        /// <returns>Inverted version of the same image.</returns>
        private Image InvertImage(Image image)
        {
            for (int x = 0; x < image.Width - 1; x++)
            {
                for (int y = 0; y < image.Height - 1; y++)
                {
                    Color inv = ((Bitmap)image).GetPixel(x, y);
                    if (inv.A > 0)
                    {
                        inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    }
                    ((Bitmap)image).SetPixel(x, y, inv);
                }
            }

            return image;
        }

        // Dashboard buttons
        private void Btn_ShowAllIncidents_Click(object sender, EventArgs e)
        {
            // Open ticket overview
            tabControl.SelectedIndex = 1;

            // Load all tickets
            LoadTickets("");
        }

        private void RPnl_D1_Open_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all open incidents
            LoadTickets("open");
        }

        private void RPnl_D2_Past_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all past deadline incidents
            LoadTickets("pastdeadline");
        }

        private void RPnl_D3_Unresolved_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all unresolved incidents
            LoadTickets("unresolved");
        }

        private void RPnl_D4_Resolved_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            // Load all resolved incidents
            LoadTickets("resolved");
        }

        // Methods
        private void LoadTickets(string type)
        {
            // Load type of tickets
            switch (type.ToLower())
            {
                case "open":
                    // Load open tickets
                    break;
                case "pastdeadline":
                    // Load tickets past deadline
                    break;
                case "unresolved":
                    // Load unresolved tickets
                    break;
                case "resolved":
                    // Load resolved tickets
                    break;
                default:
                    // Load all tickets
                    break;
            }
        }
    }
}
