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

        // Styling variables
        readonly Color themeGreen = ColorTranslator.FromHtml("#3E8061");
        readonly Color lightGreen = ColorTranslator.FromHtml("#479B74");
        readonly Color buttonHighLight = ColorTranslator.FromHtml("#FFF6DE");


        public Main()
        {
            InitializeComponent();
            databases = new Databases();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //var dbList = databases.Get_All_Databases();

            //foreach (var db in dbList)
            //{
            //    listBox1.Items.Add(db.name);
            //}

            // Set tab control panel tabs to invisible
            tabControl.ItemSize = new Size(0, 1);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Navigation buttons
        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 0)
            {
                tabControl.SelectedIndex = 0;
            }
        }

        private void Btn_TicketManagement_Click(object sender, EventArgs e)
        {
            // Set current if not already selected
            if (tabControl.SelectedIndex != 1)
            {
                tabControl.SelectedIndex = 1;
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

            int index = 0;
            
            // Set active button image
            foreach (Button button in flowPnl_Navigation.Controls.OfType<Button>())
            {
                if (index == buttonIndex)
                {
                    button.Image = Properties.Resources.icon_Home_Active;
                }
                else if (index == buttonIndex)
                {
                    button.Image = Properties.Resources.icon_Ticket_Management_Active;
                }
                else if (index == buttonIndex)
                {
                    button.Image = Properties.Resources.icon_User_Create_Active;
                }
                else if (index == buttonIndex)
                {
                    button.Image = Properties.Resources.icon_User_Management_Active;
                }
                else if (index == buttonIndex)
                {
                    button.Image = Properties.Resources.icon_User_Create_Active;
                }

                index++;
            }
        }
    }
}
