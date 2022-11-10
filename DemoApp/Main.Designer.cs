
namespace DemoApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new DemoApp.Custom_Controls.TabControlWithoutBorder();
            this.tab_Dashboard = new System.Windows.Forms.TabPage();
            this.rPnl_Dashboard = new DemoApp.Custom_Controls.RoundedPanel();
            this.tblPnl_Dashboard = new DemoApp.Custom_Controls.FasterTableLayoutPanel();
            this.rPnl_D1_Open = new DemoApp.Custom_Controls.RoundedPanel();
            this.circleBar_Open = new DemoApp.Custom_Controls.CircularProgressBar();
            this.lbl_OpenIncidents_Desc = new System.Windows.Forms.Label();
            this.lbl_OpenIncidents_Title = new System.Windows.Forms.Label();
            this.rPnl_D3_Unresolved = new DemoApp.Custom_Controls.RoundedPanel();
            this.circleBar_Unresolved = new DemoApp.Custom_Controls.CircularProgressBar();
            this.lbl_PastDeadline_Desc = new System.Windows.Forms.Label();
            this.lbl_PastDeadline_Title = new System.Windows.Forms.Label();
            this.rPnl_D2_Past = new DemoApp.Custom_Controls.RoundedPanel();
            this.circleBar_PastDeadline = new DemoApp.Custom_Controls.CircularProgressBar();
            this.lbl_Unresolved_Desc = new System.Windows.Forms.Label();
            this.lbl_Unresolved_Title = new System.Windows.Forms.Label();
            this.rPnl_D4_Resolved = new DemoApp.Custom_Controls.RoundedPanel();
            this.circleBar_Resolved = new DemoApp.Custom_Controls.CircularProgressBar();
            this.lbl_Resolved_Desc = new System.Windows.Forms.Label();
            this.lbl_Resolved_Title = new System.Windows.Forms.Label();
            this.pnl_DashBoard_Title = new System.Windows.Forms.Panel();
            this.btn_ShowAllIncidents = new DemoApp.Custom_Controls.RoundedButton();
            this.lbl_CurrentIncidents = new System.Windows.Forms.Label();
            this.header_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_HeaderDashboard = new System.Windows.Forms.Label();
            this.tab_TicketManagement = new System.Windows.Forms.TabPage();
            this.rPnl_TicketManagement = new DemoApp.Custom_Controls.RoundedPanel();
            this.pnl_TicketManagement = new DemoApp.Custom_Controls.RoundedPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTransfer = new DemoApp.Custom_Controls.RoundedButton();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.listView_TicketManagement = new System.Windows.Forms.ListView();
            this.col_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_IsClosed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBox_SearchBar = new DemoApp.Custom_Controls.TextBoxWithPrompt();
            this.flowPnl_TicketManagement_SearchButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Display_Tickets_All = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_Display_Tickets_Open = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_Display_Tickets_PastDeadline = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_Display_Tickets_Unresolved = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_Display_Tickets_Resolved = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_Display_Tickets_Closed = new DemoApp.Custom_Controls.RoundedButton();
            this.txtDetailsDescription = new System.Windows.Forms.TextBox();
            this.lblDetailsDescription = new System.Windows.Forms.Label();
            this.cmbDetailsDeadline = new System.Windows.Forms.ComboBox();
            this.lblDetailsDeadlineDays = new System.Windows.Forms.Label();
            this.lblDetailsWarning = new System.Windows.Forms.Label();
            this.cmbDetailsStatus = new System.Windows.Forms.ComboBox();
            this.lblDetailsStatus = new System.Windows.Forms.Label();
            this.cmbDetailsPriority = new System.Windows.Forms.ComboBox();
            this.lblDetailsPriority = new System.Windows.Forms.Label();
            this.cmbDetailsReporter = new System.Windows.Forms.ComboBox();
            this.lblDetailsUser = new System.Windows.Forms.Label();
            this.cmbDetailsIncidentType = new System.Windows.Forms.ComboBox();
            this.lblDetailsIncidentType = new System.Windows.Forms.Label();
            this.txtDetailsSubject = new System.Windows.Forms.TextBox();
            this.lblTicketDetailsSubjectOfIncident = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDetailsEscalate = new DemoApp.Custom_Controls.RoundedButton();
            this.btnDetailsUpdate = new DemoApp.Custom_Controls.RoundedButton();
            this.btnDetailsClose = new DemoApp.Custom_Controls.RoundedButton();
            this.btnDetailsDelete = new DemoApp.Custom_Controls.RoundedButton();
            this.header_TicketManagement = new System.Windows.Forms.Panel();
            this.lbl_HeaderTicketManagement = new System.Windows.Forms.Label();
            this.tab_CreateTicket = new System.Windows.Forms.TabPage();
            this.tblCreateIncident = new System.Windows.Forms.TableLayoutPanel();
            this.lblIncidentSubject = new System.Windows.Forms.Label();
            this.lblIncidentType = new System.Windows.Forms.Label();
            this.lblIncidentDescription = new System.Windows.Forms.Label();
            this.txtIncidentSubject = new System.Windows.Forms.TextBox();
            this.cmbIncidentType = new System.Windows.Forms.ComboBox();
            this.txtIncidentDescription = new System.Windows.Forms.TextBox();
            this.rPnl_CreateTicket = new DemoApp.Custom_Controls.RoundedPanel();
            this.lblValidationMessageForIncident = new System.Windows.Forms.Label();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.tblCreateTicket = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTimeReportedCT = new System.Windows.Forms.Label();
            this.dtpReportedCT = new System.Windows.Forms.DateTimePicker();
            this.lblSubjectOfIncidentCT = new System.Windows.Forms.Label();
            this.txtSubjectOfIncidentCT = new System.Windows.Forms.TextBox();
            this.txtDescriptionCT = new System.Windows.Forms.TextBox();
            this.lblTypeOfIncidentCT = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbDeadlineCT = new System.Windows.Forms.ComboBox();
            this.cmbIncidentTypeCT = new System.Windows.Forms.ComboBox();
            this.cmbPriorityCT = new System.Windows.Forms.ComboBox();
            this.lblDeadlineCT = new System.Windows.Forms.Label();
            this.lblReportedByUserCT = new System.Windows.Forms.Label();
            this.cmbUserCT = new System.Windows.Forms.ComboBox();
            this.lblPriorityCT = new System.Windows.Forms.Label();
            this.lblWarningsCT = new System.Windows.Forms.Label();
            this.btnCancelCT = new DemoApp.Custom_Controls.RoundedButton();
            this.btnSubmitTicketCT = new DemoApp.Custom_Controls.RoundedButton();
            this.header_CreateTicket = new System.Windows.Forms.Panel();
            this.lbl_HeaderCreateTicket = new System.Windows.Forms.Label();
            this.tab_UserManagement = new System.Windows.Forms.TabPage();
            this.rPnl_UserManagement = new DemoApp.Custom_Controls.RoundedPanel();
            this.header_UserManagement = new System.Windows.Forms.Panel();
            this.lbl_HeaderUserManagement = new System.Windows.Forms.Label();
            this.tab_CreateUser = new System.Windows.Forms.TabPage();
            this.rPnl_CreateUser = new DemoApp.Custom_Controls.RoundedPanel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreatePassword = new DemoApp.Custom_Controls.RoundedButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboEmployeeType = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnRegisterUser = new DemoApp.Custom_Controls.RoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.header_CreateUser = new System.Windows.Forms.Panel();
            this.lbl_HeaderCreateUser = new System.Windows.Forms.Label();
            this.tab_IncidentManagement = new System.Windows.Forms.TabPage();
            this.lblValidationForIncidentList = new System.Windows.Forms.Label();
            this.listViewIncidents = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlIncidentDetails = new System.Windows.Forms.Panel();
            this.lblDescriptionOfIncident = new System.Windows.Forms.Label();
            this.lblTypeOfIncident = new System.Windows.Forms.Label();
            this.lblSubjectOfIncident = new System.Windows.Forms.Label();
            this.txtSubjectOfIncident = new System.Windows.Forms.TextBox();
            this.txtTypeOfIncident = new System.Windows.Forms.TextBox();
            this.txtDescriptionOfIncident = new System.Windows.Forms.TextBox();
            this.lblSubmittedByUser = new System.Windows.Forms.Label();
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
            this.lblValidationCreateTicket = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblCreateTicket = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.cmbDeadlineInterval = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbNewIncidentType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNewIncidentType = new System.Windows.Forms.Label();
            this.sideBar = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnl_UserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.flowPnl_Navigation = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Dashboard = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_TicketManagement = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_CreateTicket = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_UserManagement = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_CreateUser = new DemoApp.Custom_Controls.RoundedButton();
            this.btnIncidentManagement = new DemoApp.Custom_Controls.RoundedButton();
            this.lbl_LogOut = new System.Windows.Forms.Label();
            this.tblPnl_Logo = new DemoApp.Custom_Controls.FasterTableLayoutPanel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_Dashboard.SuspendLayout();
            this.rPnl_Dashboard.SuspendLayout();
            this.tblPnl_Dashboard.SuspendLayout();
            this.rPnl_D1_Open.SuspendLayout();
            this.rPnl_D3_Unresolved.SuspendLayout();
            this.rPnl_D2_Past.SuspendLayout();
            this.rPnl_D4_Resolved.SuspendLayout();
            this.pnl_DashBoard_Title.SuspendLayout();
            this.header_Dashboard.SuspendLayout();
            this.tab_TicketManagement.SuspendLayout();
            this.rPnl_TicketManagement.SuspendLayout();
            this.pnl_TicketManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowPnl_TicketManagement_SearchButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.header_TicketManagement.SuspendLayout();
            this.tab_CreateTicket.SuspendLayout();
            this.tblCreateIncident.SuspendLayout();
            this.rPnl_CreateTicket.SuspendLayout();
            this.tblCreateTicket.SuspendLayout();
            this.header_CreateTicket.SuspendLayout();
            this.tab_UserManagement.SuspendLayout();
            this.rPnl_UserManagement.SuspendLayout();
            this.header_UserManagement.SuspendLayout();
            this.tab_CreateUser.SuspendLayout();
            this.rPnl_CreateUser.SuspendLayout();
            this.header_CreateUser.SuspendLayout();
            this.tab_IncidentManagement.SuspendLayout();
            this.pnlIncidentDetails.SuspendLayout();
            this.pnlCreateTicket.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.tblPnl_UserInfo.SuspendLayout();
            this.flowPnl_Navigation.SuspendLayout();
            this.tblPnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.sideBar, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1923, 1054);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Dashboard);
            this.tabControl.Controls.Add(this.tab_TicketManagement);
            this.tabControl.Controls.Add(this.tab_CreateTicket);
            this.tabControl.Controls.Add(this.tab_UserManagement);
            this.tabControl.Controls.Add(this.tab_CreateUser);
            this.tabControl.Controls.Add(this.tab_IncidentManagement);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(467, 19);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0, 19, 19, 19);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1437, 1016);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_IndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabControl_IndexChanged);
            // 
            // tab_Dashboard
            // 
            this.tab_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_Dashboard.Controls.Add(this.rPnl_Dashboard);
            this.tab_Dashboard.Location = new System.Drawing.Point(8, 43);
            this.tab_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Dashboard.Name = "tab_Dashboard";
            this.tab_Dashboard.Size = new System.Drawing.Size(1421, 965);
            this.tab_Dashboard.TabIndex = 0;
            this.tab_Dashboard.Text = "Dashboard";
            // 
            // rPnl_Dashboard
            // 
            this.rPnl_Dashboard.BackColor = System.Drawing.Color.White;
            this.rPnl_Dashboard.BorderAngle = 90F;
            this.rPnl_Dashboard.BorderRadius = 40;
            this.rPnl_Dashboard.Controls.Add(this.tblPnl_Dashboard);
            this.rPnl_Dashboard.Controls.Add(this.pnl_DashBoard_Title);
            this.rPnl_Dashboard.Controls.Add(this.header_Dashboard);
            this.rPnl_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.rPnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.rPnl_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_Dashboard.Name = "rPnl_Dashboard";
            this.rPnl_Dashboard.Size = new System.Drawing.Size(1421, 965);
            this.rPnl_Dashboard.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_Dashboard.TabIndex = 0;
            // 
            // tblPnl_Dashboard
            // 
            this.tblPnl_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblPnl_Dashboard.ColumnCount = 2;
            this.tblPnl_Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_Dashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_Dashboard.Controls.Add(this.rPnl_D1_Open, 0, 0);
            this.tblPnl_Dashboard.Controls.Add(this.rPnl_D3_Unresolved, 0, 1);
            this.tblPnl_Dashboard.Controls.Add(this.rPnl_D2_Past, 1, 0);
            this.tblPnl_Dashboard.Controls.Add(this.rPnl_D4_Resolved, 1, 1);
            this.tblPnl_Dashboard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPnl_Dashboard.Location = new System.Drawing.Point(0, 160);
            this.tblPnl_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tblPnl_Dashboard.Name = "tblPnl_Dashboard";
            this.tblPnl_Dashboard.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.tblPnl_Dashboard.RowCount = 2;
            this.tblPnl_Dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_Dashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_Dashboard.Size = new System.Drawing.Size(1171, 1128);
            this.tblPnl_Dashboard.TabIndex = 2;
            // 
            // rPnl_D1_Open
            // 
            this.rPnl_D1_Open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D1_Open.BackColor = System.Drawing.Color.White;
            this.rPnl_D1_Open.BorderAngle = 90F;
            this.rPnl_D1_Open.BorderRadius = 40;
            this.rPnl_D1_Open.Controls.Add(this.circleBar_Open);
            this.rPnl_D1_Open.Controls.Add(this.lbl_OpenIncidents_Desc);
            this.rPnl_D1_Open.Controls.Add(this.lbl_OpenIncidents_Title);
            this.rPnl_D1_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rPnl_D1_Open.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D1_Open.Location = new System.Drawing.Point(49, 16);
            this.rPnl_D1_Open.MaximumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D1_Open.MinimumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D1_Open.Name = "rPnl_D1_Open";
            this.rPnl_D1_Open.Size = new System.Drawing.Size(531, 531);
            this.rPnl_D1_Open.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D1_Open.TabIndex = 0;
            this.rPnl_D1_Open.Click += new System.EventHandler(this.RPnl_D1_Open_Click);
            // 
            // circleBar_Open
            // 
            this.circleBar_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Open.BorderSize = 25;
            this.circleBar_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circleBar_Open.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.circleBar_Open.FontSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.circleBar_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Open.Location = new System.Drawing.Point(109, 189);
            this.circleBar_Open.Margin = new System.Windows.Forms.Padding(0);
            this.circleBar_Open.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Open.Name = "circleBar_Open";
            this.circleBar_Open.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circleBar_Open.Size = new System.Drawing.Size(320, 320);
            this.circleBar_Open.TabIndex = 3;
            this.circleBar_Open.ValueMax = -1F;
            this.circleBar_Open.ValueSize = -1F;
            this.circleBar_Open.Click += new System.EventHandler(this.RPnl_D1_Open_Click);
            // 
            // lbl_OpenIncidents_Desc
            // 
            this.lbl_OpenIncidents_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_OpenIncidents_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_OpenIncidents_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_OpenIncidents_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_OpenIncidents_Desc.Location = new System.Drawing.Point(0, 93);
            this.lbl_OpenIncidents_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_OpenIncidents_Desc.MaximumSize = new System.Drawing.Size(531, 80);
            this.lbl_OpenIncidents_Desc.MinimumSize = new System.Drawing.Size(531, 80);
            this.lbl_OpenIncidents_Desc.Name = "lbl_OpenIncidents_Desc";
            this.lbl_OpenIncidents_Desc.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbl_OpenIncidents_Desc.Size = new System.Drawing.Size(531, 80);
            this.lbl_OpenIncidents_Desc.TabIndex = 2;
            this.lbl_OpenIncidents_Desc.Text = "These tickets are currently open and require resolving.";
            this.lbl_OpenIncidents_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_OpenIncidents_Desc.Click += new System.EventHandler(this.RPnl_D1_Open_Click);
            // 
            // lbl_OpenIncidents_Title
            // 
            this.lbl_OpenIncidents_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_OpenIncidents_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_OpenIncidents_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenIncidents_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_OpenIncidents_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_OpenIncidents_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_OpenIncidents_Title.MaximumSize = new System.Drawing.Size(531, 93);
            this.lbl_OpenIncidents_Title.MinimumSize = new System.Drawing.Size(531, 93);
            this.lbl_OpenIncidents_Title.Name = "lbl_OpenIncidents_Title";
            this.lbl_OpenIncidents_Title.Size = new System.Drawing.Size(531, 93);
            this.lbl_OpenIncidents_Title.TabIndex = 1;
            this.lbl_OpenIncidents_Title.Text = "Open incidents";
            this.lbl_OpenIncidents_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_OpenIncidents_Title.Click += new System.EventHandler(this.RPnl_D1_Open_Click);
            // 
            // rPnl_D3_Unresolved
            // 
            this.rPnl_D3_Unresolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D3_Unresolved.BackColor = System.Drawing.Color.White;
            this.rPnl_D3_Unresolved.BorderAngle = 90F;
            this.rPnl_D3_Unresolved.BorderRadius = 40;
            this.rPnl_D3_Unresolved.Controls.Add(this.circleBar_Unresolved);
            this.rPnl_D3_Unresolved.Controls.Add(this.lbl_PastDeadline_Desc);
            this.rPnl_D3_Unresolved.Controls.Add(this.lbl_PastDeadline_Title);
            this.rPnl_D3_Unresolved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rPnl_D3_Unresolved.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D3_Unresolved.Location = new System.Drawing.Point(49, 580);
            this.rPnl_D3_Unresolved.MaximumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D3_Unresolved.MinimumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D3_Unresolved.Name = "rPnl_D3_Unresolved";
            this.rPnl_D3_Unresolved.Size = new System.Drawing.Size(531, 531);
            this.rPnl_D3_Unresolved.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D3_Unresolved.TabIndex = 1;
            this.rPnl_D3_Unresolved.Click += new System.EventHandler(this.RPnl_D3_Unresolved_Click);
            // 
            // circleBar_Unresolved
            // 
            this.circleBar_Unresolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Unresolved.BorderSize = 25;
            this.circleBar_Unresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circleBar_Unresolved.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.circleBar_Unresolved.FontSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.circleBar_Unresolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Unresolved.Location = new System.Drawing.Point(109, 189);
            this.circleBar_Unresolved.Margin = new System.Windows.Forms.Padding(0);
            this.circleBar_Unresolved.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Unresolved.Name = "circleBar_Unresolved";
            this.circleBar_Unresolved.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.circleBar_Unresolved.Size = new System.Drawing.Size(320, 320);
            this.circleBar_Unresolved.TabIndex = 5;
            this.circleBar_Unresolved.ValueMax = -1F;
            this.circleBar_Unresolved.ValueSize = -1F;
            this.circleBar_Unresolved.Click += new System.EventHandler(this.RPnl_D3_Unresolved_Click);
            // 
            // lbl_PastDeadline_Desc
            // 
            this.lbl_PastDeadline_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_PastDeadline_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_PastDeadline_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_PastDeadline_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_PastDeadline_Desc.Location = new System.Drawing.Point(0, 93);
            this.lbl_PastDeadline_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PastDeadline_Desc.MaximumSize = new System.Drawing.Size(531, 80);
            this.lbl_PastDeadline_Desc.MinimumSize = new System.Drawing.Size(531, 80);
            this.lbl_PastDeadline_Desc.Name = "lbl_PastDeadline_Desc";
            this.lbl_PastDeadline_Desc.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbl_PastDeadline_Desc.Size = new System.Drawing.Size(531, 80);
            this.lbl_PastDeadline_Desc.TabIndex = 2;
            this.lbl_PastDeadline_Desc.Text = "These tickets were closed without solution.";
            this.lbl_PastDeadline_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_PastDeadline_Desc.Click += new System.EventHandler(this.RPnl_D3_Unresolved_Click);
            // 
            // lbl_PastDeadline_Title
            // 
            this.lbl_PastDeadline_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_PastDeadline_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_PastDeadline_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PastDeadline_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_PastDeadline_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_PastDeadline_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PastDeadline_Title.MaximumSize = new System.Drawing.Size(531, 93);
            this.lbl_PastDeadline_Title.MinimumSize = new System.Drawing.Size(531, 93);
            this.lbl_PastDeadline_Title.Name = "lbl_PastDeadline_Title";
            this.lbl_PastDeadline_Title.Size = new System.Drawing.Size(531, 93);
            this.lbl_PastDeadline_Title.TabIndex = 1;
            this.lbl_PastDeadline_Title.Text = "Incidents closed without resolve";
            this.lbl_PastDeadline_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_PastDeadline_Title.Click += new System.EventHandler(this.RPnl_D3_Unresolved_Click);
            // 
            // rPnl_D2_Past
            // 
            this.rPnl_D2_Past.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D2_Past.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rPnl_D2_Past.BorderAngle = 90F;
            this.rPnl_D2_Past.BorderRadius = 40;
            this.rPnl_D2_Past.Controls.Add(this.circleBar_PastDeadline);
            this.rPnl_D2_Past.Controls.Add(this.lbl_Unresolved_Desc);
            this.rPnl_D2_Past.Controls.Add(this.lbl_Unresolved_Title);
            this.rPnl_D2_Past.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rPnl_D2_Past.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D2_Past.Location = new System.Drawing.Point(620, 16);
            this.rPnl_D2_Past.MaximumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D2_Past.MinimumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D2_Past.Name = "rPnl_D2_Past";
            this.rPnl_D2_Past.Size = new System.Drawing.Size(531, 531);
            this.rPnl_D2_Past.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D2_Past.TabIndex = 2;
            this.rPnl_D2_Past.Click += new System.EventHandler(this.RPnl_D2_Past_Click);
            // 
            // circleBar_PastDeadline
            // 
            this.circleBar_PastDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_PastDeadline.BorderSize = 25;
            this.circleBar_PastDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circleBar_PastDeadline.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.circleBar_PastDeadline.FontSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.circleBar_PastDeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_PastDeadline.Location = new System.Drawing.Point(115, 189);
            this.circleBar_PastDeadline.Margin = new System.Windows.Forms.Padding(0);
            this.circleBar_PastDeadline.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_PastDeadline.Name = "circleBar_PastDeadline";
            this.circleBar_PastDeadline.OuterCircleColor = System.Drawing.Color.Red;
            this.circleBar_PastDeadline.Size = new System.Drawing.Size(320, 320);
            this.circleBar_PastDeadline.TabIndex = 4;
            this.circleBar_PastDeadline.ValueMax = -1F;
            this.circleBar_PastDeadline.ValueSize = -1F;
            this.circleBar_PastDeadline.Click += new System.EventHandler(this.RPnl_D2_Past_Click);
            // 
            // lbl_Unresolved_Desc
            // 
            this.lbl_Unresolved_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Unresolved_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Unresolved_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Unresolved_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_Unresolved_Desc.Location = new System.Drawing.Point(0, 93);
            this.lbl_Unresolved_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Unresolved_Desc.MaximumSize = new System.Drawing.Size(531, 80);
            this.lbl_Unresolved_Desc.MinimumSize = new System.Drawing.Size(531, 80);
            this.lbl_Unresolved_Desc.Name = "lbl_Unresolved_Desc";
            this.lbl_Unresolved_Desc.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbl_Unresolved_Desc.Size = new System.Drawing.Size(531, 80);
            this.lbl_Unresolved_Desc.TabIndex = 2;
            this.lbl_Unresolved_Desc.Text = "These tickets require your immediate attention.";
            this.lbl_Unresolved_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Unresolved_Desc.Click += new System.EventHandler(this.RPnl_D2_Past_Click);
            // 
            // lbl_Unresolved_Title
            // 
            this.lbl_Unresolved_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Unresolved_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Unresolved_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unresolved_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_Unresolved_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Unresolved_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Unresolved_Title.MaximumSize = new System.Drawing.Size(531, 93);
            this.lbl_Unresolved_Title.MinimumSize = new System.Drawing.Size(531, 93);
            this.lbl_Unresolved_Title.Name = "lbl_Unresolved_Title";
            this.lbl_Unresolved_Title.Size = new System.Drawing.Size(531, 93);
            this.lbl_Unresolved_Title.TabIndex = 1;
            this.lbl_Unresolved_Title.Text = "Incidents past deadline";
            this.lbl_Unresolved_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Unresolved_Title.Click += new System.EventHandler(this.RPnl_D2_Past_Click);
            // 
            // rPnl_D4_Resolved
            // 
            this.rPnl_D4_Resolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D4_Resolved.BackColor = System.Drawing.Color.White;
            this.rPnl_D4_Resolved.BorderAngle = 90F;
            this.rPnl_D4_Resolved.BorderRadius = 40;
            this.rPnl_D4_Resolved.Controls.Add(this.circleBar_Resolved);
            this.rPnl_D4_Resolved.Controls.Add(this.lbl_Resolved_Desc);
            this.rPnl_D4_Resolved.Controls.Add(this.lbl_Resolved_Title);
            this.rPnl_D4_Resolved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rPnl_D4_Resolved.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D4_Resolved.Location = new System.Drawing.Point(620, 580);
            this.rPnl_D4_Resolved.MaximumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D4_Resolved.MinimumSize = new System.Drawing.Size(531, 531);
            this.rPnl_D4_Resolved.Name = "rPnl_D4_Resolved";
            this.rPnl_D4_Resolved.Size = new System.Drawing.Size(531, 531);
            this.rPnl_D4_Resolved.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D4_Resolved.TabIndex = 3;
            this.rPnl_D4_Resolved.Click += new System.EventHandler(this.RPnl_D4_Resolved_Click);
            // 
            // circleBar_Resolved
            // 
            this.circleBar_Resolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Resolved.BorderSize = 25;
            this.circleBar_Resolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circleBar_Resolved.FontColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.circleBar_Resolved.FontSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.circleBar_Resolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Resolved.Location = new System.Drawing.Point(109, 189);
            this.circleBar_Resolved.Margin = new System.Windows.Forms.Padding(0);
            this.circleBar_Resolved.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circleBar_Resolved.Name = "circleBar_Resolved";
            this.circleBar_Resolved.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.circleBar_Resolved.Size = new System.Drawing.Size(320, 320);
            this.circleBar_Resolved.TabIndex = 6;
            this.circleBar_Resolved.ValueMax = -1F;
            this.circleBar_Resolved.ValueSize = -1F;
            this.circleBar_Resolved.Click += new System.EventHandler(this.RPnl_D4_Resolved_Click);
            // 
            // lbl_Resolved_Desc
            // 
            this.lbl_Resolved_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Resolved_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Resolved_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Resolved_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_Resolved_Desc.Location = new System.Drawing.Point(0, 93);
            this.lbl_Resolved_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Resolved_Desc.MaximumSize = new System.Drawing.Size(531, 80);
            this.lbl_Resolved_Desc.MinimumSize = new System.Drawing.Size(531, 80);
            this.lbl_Resolved_Desc.Name = "lbl_Resolved_Desc";
            this.lbl_Resolved_Desc.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbl_Resolved_Desc.Size = new System.Drawing.Size(531, 80);
            this.lbl_Resolved_Desc.TabIndex = 2;
            this.lbl_Resolved_Desc.Text = "Good job! These tickets were succesfully resolved.";
            this.lbl_Resolved_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Resolved_Desc.Click += new System.EventHandler(this.RPnl_D4_Resolved_Click);
            // 
            // lbl_Resolved_Title
            // 
            this.lbl_Resolved_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Resolved_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Resolved_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resolved_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_Resolved_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Resolved_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Resolved_Title.MaximumSize = new System.Drawing.Size(531, 93);
            this.lbl_Resolved_Title.MinimumSize = new System.Drawing.Size(531, 93);
            this.lbl_Resolved_Title.Name = "lbl_Resolved_Title";
            this.lbl_Resolved_Title.Size = new System.Drawing.Size(531, 93);
            this.lbl_Resolved_Title.TabIndex = 1;
            this.lbl_Resolved_Title.Text = "Resolved incidents";
            this.lbl_Resolved_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Resolved_Title.Click += new System.EventHandler(this.RPnl_D4_Resolved_Click);
            // 
            // pnl_DashBoard_Title
            // 
            this.pnl_DashBoard_Title.Controls.Add(this.btn_ShowAllIncidents);
            this.pnl_DashBoard_Title.Controls.Add(this.lbl_CurrentIncidents);
            this.pnl_DashBoard_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DashBoard_Title.Location = new System.Drawing.Point(0, 80);
            this.pnl_DashBoard_Title.Name = "pnl_DashBoard_Title";
            this.pnl_DashBoard_Title.Size = new System.Drawing.Size(1421, 80);
            this.pnl_DashBoard_Title.TabIndex = 3;
            // 
            // btn_ShowAllIncidents
            // 
            this.btn_ShowAllIncidents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_ShowAllIncidents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowAllIncidents.FlatAppearance.BorderSize = 0;
            this.btn_ShowAllIncidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAllIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAllIncidents.ForeColor = System.Drawing.Color.White;
            this.btn_ShowAllIncidents.Location = new System.Drawing.Point(829, 0);
            this.btn_ShowAllIncidents.Name = "btn_ShowAllIncidents";
            this.btn_ShowAllIncidents.Size = new System.Drawing.Size(328, 77);
            this.btn_ShowAllIncidents.TabIndex = 1;
            this.btn_ShowAllIncidents.Text = "Show all incidents";
            this.btn_ShowAllIncidents.UseVisualStyleBackColor = false;
            this.btn_ShowAllIncidents.Click += new System.EventHandler(this.Btn_ShowAllIncidents_Click);
            // 
            // lbl_CurrentIncidents
            // 
            this.lbl_CurrentIncidents.AutoSize = true;
            this.lbl_CurrentIncidents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_CurrentIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentIncidents.Location = new System.Drawing.Point(0, 29);
            this.lbl_CurrentIncidents.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.lbl_CurrentIncidents.Name = "lbl_CurrentIncidents";
            this.lbl_CurrentIncidents.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbl_CurrentIncidents.Size = new System.Drawing.Size(405, 51);
            this.lbl_CurrentIncidents.TabIndex = 0;
            this.lbl_CurrentIncidents.Text = "Current incidents";
            this.lbl_CurrentIncidents.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // header_Dashboard
            // 
            this.header_Dashboard.Controls.Add(this.lbl_HeaderDashboard);
            this.header_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.header_Dashboard.Name = "header_Dashboard";
            this.header_Dashboard.Size = new System.Drawing.Size(1421, 80);
            this.header_Dashboard.TabIndex = 0;
            // 
            // lbl_HeaderDashboard
            // 
            this.lbl_HeaderDashboard.AutoSize = true;
            this.lbl_HeaderDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderDashboard.Location = new System.Drawing.Point(0, 29);
            this.lbl_HeaderDashboard.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.lbl_HeaderDashboard.Name = "lbl_HeaderDashboard";
            this.lbl_HeaderDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbl_HeaderDashboard.Size = new System.Drawing.Size(282, 51);
            this.lbl_HeaderDashboard.TabIndex = 0;
            this.lbl_HeaderDashboard.Text = "Dashboard";
            this.lbl_HeaderDashboard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_TicketManagement
            // 
            this.tab_TicketManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_TicketManagement.Controls.Add(this.rPnl_TicketManagement);
            this.tab_TicketManagement.Location = new System.Drawing.Point(8, 78);
            this.tab_TicketManagement.Margin = new System.Windows.Forms.Padding(0);
            this.tab_TicketManagement.Name = "tab_TicketManagement";
            this.tab_TicketManagement.Size = new System.Drawing.Size(1421, 930);
            this.tab_TicketManagement.TabIndex = 2;
            this.tab_TicketManagement.Text = "Ticket Management";
            // 
            // rPnl_TicketManagement
            // 
            this.rPnl_TicketManagement.BackColor = System.Drawing.Color.White;
            this.rPnl_TicketManagement.BorderAngle = 90F;
            this.rPnl_TicketManagement.BorderRadius = 40;
            this.rPnl_TicketManagement.Controls.Add(this.pnl_TicketManagement);
            this.rPnl_TicketManagement.Controls.Add(this.header_TicketManagement);
            this.rPnl_TicketManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_TicketManagement.ForeColor = System.Drawing.Color.Black;
            this.rPnl_TicketManagement.Location = new System.Drawing.Point(0, 0);
            this.rPnl_TicketManagement.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_TicketManagement.Name = "rPnl_TicketManagement";
            this.rPnl_TicketManagement.Size = new System.Drawing.Size(1421, 930);
            this.rPnl_TicketManagement.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_TicketManagement.TabIndex = 1;
            // 
            // pnl_TicketManagement
            // 
            this.pnl_TicketManagement.BackColor = System.Drawing.Color.White;
            this.pnl_TicketManagement.BorderAngle = 90F;
            this.pnl_TicketManagement.BorderRadius = 40;
            this.pnl_TicketManagement.Controls.Add(this.splitContainer1);
            this.pnl_TicketManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TicketManagement.ForeColor = System.Drawing.Color.Black;
            this.pnl_TicketManagement.Location = new System.Drawing.Point(0, 80);
            this.pnl_TicketManagement.Name = "pnl_TicketManagement";
            this.pnl_TicketManagement.Size = new System.Drawing.Size(1421, 850);
            this.pnl_TicketManagement.SurfaceColor = System.Drawing.Color.Empty;
            this.pnl_TicketManagement.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTransfer);
            this.splitContainer1.Panel1.Controls.Add(this.cmbEmployees);
            this.splitContainer1.Panel1.Controls.Add(this.listView_TicketManagement);
            this.splitContainer1.Panel1.Controls.Add(this.txtBox_SearchBar);
            this.splitContainer1.Panel1.Controls.Add(this.flowPnl_TicketManagement_SearchButtons);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDetailsDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsDescription);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDetailsDeadline);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsDeadlineDays);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsWarning);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDetailsStatus);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsStatus);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDetailsPriority);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsPriority);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDetailsReporter);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsUser);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDetailsIncidentType);
            this.splitContainer1.Panel2.Controls.Add(this.lblDetailsIncidentType);
            this.splitContainer1.Panel2.Controls.Add(this.txtDetailsSubject);
            this.splitContainer1.Panel2.Controls.Add(this.lblTicketDetailsSubjectOfIncident);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1421, 850);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 15;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(712, 1000);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(205, 51);
            this.btnTransfer.TabIndex = 36;
            this.btnTransfer.Text = "Transfer Ticket";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(30, 1000);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(1, 45);
            this.cmbEmployees.TabIndex = 35;
            // 
            // listView_TicketManagement
            // 
            this.listView_TicketManagement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Id,
            this.col_Subject,
            this.col_User,
            this.col_Date,
            this.col_Status,
            this.col_IsClosed});
            this.listView_TicketManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_TicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listView_TicketManagement.FullRowSelect = true;
            this.listView_TicketManagement.HideSelection = false;
            this.listView_TicketManagement.Location = new System.Drawing.Point(0, 132);
            this.listView_TicketManagement.MultiSelect = false;
            this.listView_TicketManagement.Name = "listView_TicketManagement";
            this.listView_TicketManagement.Size = new System.Drawing.Size(498, 716);
            this.listView_TicketManagement.TabIndex = 13;
            this.listView_TicketManagement.UseCompatibleStateImageBehavior = false;
            this.listView_TicketManagement.View = System.Windows.Forms.View.Details;
            this.listView_TicketManagement.SelectedIndexChanged += new System.EventHandler(this.listView_TicketManagement_SelectedIndexChanged);
            // 
            // col_Id
            // 
            this.col_Id.Text = "Id";
            // 
            // col_Subject
            // 
            this.col_Subject.Text = "Subject";
            this.col_Subject.Width = 200;
            // 
            // col_User
            // 
            this.col_User.Text = "User";
            this.col_User.Width = 120;
            // 
            // col_Date
            // 
            this.col_Date.Text = "Date";
            this.col_Date.Width = 180;
            // 
            // col_Status
            // 
            this.col_Status.Text = "Status";
            this.col_Status.Width = 180;
            // 
            // col_IsClosed
            // 
            this.col_IsClosed.Text = "Closed";
            // 
            // txtBox_SearchBar
            // 
            this.txtBox_SearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBox_SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBox_SearchBar.Location = new System.Drawing.Point(0, 88);
            this.txtBox_SearchBar.Name = "txtBox_SearchBar";
            this.txtBox_SearchBar.PromptText = "Search...";
            this.txtBox_SearchBar.Size = new System.Drawing.Size(498, 44);
            this.txtBox_SearchBar.TabIndex = 11;
            this.txtBox_SearchBar.TextChanged += new System.EventHandler(this.txtBox_SearchBar_TextChanged);
            // 
            // flowPnl_TicketManagement_SearchButtons
            // 
            this.flowPnl_TicketManagement_SearchButtons.Controls.Add(this.btn_Display_Tickets_All);
            this.flowPnl_TicketManagement_SearchButtons.Controls.Add(this.btn_Display_Tickets_Open);
            this.flowPnl_TicketManagement_SearchButtons.Controls.Add(this.btn_Display_Tickets_PastDeadline);
            this.flowPnl_TicketManagement_SearchButtons.Controls.Add(this.btn_Display_Tickets_Unresolved);
            this.flowPnl_TicketManagement_SearchButtons.Controls.Add(this.btn_Display_Tickets_Resolved);
            this.flowPnl_TicketManagement_SearchButtons.Controls.Add(this.btn_Display_Tickets_Closed);
            this.flowPnl_TicketManagement_SearchButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPnl_TicketManagement_SearchButtons.Location = new System.Drawing.Point(0, 0);
            this.flowPnl_TicketManagement_SearchButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flowPnl_TicketManagement_SearchButtons.Name = "flowPnl_TicketManagement_SearchButtons";
            this.flowPnl_TicketManagement_SearchButtons.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.flowPnl_TicketManagement_SearchButtons.Size = new System.Drawing.Size(498, 88);
            this.flowPnl_TicketManagement_SearchButtons.TabIndex = 14;
            // 
            // btn_Display_Tickets_All
            // 
            this.btn_Display_Tickets_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_Display_Tickets_All.FlatAppearance.BorderSize = 0;
            this.btn_Display_Tickets_All.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_Display_Tickets_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display_Tickets_All.ForeColor = System.Drawing.Color.White;
            this.btn_Display_Tickets_All.Location = new System.Drawing.Point(3, 16);
            this.btn_Display_Tickets_All.Name = "btn_Display_Tickets_All";
            this.btn_Display_Tickets_All.Size = new System.Drawing.Size(179, 51);
            this.btn_Display_Tickets_All.TabIndex = 12;
            this.btn_Display_Tickets_All.Text = "All";
            this.btn_Display_Tickets_All.UseVisualStyleBackColor = false;
            this.btn_Display_Tickets_All.Click += new System.EventHandler(this.Btn_Display_Tickets_All_Click);
            // 
            // btn_Display_Tickets_Open
            // 
            this.btn_Display_Tickets_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_Display_Tickets_Open.FlatAppearance.BorderSize = 0;
            this.btn_Display_Tickets_Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_Display_Tickets_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display_Tickets_Open.ForeColor = System.Drawing.Color.White;
            this.btn_Display_Tickets_Open.Location = new System.Drawing.Point(188, 16);
            this.btn_Display_Tickets_Open.Name = "btn_Display_Tickets_Open";
            this.btn_Display_Tickets_Open.Size = new System.Drawing.Size(179, 51);
            this.btn_Display_Tickets_Open.TabIndex = 10;
            this.btn_Display_Tickets_Open.Text = "Open";
            this.btn_Display_Tickets_Open.UseVisualStyleBackColor = false;
            this.btn_Display_Tickets_Open.Click += new System.EventHandler(this.Btn_Display_Tickets_Open_Click);
            // 
            // btn_Display_Tickets_PastDeadline
            // 
            this.btn_Display_Tickets_PastDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_Display_Tickets_PastDeadline.FlatAppearance.BorderSize = 0;
            this.btn_Display_Tickets_PastDeadline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_Display_Tickets_PastDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display_Tickets_PastDeadline.ForeColor = System.Drawing.Color.White;
            this.btn_Display_Tickets_PastDeadline.Location = new System.Drawing.Point(3, 73);
            this.btn_Display_Tickets_PastDeadline.Name = "btn_Display_Tickets_PastDeadline";
            this.btn_Display_Tickets_PastDeadline.Size = new System.Drawing.Size(179, 51);
            this.btn_Display_Tickets_PastDeadline.TabIndex = 9;
            this.btn_Display_Tickets_PastDeadline.Text = "Past Deadline";
            this.btn_Display_Tickets_PastDeadline.UseVisualStyleBackColor = false;
            this.btn_Display_Tickets_PastDeadline.Click += new System.EventHandler(this.Btn_Display_Tickets_PastDeadline_Click);
            // 
            // btn_Display_Tickets_Unresolved
            // 
            this.btn_Display_Tickets_Unresolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_Display_Tickets_Unresolved.FlatAppearance.BorderSize = 0;
            this.btn_Display_Tickets_Unresolved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_Display_Tickets_Unresolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display_Tickets_Unresolved.ForeColor = System.Drawing.Color.White;
            this.btn_Display_Tickets_Unresolved.Location = new System.Drawing.Point(188, 73);
            this.btn_Display_Tickets_Unresolved.Name = "btn_Display_Tickets_Unresolved";
            this.btn_Display_Tickets_Unresolved.Size = new System.Drawing.Size(179, 51);
            this.btn_Display_Tickets_Unresolved.TabIndex = 8;
            this.btn_Display_Tickets_Unresolved.Text = "Unresolved";
            this.btn_Display_Tickets_Unresolved.UseVisualStyleBackColor = false;
            this.btn_Display_Tickets_Unresolved.Click += new System.EventHandler(this.Btn_Display_Tickets_Unresolved_Click);
            // 
            // btn_Display_Tickets_Resolved
            // 
            this.btn_Display_Tickets_Resolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_Display_Tickets_Resolved.FlatAppearance.BorderSize = 0;
            this.btn_Display_Tickets_Resolved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_Display_Tickets_Resolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display_Tickets_Resolved.ForeColor = System.Drawing.Color.White;
            this.btn_Display_Tickets_Resolved.Location = new System.Drawing.Point(3, 130);
            this.btn_Display_Tickets_Resolved.Name = "btn_Display_Tickets_Resolved";
            this.btn_Display_Tickets_Resolved.Size = new System.Drawing.Size(179, 51);
            this.btn_Display_Tickets_Resolved.TabIndex = 7;
            this.btn_Display_Tickets_Resolved.Text = "Resolved";
            this.btn_Display_Tickets_Resolved.UseVisualStyleBackColor = false;
            this.btn_Display_Tickets_Resolved.Click += new System.EventHandler(this.btn_Display_Tickets_Resolved_Click);
            // 
            // btn_Display_Tickets_Closed
            // 
            this.btn_Display_Tickets_Closed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_Display_Tickets_Closed.FlatAppearance.BorderSize = 0;
            this.btn_Display_Tickets_Closed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_Display_Tickets_Closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Display_Tickets_Closed.ForeColor = System.Drawing.Color.White;
            this.btn_Display_Tickets_Closed.Location = new System.Drawing.Point(188, 130);
            this.btn_Display_Tickets_Closed.Name = "btn_Display_Tickets_Closed";
            this.btn_Display_Tickets_Closed.Size = new System.Drawing.Size(179, 51);
            this.btn_Display_Tickets_Closed.TabIndex = 13;
            this.btn_Display_Tickets_Closed.Text = "Closed";
            this.btn_Display_Tickets_Closed.UseVisualStyleBackColor = false;
            this.btn_Display_Tickets_Closed.Click += new System.EventHandler(this.btn_Display_Tickets_Closed_Click);
            // 
            // txtDetailsDescription
            // 
            this.txtDetailsDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetailsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDetailsDescription.Location = new System.Drawing.Point(0, 619);
            this.txtDetailsDescription.Multiline = true;
            this.txtDetailsDescription.Name = "txtDetailsDescription";
            this.txtDetailsDescription.Size = new System.Drawing.Size(911, 0);
            this.txtDetailsDescription.TabIndex = 22;
            // 
            // lblDetailsDescription
            // 
            this.lblDetailsDescription.AutoSize = true;
            this.lblDetailsDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetailsDescription.Location = new System.Drawing.Point(0, 569);
            this.lblDetailsDescription.Name = "lblDetailsDescription";
            this.lblDetailsDescription.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblDetailsDescription.Size = new System.Drawing.Size(177, 50);
            this.lblDetailsDescription.TabIndex = 20;
            this.lblDetailsDescription.Text = "Description";
            // 
            // cmbDetailsDeadline
            // 
            this.cmbDetailsDeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDetailsDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailsDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDetailsDeadline.FormattingEnabled = true;
            this.cmbDetailsDeadline.Location = new System.Drawing.Point(0, 524);
            this.cmbDetailsDeadline.Name = "cmbDetailsDeadline";
            this.cmbDetailsDeadline.Size = new System.Drawing.Size(911, 45);
            this.cmbDetailsDeadline.TabIndex = 28;
            // 
            // lblDetailsDeadlineDays
            // 
            this.lblDetailsDeadlineDays.AutoSize = true;
            this.lblDetailsDeadlineDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsDeadlineDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetailsDeadlineDays.Location = new System.Drawing.Point(0, 474);
            this.lblDetailsDeadlineDays.Name = "lblDetailsDeadlineDays";
            this.lblDetailsDeadlineDays.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblDetailsDeadlineDays.Size = new System.Drawing.Size(278, 50);
            this.lblDetailsDeadlineDays.TabIndex = 29;
            this.lblDetailsDeadlineDays.Text = "Deadline/follow up";
            // 
            // lblDetailsWarning
            // 
            this.lblDetailsWarning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDetailsWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetailsWarning.ForeColor = System.Drawing.Color.Red;
            this.lblDetailsWarning.Location = new System.Drawing.Point(0, 571);
            this.lblDetailsWarning.Name = "lblDetailsWarning";
            this.lblDetailsWarning.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblDetailsWarning.Size = new System.Drawing.Size(911, 120);
            this.lblDetailsWarning.TabIndex = 27;
            this.lblDetailsWarning.Text = "Line1\r\nLine2\r\nLine3";
            this.lblDetailsWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDetailsStatus
            // 
            this.cmbDetailsStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDetailsStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDetailsStatus.FormattingEnabled = true;
            this.cmbDetailsStatus.Location = new System.Drawing.Point(0, 429);
            this.cmbDetailsStatus.Name = "cmbDetailsStatus";
            this.cmbDetailsStatus.Size = new System.Drawing.Size(911, 45);
            this.cmbDetailsStatus.TabIndex = 21;
            // 
            // lblDetailsStatus
            // 
            this.lblDetailsStatus.AutoSize = true;
            this.lblDetailsStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetailsStatus.Location = new System.Drawing.Point(0, 379);
            this.lblDetailsStatus.Name = "lblDetailsStatus";
            this.lblDetailsStatus.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblDetailsStatus.Size = new System.Drawing.Size(108, 50);
            this.lblDetailsStatus.TabIndex = 24;
            this.lblDetailsStatus.Text = "Status";
            // 
            // cmbDetailsPriority
            // 
            this.cmbDetailsPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDetailsPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailsPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDetailsPriority.FormattingEnabled = true;
            this.cmbDetailsPriority.Location = new System.Drawing.Point(0, 334);
            this.cmbDetailsPriority.Name = "cmbDetailsPriority";
            this.cmbDetailsPriority.Size = new System.Drawing.Size(911, 45);
            this.cmbDetailsPriority.TabIndex = 19;
            // 
            // lblDetailsPriority
            // 
            this.lblDetailsPriority.AutoSize = true;
            this.lblDetailsPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetailsPriority.Location = new System.Drawing.Point(0, 284);
            this.lblDetailsPriority.Name = "lblDetailsPriority";
            this.lblDetailsPriority.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblDetailsPriority.Size = new System.Drawing.Size(116, 50);
            this.lblDetailsPriority.TabIndex = 18;
            this.lblDetailsPriority.Text = "Priority";
            // 
            // cmbDetailsReporter
            // 
            this.cmbDetailsReporter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDetailsReporter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailsReporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDetailsReporter.FormattingEnabled = true;
            this.cmbDetailsReporter.Location = new System.Drawing.Point(0, 239);
            this.cmbDetailsReporter.Name = "cmbDetailsReporter";
            this.cmbDetailsReporter.Size = new System.Drawing.Size(911, 45);
            this.cmbDetailsReporter.TabIndex = 17;
            // 
            // lblDetailsUser
            // 
            this.lblDetailsUser.AutoSize = true;
            this.lblDetailsUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetailsUser.Location = new System.Drawing.Point(0, 189);
            this.lblDetailsUser.Name = "lblDetailsUser";
            this.lblDetailsUser.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblDetailsUser.Size = new System.Drawing.Size(260, 50);
            this.lblDetailsUser.TabIndex = 16;
            this.lblDetailsUser.Text = "Reported by user";
            // 
            // cmbDetailsIncidentType
            // 
            this.cmbDetailsIncidentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDetailsIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailsIncidentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDetailsIncidentType.FormattingEnabled = true;
            this.cmbDetailsIncidentType.Location = new System.Drawing.Point(0, 144);
            this.cmbDetailsIncidentType.Name = "cmbDetailsIncidentType";
            this.cmbDetailsIncidentType.Size = new System.Drawing.Size(911, 45);
            this.cmbDetailsIncidentType.TabIndex = 15;
            // 
            // lblDetailsIncidentType
            // 
            this.lblDetailsIncidentType.AutoSize = true;
            this.lblDetailsIncidentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailsIncidentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetailsIncidentType.Location = new System.Drawing.Point(0, 94);
            this.lblDetailsIncidentType.Name = "lblDetailsIncidentType";
            this.lblDetailsIncidentType.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblDetailsIncidentType.Size = new System.Drawing.Size(242, 50);
            this.lblDetailsIncidentType.TabIndex = 13;
            this.lblDetailsIncidentType.Text = "Type of incident";
            // 
            // txtDetailsSubject
            // 
            this.txtDetailsSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDetailsSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDetailsSubject.Location = new System.Drawing.Point(0, 50);
            this.txtDetailsSubject.Name = "txtDetailsSubject";
            this.txtDetailsSubject.Size = new System.Drawing.Size(911, 44);
            this.txtDetailsSubject.TabIndex = 12;
            // 
            // lblTicketDetailsSubjectOfIncident
            // 
            this.lblTicketDetailsSubjectOfIncident.AutoSize = true;
            this.lblTicketDetailsSubjectOfIncident.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicketDetailsSubjectOfIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTicketDetailsSubjectOfIncident.Location = new System.Drawing.Point(0, 0);
            this.lblTicketDetailsSubjectOfIncident.Name = "lblTicketDetailsSubjectOfIncident";
            this.lblTicketDetailsSubjectOfIncident.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.lblTicketDetailsSubjectOfIncident.Size = new System.Drawing.Size(278, 50);
            this.lblTicketDetailsSubjectOfIncident.TabIndex = 11;
            this.lblTicketDetailsSubjectOfIncident.Text = "Subject of incident";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDetailsEscalate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDetailsUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetailsClose, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDetailsDelete, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 691);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 157);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // btnDetailsEscalate
            // 
            this.btnDetailsEscalate.BackColor = System.Drawing.Color.White;
            this.btnDetailsEscalate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetailsEscalate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnDetailsEscalate.FlatAppearance.BorderSize = 6;
            this.btnDetailsEscalate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsEscalate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetailsEscalate.ForeColor = System.Drawing.Color.Black;
            this.btnDetailsEscalate.Location = new System.Drawing.Point(3, 81);
            this.btnDetailsEscalate.Name = "btnDetailsEscalate";
            this.btnDetailsEscalate.Size = new System.Drawing.Size(449, 73);
            this.btnDetailsEscalate.TabIndex = 24;
            this.btnDetailsEscalate.Text = "Escalate";
            this.btnDetailsEscalate.UseVisualStyleBackColor = false;
            this.btnDetailsEscalate.Click += new System.EventHandler(this.btnDetailsEscalate_Click);
            // 
            // btnDetailsUpdate
            // 
            this.btnDetailsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btnDetailsUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetailsUpdate.FlatAppearance.BorderSize = 0;
            this.btnDetailsUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnDetailsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetailsUpdate.ForeColor = System.Drawing.Color.White;
            this.btnDetailsUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnDetailsUpdate.Name = "btnDetailsUpdate";
            this.btnDetailsUpdate.Size = new System.Drawing.Size(449, 72);
            this.btnDetailsUpdate.TabIndex = 23;
            this.btnDetailsUpdate.Text = "Update";
            this.btnDetailsUpdate.UseVisualStyleBackColor = false;
            this.btnDetailsUpdate.Click += new System.EventHandler(this.btnDetailsUpdate_Click);
            // 
            // btnDetailsClose
            // 
            this.btnDetailsClose.BackColor = System.Drawing.Color.Coral;
            this.btnDetailsClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetailsClose.FlatAppearance.BorderSize = 0;
            this.btnDetailsClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(116)))));
            this.btnDetailsClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetailsClose.ForeColor = System.Drawing.Color.White;
            this.btnDetailsClose.Location = new System.Drawing.Point(458, 3);
            this.btnDetailsClose.Name = "btnDetailsClose";
            this.btnDetailsClose.Size = new System.Drawing.Size(450, 72);
            this.btnDetailsClose.TabIndex = 26;
            this.btnDetailsClose.Text = "Close";
            this.btnDetailsClose.UseVisualStyleBackColor = false;
            this.btnDetailsClose.Click += new System.EventHandler(this.btnDetailsClose_Click);
            // 
            // btnDetailsDelete
            // 
            this.btnDetailsDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDetailsDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetailsDelete.FlatAppearance.BorderSize = 0;
            this.btnDetailsDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDetailsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetailsDelete.ForeColor = System.Drawing.Color.White;
            this.btnDetailsDelete.Location = new System.Drawing.Point(458, 81);
            this.btnDetailsDelete.Name = "btnDetailsDelete";
            this.btnDetailsDelete.Size = new System.Drawing.Size(450, 73);
            this.btnDetailsDelete.TabIndex = 25;
            this.btnDetailsDelete.Text = "Delete";
            this.btnDetailsDelete.UseVisualStyleBackColor = false;
            this.btnDetailsDelete.Click += new System.EventHandler(this.btnDetailsDelete_Click);
            // 
            // header_TicketManagement
            // 
            this.header_TicketManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.header_TicketManagement.Controls.Add(this.lbl_HeaderTicketManagement);
            this.header_TicketManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_TicketManagement.Location = new System.Drawing.Point(0, 0);
            this.header_TicketManagement.Margin = new System.Windows.Forms.Padding(0);
            this.header_TicketManagement.Name = "header_TicketManagement";
            this.header_TicketManagement.Size = new System.Drawing.Size(1421, 80);
            this.header_TicketManagement.TabIndex = 1;
            // 
            // lbl_HeaderTicketManagement
            // 
            this.lbl_HeaderTicketManagement.AutoSize = true;
            this.lbl_HeaderTicketManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderTicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderTicketManagement.Location = new System.Drawing.Point(0, 29);
            this.lbl_HeaderTicketManagement.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.lbl_HeaderTicketManagement.Name = "lbl_HeaderTicketManagement";
            this.lbl_HeaderTicketManagement.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbl_HeaderTicketManagement.Size = new System.Drawing.Size(458, 51);
            this.lbl_HeaderTicketManagement.TabIndex = 0;
            this.lbl_HeaderTicketManagement.Text = "Ticket Management";
            this.lbl_HeaderTicketManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_CreateTicket
            // 
            this.tab_CreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_CreateTicket.Controls.Add(this.tblCreateIncident);
            this.tab_CreateTicket.Controls.Add(this.rPnl_CreateTicket);
            this.tab_CreateTicket.Location = new System.Drawing.Point(8, 78);
            this.tab_CreateTicket.Name = "tab_CreateTicket";
            this.tab_CreateTicket.Size = new System.Drawing.Size(1421, 930);
            this.tab_CreateTicket.TabIndex = 1;
            this.tab_CreateTicket.Text = "Create Ticket";
            // 
            // tblCreateIncident
            // 
            this.tblCreateIncident.BackColor = System.Drawing.Color.White;
            this.tblCreateIncident.ColumnCount = 2;
            this.tblCreateIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.43472F));
            this.tblCreateIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.56528F));
            this.tblCreateIncident.Controls.Add(this.lblIncidentSubject, 0, 0);
            this.tblCreateIncident.Controls.Add(this.lblIncidentType, 0, 1);
            this.tblCreateIncident.Controls.Add(this.lblIncidentDescription, 0, 2);
            this.tblCreateIncident.Controls.Add(this.txtIncidentSubject, 1, 0);
            this.tblCreateIncident.Controls.Add(this.cmbIncidentType, 1, 1);
            this.tblCreateIncident.Controls.Add(this.txtIncidentDescription, 1, 2);
            this.tblCreateIncident.Location = new System.Drawing.Point(10, 77);
            this.tblCreateIncident.Name = "tblCreateIncident";
            this.tblCreateIncident.RowCount = 3;
            this.tblCreateIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tblCreateIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tblCreateIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 454F));
            this.tblCreateIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblCreateIncident.Size = new System.Drawing.Size(1024, 634);
            this.tblCreateIncident.TabIndex = 3;
            // 
            // lblIncidentSubject
            // 
            this.lblIncidentSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncidentSubject.AutoSize = true;
            this.lblIncidentSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentSubject.Location = new System.Drawing.Point(3, 2);
            this.lblIncidentSubject.MinimumSize = new System.Drawing.Size(371, 80);
            this.lblIncidentSubject.Name = "lblIncidentSubject";
            this.lblIncidentSubject.Size = new System.Drawing.Size(371, 80);
            this.lblIncidentSubject.TabIndex = 0;
            this.lblIncidentSubject.Text = "Incident subject";
            this.lblIncidentSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncidentType
            // 
            this.lblIncidentType.AutoSize = true;
            this.lblIncidentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentType.Location = new System.Drawing.Point(3, 84);
            this.lblIncidentType.MinimumSize = new System.Drawing.Size(371, 80);
            this.lblIncidentType.Name = "lblIncidentType";
            this.lblIncidentType.Size = new System.Drawing.Size(371, 80);
            this.lblIncidentType.TabIndex = 2;
            this.lblIncidentType.Text = "Incident type";
            // 
            // lblIncidentDescription
            // 
            this.lblIncidentDescription.AutoSize = true;
            this.lblIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDescription.Location = new System.Drawing.Point(3, 179);
            this.lblIncidentDescription.MinimumSize = new System.Drawing.Size(371, 80);
            this.lblIncidentDescription.Name = "lblIncidentDescription";
            this.lblIncidentDescription.Size = new System.Drawing.Size(371, 80);
            this.lblIncidentDescription.TabIndex = 1;
            this.lblIncidentDescription.Text = "Incident description";
            // 
            // txtIncidentSubject
            // 
            this.txtIncidentSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIncidentSubject.Location = new System.Drawing.Point(406, 19);
            this.txtIncidentSubject.MinimumSize = new System.Drawing.Size(602, 46);
            this.txtIncidentSubject.Multiline = true;
            this.txtIncidentSubject.Name = "txtIncidentSubject";
            this.txtIncidentSubject.Size = new System.Drawing.Size(602, 46);
            this.txtIncidentSubject.TabIndex = 3;
            // 
            // cmbIncidentType
            // 
            this.cmbIncidentType.FormattingEnabled = true;
            this.cmbIncidentType.ItemHeight = 25;
            this.cmbIncidentType.Location = new System.Drawing.Point(406, 87);
            this.cmbIncidentType.MinimumSize = new System.Drawing.Size(602, 0);
            this.cmbIncidentType.Name = "cmbIncidentType";
            this.cmbIncidentType.Size = new System.Drawing.Size(602, 33);
            this.cmbIncidentType.TabIndex = 4;
            // 
            // txtIncidentDescription
            // 
            this.txtIncidentDescription.Location = new System.Drawing.Point(406, 182);
            this.txtIncidentDescription.MinimumSize = new System.Drawing.Size(602, 46);
            this.txtIncidentDescription.Multiline = true;
            this.txtIncidentDescription.Name = "txtIncidentDescription";
            this.txtIncidentDescription.Size = new System.Drawing.Size(612, 305);
            this.txtIncidentDescription.TabIndex = 5;
            // 
            // rPnl_CreateTicket
            // 
            this.rPnl_CreateTicket.BackColor = System.Drawing.Color.White;
            this.rPnl_CreateTicket.BorderAngle = 90F;
            this.rPnl_CreateTicket.BorderRadius = 40;
            this.rPnl_CreateTicket.Controls.Add(this.lblValidationMessageForIncident);
            this.rPnl_CreateTicket.Controls.Add(this.btnCreateIncident);
            this.rPnl_CreateTicket.Controls.Add(this.tblCreateTicket);
            this.rPnl_CreateTicket.Controls.Add(this.lblWarningsCT);
            this.rPnl_CreateTicket.Controls.Add(this.btnCancelCT);
            this.rPnl_CreateTicket.Controls.Add(this.btnSubmitTicketCT);
            this.rPnl_CreateTicket.Controls.Add(this.header_CreateTicket);
            this.rPnl_CreateTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_CreateTicket.ForeColor = System.Drawing.Color.Black;
            this.rPnl_CreateTicket.Location = new System.Drawing.Point(0, 0);
            this.rPnl_CreateTicket.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_CreateTicket.Name = "rPnl_CreateTicket";
            this.rPnl_CreateTicket.Size = new System.Drawing.Size(1421, 930);
            this.rPnl_CreateTicket.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_CreateTicket.TabIndex = 2;
            // 
            // lblValidationMessageForIncident
            // 
            this.lblValidationMessageForIncident.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValidationMessageForIncident.AutoSize = true;
            this.lblValidationMessageForIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationMessageForIncident.ForeColor = System.Drawing.Color.Red;
            this.lblValidationMessageForIncident.Location = new System.Drawing.Point(430, 813);
            this.lblValidationMessageForIncident.MinimumSize = new System.Drawing.Size(197, 80);
            this.lblValidationMessageForIncident.Name = "lblValidationMessageForIncident";
            this.lblValidationMessageForIncident.Size = new System.Drawing.Size(221, 80);
            this.lblValidationMessageForIncident.TabIndex = 21;
            this.lblValidationMessageForIncident.Text = "Validation message";
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateIncident.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.ForeColor = System.Drawing.Color.White;
            this.btnCreateIncident.Location = new System.Drawing.Point(416, 725);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(301, 77);
            this.btnCreateIncident.TabIndex = 20;
            this.btnCreateIncident.Text = "Submit incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // tblCreateTicket
            // 
            this.tblCreateTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCreateTicket.ColumnCount = 2;
            this.tblCreateTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tblCreateTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCreateTicket.Controls.Add(this.lblDateTimeReportedCT, 0, 0);
            this.tblCreateTicket.Controls.Add(this.dtpReportedCT, 1, 0);
            this.tblCreateTicket.Controls.Add(this.lblSubjectOfIncidentCT, 0, 1);
            this.tblCreateTicket.Controls.Add(this.txtSubjectOfIncidentCT, 1, 1);
            this.tblCreateTicket.Controls.Add(this.txtDescriptionCT, 1, 6);
            this.tblCreateTicket.Controls.Add(this.lblTypeOfIncidentCT, 0, 2);
            this.tblCreateTicket.Controls.Add(this.lblDescription, 0, 6);
            this.tblCreateTicket.Controls.Add(this.cmbDeadlineCT, 1, 5);
            this.tblCreateTicket.Controls.Add(this.cmbIncidentTypeCT, 1, 2);
            this.tblCreateTicket.Controls.Add(this.cmbPriorityCT, 1, 4);
            this.tblCreateTicket.Controls.Add(this.lblDeadlineCT, 0, 5);
            this.tblCreateTicket.Controls.Add(this.lblReportedByUserCT, 0, 3);
            this.tblCreateTicket.Controls.Add(this.cmbUserCT, 1, 3);
            this.tblCreateTicket.Controls.Add(this.lblPriorityCT, 0, 4);
            this.tblCreateTicket.Location = new System.Drawing.Point(8, 88);
            this.tblCreateTicket.Name = "tblCreateTicket";
            this.tblCreateTicket.RowCount = 7;
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCreateTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCreateTicket.Size = new System.Drawing.Size(875, 589);
            this.tblCreateTicket.TabIndex = 19;
            // 
            // lblDateTimeReportedCT
            // 
            this.lblDateTimeReportedCT.AutoSize = true;
            this.lblDateTimeReportedCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateTimeReportedCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDateTimeReportedCT.Location = new System.Drawing.Point(3, 0);
            this.lblDateTimeReportedCT.Name = "lblDateTimeReportedCT";
            this.lblDateTimeReportedCT.Size = new System.Drawing.Size(375, 80);
            this.lblDateTimeReportedCT.TabIndex = 2;
            this.lblDateTimeReportedCT.Text = "Date/Time reported";
            // 
            // dtpReportedCT
            // 
            this.dtpReportedCT.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpReportedCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpReportedCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpReportedCT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportedCT.Location = new System.Drawing.Point(384, 3);
            this.dtpReportedCT.Name = "dtpReportedCT";
            this.dtpReportedCT.Size = new System.Drawing.Size(488, 44);
            this.dtpReportedCT.TabIndex = 3;
            // 
            // lblSubjectOfIncidentCT
            // 
            this.lblSubjectOfIncidentCT.AutoSize = true;
            this.lblSubjectOfIncidentCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubjectOfIncidentCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubjectOfIncidentCT.Location = new System.Drawing.Point(3, 80);
            this.lblSubjectOfIncidentCT.Name = "lblSubjectOfIncidentCT";
            this.lblSubjectOfIncidentCT.Size = new System.Drawing.Size(375, 80);
            this.lblSubjectOfIncidentCT.TabIndex = 4;
            this.lblSubjectOfIncidentCT.Text = "Subject of incident";
            // 
            // txtSubjectOfIncidentCT
            // 
            this.txtSubjectOfIncidentCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubjectOfIncidentCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSubjectOfIncidentCT.Location = new System.Drawing.Point(384, 83);
            this.txtSubjectOfIncidentCT.Name = "txtSubjectOfIncidentCT";
            this.txtSubjectOfIncidentCT.Size = new System.Drawing.Size(488, 44);
            this.txtSubjectOfIncidentCT.TabIndex = 10;
            // 
            // txtDescriptionCT
            // 
            this.txtDescriptionCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescriptionCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescriptionCT.Location = new System.Drawing.Point(384, 483);
            this.txtDescriptionCT.Multiline = true;
            this.txtDescriptionCT.Name = "txtDescriptionCT";
            this.txtDescriptionCT.Size = new System.Drawing.Size(488, 103);
            this.txtDescriptionCT.TabIndex = 15;
            // 
            // lblTypeOfIncidentCT
            // 
            this.lblTypeOfIncidentCT.AutoSize = true;
            this.lblTypeOfIncidentCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTypeOfIncidentCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTypeOfIncidentCT.Location = new System.Drawing.Point(3, 160);
            this.lblTypeOfIncidentCT.Name = "lblTypeOfIncidentCT";
            this.lblTypeOfIncidentCT.Size = new System.Drawing.Size(375, 80);
            this.lblTypeOfIncidentCT.TabIndex = 5;
            this.lblTypeOfIncidentCT.Text = "Type of indicent";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescription.Location = new System.Drawing.Point(3, 480);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(375, 109);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // cmbDeadlineCT
            // 
            this.cmbDeadlineCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDeadlineCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeadlineCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDeadlineCT.FormattingEnabled = true;
            this.cmbDeadlineCT.Location = new System.Drawing.Point(384, 403);
            this.cmbDeadlineCT.Name = "cmbDeadlineCT";
            this.cmbDeadlineCT.Size = new System.Drawing.Size(488, 45);
            this.cmbDeadlineCT.TabIndex = 14;
            // 
            // cmbIncidentTypeCT
            // 
            this.cmbIncidentTypeCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbIncidentTypeCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncidentTypeCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbIncidentTypeCT.FormattingEnabled = true;
            this.cmbIncidentTypeCT.Location = new System.Drawing.Point(384, 163);
            this.cmbIncidentTypeCT.Name = "cmbIncidentTypeCT";
            this.cmbIncidentTypeCT.Size = new System.Drawing.Size(488, 45);
            this.cmbIncidentTypeCT.TabIndex = 11;
            // 
            // cmbPriorityCT
            // 
            this.cmbPriorityCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPriorityCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriorityCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbPriorityCT.FormattingEnabled = true;
            this.cmbPriorityCT.Location = new System.Drawing.Point(384, 323);
            this.cmbPriorityCT.Name = "cmbPriorityCT";
            this.cmbPriorityCT.Size = new System.Drawing.Size(488, 45);
            this.cmbPriorityCT.TabIndex = 13;
            // 
            // lblDeadlineCT
            // 
            this.lblDeadlineCT.AutoSize = true;
            this.lblDeadlineCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeadlineCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDeadlineCT.Location = new System.Drawing.Point(3, 400);
            this.lblDeadlineCT.Name = "lblDeadlineCT";
            this.lblDeadlineCT.Size = new System.Drawing.Size(375, 80);
            this.lblDeadlineCT.TabIndex = 8;
            this.lblDeadlineCT.Text = "Deadline/follow up";
            // 
            // lblReportedByUserCT
            // 
            this.lblReportedByUserCT.AutoSize = true;
            this.lblReportedByUserCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportedByUserCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReportedByUserCT.Location = new System.Drawing.Point(3, 240);
            this.lblReportedByUserCT.Name = "lblReportedByUserCT";
            this.lblReportedByUserCT.Size = new System.Drawing.Size(375, 80);
            this.lblReportedByUserCT.TabIndex = 6;
            this.lblReportedByUserCT.Text = "Reported by user";
            // 
            // cmbUserCT
            // 
            this.cmbUserCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUserCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbUserCT.FormattingEnabled = true;
            this.cmbUserCT.Location = new System.Drawing.Point(384, 243);
            this.cmbUserCT.Name = "cmbUserCT";
            this.cmbUserCT.Size = new System.Drawing.Size(488, 45);
            this.cmbUserCT.TabIndex = 12;
            // 
            // lblPriorityCT
            // 
            this.lblPriorityCT.AutoSize = true;
            this.lblPriorityCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriorityCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPriorityCT.Location = new System.Drawing.Point(3, 320);
            this.lblPriorityCT.Name = "lblPriorityCT";
            this.lblPriorityCT.Size = new System.Drawing.Size(375, 80);
            this.lblPriorityCT.TabIndex = 7;
            this.lblPriorityCT.Text = "Priority";
            // 
            // lblWarningsCT
            // 
            this.lblWarningsCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWarningsCT.AutoSize = true;
            this.lblWarningsCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblWarningsCT.ForeColor = System.Drawing.Color.Red;
            this.lblWarningsCT.Location = new System.Drawing.Point(430, 813);
            this.lblWarningsCT.Name = "lblWarningsCT";
            this.lblWarningsCT.Size = new System.Drawing.Size(199, 78);
            this.lblWarningsCT.TabIndex = 18;
            this.lblWarningsCT.Text = "wow, such errors.\r\nmany mistakes.\r\nvery issues.";
            // 
            // btnCancelCT
            // 
            this.btnCancelCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelCT.BackColor = System.Drawing.Color.White;
            this.btnCancelCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnCancelCT.FlatAppearance.BorderSize = 6;
            this.btnCancelCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelCT.ForeColor = System.Drawing.Color.Black;
            this.btnCancelCT.Location = new System.Drawing.Point(730, 725);
            this.btnCancelCT.Name = "btnCancelCT";
            this.btnCancelCT.Size = new System.Drawing.Size(301, 80);
            this.btnCancelCT.TabIndex = 17;
            this.btnCancelCT.Text = "Cancel";
            this.btnCancelCT.UseVisualStyleBackColor = false;
            this.btnCancelCT.Click += new System.EventHandler(this.btnCancelCT_Click);
            // 
            // btnSubmitTicketCT
            // 
            this.btnSubmitTicketCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmitTicketCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnSubmitTicketCT.FlatAppearance.BorderSize = 0;
            this.btnSubmitTicketCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTicketCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmitTicketCT.ForeColor = System.Drawing.Color.White;
            this.btnSubmitTicketCT.Location = new System.Drawing.Point(416, 725);
            this.btnSubmitTicketCT.Name = "btnSubmitTicketCT";
            this.btnSubmitTicketCT.Size = new System.Drawing.Size(301, 80);
            this.btnSubmitTicketCT.TabIndex = 16;
            this.btnSubmitTicketCT.Text = "Submit Ticket";
            this.btnSubmitTicketCT.UseVisualStyleBackColor = false;
            this.btnSubmitTicketCT.Click += new System.EventHandler(this.btnSubmitTicketCT_Click);
            // 
            // header_CreateTicket
            // 
            this.header_CreateTicket.Controls.Add(this.lbl_HeaderCreateTicket);
            this.header_CreateTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_CreateTicket.Location = new System.Drawing.Point(0, 0);
            this.header_CreateTicket.Name = "header_CreateTicket";
            this.header_CreateTicket.Size = new System.Drawing.Size(1421, 80);
            this.header_CreateTicket.TabIndex = 1;
            // 
            // lbl_HeaderCreateTicket
            // 
            this.lbl_HeaderCreateTicket.AutoSize = true;
            this.lbl_HeaderCreateTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderCreateTicket.Location = new System.Drawing.Point(0, 29);
            this.lbl_HeaderCreateTicket.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.lbl_HeaderCreateTicket.Name = "lbl_HeaderCreateTicket";
            this.lbl_HeaderCreateTicket.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbl_HeaderCreateTicket.Size = new System.Drawing.Size(331, 51);
            this.lbl_HeaderCreateTicket.TabIndex = 0;
            this.lbl_HeaderCreateTicket.Text = "Create Ticket";
            this.lbl_HeaderCreateTicket.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_UserManagement
            // 
            this.tab_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_UserManagement.Controls.Add(this.rPnl_UserManagement);
            this.tab_UserManagement.Location = new System.Drawing.Point(8, 43);
            this.tab_UserManagement.Name = "tab_UserManagement";
            this.tab_UserManagement.Size = new System.Drawing.Size(1421, 965);
            this.tab_UserManagement.TabIndex = 3;
            this.tab_UserManagement.Text = "User Management";
            // 
            // rPnl_UserManagement
            // 
            this.rPnl_UserManagement.BackColor = System.Drawing.Color.White;
            this.rPnl_UserManagement.BorderAngle = 90F;
            this.rPnl_UserManagement.BorderRadius = 40;
            this.rPnl_UserManagement.Controls.Add(this.header_UserManagement);
            this.rPnl_UserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_UserManagement.ForeColor = System.Drawing.Color.Black;
            this.rPnl_UserManagement.Location = new System.Drawing.Point(0, 0);
            this.rPnl_UserManagement.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_UserManagement.Name = "rPnl_UserManagement";
            this.rPnl_UserManagement.Size = new System.Drawing.Size(1421, 965);
            this.rPnl_UserManagement.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_UserManagement.TabIndex = 3;
            // 
            // header_UserManagement
            // 
            this.header_UserManagement.Controls.Add(this.lbl_HeaderUserManagement);
            this.header_UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_UserManagement.Location = new System.Drawing.Point(0, 0);
            this.header_UserManagement.Name = "header_UserManagement";
            this.header_UserManagement.Size = new System.Drawing.Size(1421, 80);
            this.header_UserManagement.TabIndex = 1;
            // 
            // lbl_HeaderUserManagement
            // 
            this.lbl_HeaderUserManagement.AutoSize = true;
            this.lbl_HeaderUserManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderUserManagement.Location = new System.Drawing.Point(0, 29);
            this.lbl_HeaderUserManagement.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.lbl_HeaderUserManagement.Name = "lbl_HeaderUserManagement";
            this.lbl_HeaderUserManagement.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbl_HeaderUserManagement.Size = new System.Drawing.Size(431, 51);
            this.lbl_HeaderUserManagement.TabIndex = 0;
            this.lbl_HeaderUserManagement.Text = "User Management";
            this.lbl_HeaderUserManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_CreateUser
            // 
            this.tab_CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_CreateUser.Controls.Add(this.rPnl_CreateUser);
            this.tab_CreateUser.Location = new System.Drawing.Point(8, 43);
            this.tab_CreateUser.Name = "tab_CreateUser";
            this.tab_CreateUser.Size = new System.Drawing.Size(1421, 965);
            this.tab_CreateUser.TabIndex = 4;
            this.tab_CreateUser.Text = "Create User";
            // 
            // rPnl_CreateUser
            // 
            this.rPnl_CreateUser.BackColor = System.Drawing.Color.White;
            this.rPnl_CreateUser.BorderAngle = 90F;
            this.rPnl_CreateUser.BorderRadius = 40;
            this.rPnl_CreateUser.Controls.Add(this.lblWarning);
            this.rPnl_CreateUser.Controls.Add(this.label9);
            this.rPnl_CreateUser.Controls.Add(this.btnCreatePassword);
            this.rPnl_CreateUser.Controls.Add(this.txtPassword);
            this.rPnl_CreateUser.Controls.Add(this.comboEmployeeType);
            this.rPnl_CreateUser.Controls.Add(this.txtLastName);
            this.rPnl_CreateUser.Controls.Add(this.txtEmail);
            this.rPnl_CreateUser.Controls.Add(this.txtUsername);
            this.rPnl_CreateUser.Controls.Add(this.txtFirstName);
            this.rPnl_CreateUser.Controls.Add(this.btnRegisterUser);
            this.rPnl_CreateUser.Controls.Add(this.label7);
            this.rPnl_CreateUser.Controls.Add(this.label6);
            this.rPnl_CreateUser.Controls.Add(this.label5);
            this.rPnl_CreateUser.Controls.Add(this.label4);
            this.rPnl_CreateUser.Controls.Add(this.label8);
            this.rPnl_CreateUser.Controls.Add(this.header_CreateUser);
            this.rPnl_CreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_CreateUser.ForeColor = System.Drawing.Color.Black;
            this.rPnl_CreateUser.Location = new System.Drawing.Point(0, 0);
            this.rPnl_CreateUser.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_CreateUser.Name = "rPnl_CreateUser";
            this.rPnl_CreateUser.Size = new System.Drawing.Size(1421, 965);
            this.rPnl_CreateUser.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_CreateUser.TabIndex = 4;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(387, 571);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 25);
            this.lblWarning.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(64, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 37);
            this.label9.TabIndex = 58;
            this.label9.Text = "Password:";
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.BackColor = System.Drawing.Color.Coral;
            this.btnCreatePassword.FlatAppearance.BorderSize = 0;
            this.btnCreatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePassword.ForeColor = System.Drawing.Color.Black;
            this.btnCreatePassword.Location = new System.Drawing.Point(949, 469);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(230, 48);
            this.btnCreatePassword.TabIndex = 57;
            this.btnCreatePassword.Text = "Create Password";
            this.btnCreatePassword.UseVisualStyleBackColor = false;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(392, 469);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(513, 44);
            this.txtPassword.TabIndex = 56;
            // 
            // comboEmployeeType
            // 
            this.comboEmployeeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmployeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboEmployeeType.FormattingEnabled = true;
            this.comboEmployeeType.Location = new System.Drawing.Point(392, 397);
            this.comboEmployeeType.Name = "comboEmployeeType";
            this.comboEmployeeType.Size = new System.Drawing.Size(782, 45);
            this.comboEmployeeType.TabIndex = 55;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastName.Location = new System.Drawing.Point(392, 198);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(782, 44);
            this.txtLastName.TabIndex = 54;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(392, 262);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(782, 44);
            this.txtEmail.TabIndex = 53;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(392, 331);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(782, 44);
            this.txtUsername.TabIndex = 52;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(392, 136);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(782, 44);
            this.txtFirstName.TabIndex = 51;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnRegisterUser.FlatAppearance.BorderSize = 0;
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegisterUser.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUser.Location = new System.Drawing.Point(878, 619);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(301, 80);
            this.btnRegisterUser.TabIndex = 50;
            this.btnRegisterUser.Text = "Register User";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(64, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 37);
            this.label7.TabIndex = 49;
            this.label7.Text = "Employee Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(64, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 37);
            this.label6.TabIndex = 48;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(64, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 37);
            this.label5.TabIndex = 47;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(64, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 37);
            this.label4.TabIndex = 46;
            this.label4.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(64, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 37);
            this.label8.TabIndex = 45;
            this.label8.Text = "First Name:";
            // 
            // header_CreateUser
            // 
            this.header_CreateUser.Controls.Add(this.lbl_HeaderCreateUser);
            this.header_CreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_CreateUser.Location = new System.Drawing.Point(0, 0);
            this.header_CreateUser.Name = "header_CreateUser";
            this.header_CreateUser.Size = new System.Drawing.Size(1421, 80);
            this.header_CreateUser.TabIndex = 1;
            // 
            // lbl_HeaderCreateUser
            // 
            this.lbl_HeaderCreateUser.AutoSize = true;
            this.lbl_HeaderCreateUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderCreateUser.Location = new System.Drawing.Point(0, 29);
            this.lbl_HeaderCreateUser.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.lbl_HeaderCreateUser.Name = "lbl_HeaderCreateUser";
            this.lbl_HeaderCreateUser.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbl_HeaderCreateUser.Size = new System.Drawing.Size(304, 51);
            this.lbl_HeaderCreateUser.TabIndex = 0;
            this.lbl_HeaderCreateUser.Text = "Create User";
            this.lbl_HeaderCreateUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_IncidentManagement
            // 
            this.tab_IncidentManagement.Controls.Add(this.lblValidationForIncidentList);
            this.tab_IncidentManagement.Controls.Add(this.listViewIncidents);
            this.tab_IncidentManagement.Controls.Add(this.label3);
            this.tab_IncidentManagement.Controls.Add(this.pnlIncidentDetails);
            this.tab_IncidentManagement.Controls.Add(this.pnlCreateTicket);
            this.tab_IncidentManagement.Location = new System.Drawing.Point(8, 78);
            this.tab_IncidentManagement.Name = "tab_IncidentManagement";
            this.tab_IncidentManagement.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_IncidentManagement.Size = new System.Drawing.Size(1421, 930);
            this.tab_IncidentManagement.TabIndex = 5;
            this.tab_IncidentManagement.Text = "Incident Management";
            this.tab_IncidentManagement.UseVisualStyleBackColor = true;
            // 
            // lblValidationForIncidentList
            // 
            this.lblValidationForIncidentList.AutoSize = true;
            this.lblValidationForIncidentList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValidationForIncidentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationForIncidentList.ForeColor = System.Drawing.Color.Red;
            this.lblValidationForIncidentList.Location = new System.Drawing.Point(45, 413);
            this.lblValidationForIncidentList.MinimumSize = new System.Drawing.Size(1469, 47);
            this.lblValidationForIncidentList.Name = "lblValidationForIncidentList";
            this.lblValidationForIncidentList.Size = new System.Drawing.Size(1469, 47);
            this.lblValidationForIncidentList.TabIndex = 17;
            this.lblValidationForIncidentList.Text = "Validation for loading incident data";
            // 
            // listViewIncidents
            // 
            this.listViewIncidents.HideSelection = false;
            this.listViewIncidents.Location = new System.Drawing.Point(45, 128);
            this.listViewIncidents.Name = "listViewIncidents";
            this.listViewIncidents.Size = new System.Drawing.Size(1468, 330);
            this.listViewIncidents.TabIndex = 2;
            this.listViewIncidents.UseCompatibleStateImageBehavior = false;
            this.listViewIncidents.SelectedIndexChanged += new System.EventHandler(this.listViewIncidents_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 46);
            this.label3.MinimumSize = new System.Drawing.Size(459, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 51);
            this.label3.TabIndex = 1;
            this.label3.Text = "Incident Management";
            // 
            // pnlIncidentDetails
            // 
            this.pnlIncidentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIncidentDetails.Controls.Add(this.lblDescriptionOfIncident);
            this.pnlIncidentDetails.Controls.Add(this.lblTypeOfIncident);
            this.pnlIncidentDetails.Controls.Add(this.lblSubjectOfIncident);
            this.pnlIncidentDetails.Controls.Add(this.txtSubjectOfIncident);
            this.pnlIncidentDetails.Controls.Add(this.txtTypeOfIncident);
            this.pnlIncidentDetails.Controls.Add(this.txtDescriptionOfIncident);
            this.pnlIncidentDetails.Controls.Add(this.lblSubmittedByUser);
            this.pnlIncidentDetails.Location = new System.Drawing.Point(45, 486);
            this.pnlIncidentDetails.Name = "pnlIncidentDetails";
            this.pnlIncidentDetails.Size = new System.Drawing.Size(687, 685);
            this.pnlIncidentDetails.TabIndex = 16;
            // 
            // lblDescriptionOfIncident
            // 
            this.lblDescriptionOfIncident.AutoSize = true;
            this.lblDescriptionOfIncident.Location = new System.Drawing.Point(58, 341);
            this.lblDescriptionOfIncident.Name = "lblDescriptionOfIncident";
            this.lblDescriptionOfIncident.Size = new System.Drawing.Size(122, 30);
            this.lblDescriptionOfIncident.TabIndex = 12;
            this.lblDescriptionOfIncident.Text = "Description:";
            this.lblDescriptionOfIncident.UseCompatibleTextRendering = true;
            // 
            // lblTypeOfIncident
            // 
            this.lblTypeOfIncident.AutoSize = true;
            this.lblTypeOfIncident.Location = new System.Drawing.Point(51, 237);
            this.lblTypeOfIncident.Name = "lblTypeOfIncident";
            this.lblTypeOfIncident.Size = new System.Drawing.Size(66, 25);
            this.lblTypeOfIncident.TabIndex = 11;
            this.lblTypeOfIncident.Text = "Type:";
            // 
            // lblSubjectOfIncident
            // 
            this.lblSubjectOfIncident.AutoSize = true;
            this.lblSubjectOfIncident.Location = new System.Drawing.Point(51, 125);
            this.lblSubjectOfIncident.Name = "lblSubjectOfIncident";
            this.lblSubjectOfIncident.Size = new System.Drawing.Size(90, 25);
            this.lblSubjectOfIncident.TabIndex = 10;
            this.lblSubjectOfIncident.Text = "Subject:";
            // 
            // txtSubjectOfIncident
            // 
            this.txtSubjectOfIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectOfIncident.Location = new System.Drawing.Point(45, 160);
            this.txtSubjectOfIncident.MinimumSize = new System.Drawing.Size(580, 47);
            this.txtSubjectOfIncident.Multiline = true;
            this.txtSubjectOfIncident.Name = "txtSubjectOfIncident";
            this.txtSubjectOfIncident.Size = new System.Drawing.Size(580, 47);
            this.txtSubjectOfIncident.TabIndex = 3;
            // 
            // txtTypeOfIncident
            // 
            this.txtTypeOfIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeOfIncident.Location = new System.Drawing.Point(45, 272);
            this.txtTypeOfIncident.MinimumSize = new System.Drawing.Size(580, 47);
            this.txtTypeOfIncident.Multiline = true;
            this.txtTypeOfIncident.Name = "txtTypeOfIncident";
            this.txtTypeOfIncident.Size = new System.Drawing.Size(580, 47);
            this.txtTypeOfIncident.TabIndex = 9;
            // 
            // txtDescriptionOfIncident
            // 
            this.txtDescriptionOfIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescriptionOfIncident.Location = new System.Drawing.Point(50, 382);
            this.txtDescriptionOfIncident.Multiline = true;
            this.txtDescriptionOfIncident.Name = "txtDescriptionOfIncident";
            this.txtDescriptionOfIncident.Size = new System.Drawing.Size(580, 175);
            this.txtDescriptionOfIncident.TabIndex = 4;
            // 
            // lblSubmittedByUser
            // 
            this.lblSubmittedByUser.AutoSize = true;
            this.lblSubmittedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittedByUser.Location = new System.Drawing.Point(35, 30);
            this.lblSubmittedByUser.Name = "lblSubmittedByUser";
            this.lblSubmittedByUser.Size = new System.Drawing.Size(311, 51);
            this.lblSubmittedByUser.TabIndex = 7;
            this.lblSubmittedByUser.Text = "Incident details";
            // 
            // pnlCreateTicket
            // 
            this.pnlCreateTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCreateTicket.Controls.Add(this.lblValidationCreateTicket);
            this.pnlCreateTicket.Controls.Add(this.btnCreateTicket);
            this.pnlCreateTicket.Controls.Add(this.lblDeadline);
            this.pnlCreateTicket.Controls.Add(this.lblCreateTicket);
            this.pnlCreateTicket.Controls.Add(this.cmbPriority);
            this.pnlCreateTicket.Controls.Add(this.cmbDeadlineInterval);
            this.pnlCreateTicket.Controls.Add(this.cmbUser);
            this.pnlCreateTicket.Controls.Add(this.lblStatus);
            this.pnlCreateTicket.Controls.Add(this.cmbNewIncidentType);
            this.pnlCreateTicket.Controls.Add(this.cmbStatus);
            this.pnlCreateTicket.Controls.Add(this.lblPriority);
            this.pnlCreateTicket.Controls.Add(this.lblUser);
            this.pnlCreateTicket.Controls.Add(this.lblNewIncidentType);
            this.pnlCreateTicket.Location = new System.Drawing.Point(806, 493);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(706, 685);
            this.pnlCreateTicket.TabIndex = 13;
            // 
            // lblValidationCreateTicket
            // 
            this.lblValidationCreateTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValidationCreateTicket.Location = new System.Drawing.Point(-2, 630);
            this.lblValidationCreateTicket.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblValidationCreateTicket.Name = "lblValidationCreateTicket";
            this.lblValidationCreateTicket.Size = new System.Drawing.Size(706, 53);
            this.lblValidationCreateTicket.TabIndex = 13;
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(266, 560);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(181, 58);
            this.btnCreateTicket.TabIndex = 15;
            this.btnCreateTicket.Text = "Create";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(54, 469);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(103, 25);
            this.lblDeadline.TabIndex = 16;
            this.lblDeadline.Text = "Deadline:";
            // 
            // lblCreateTicket
            // 
            this.lblCreateTicket.AutoSize = true;
            this.lblCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTicket.Location = new System.Drawing.Point(208, 22);
            this.lblCreateTicket.Name = "lblCreateTicket";
            this.lblCreateTicket.Size = new System.Drawing.Size(264, 51);
            this.lblCreateTicket.TabIndex = 8;
            this.lblCreateTicket.Text = "Create ticket";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(51, 333);
            this.cmbPriority.MinimumSize = new System.Drawing.Size(602, 0);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(602, 33);
            this.cmbPriority.TabIndex = 13;
            // 
            // cmbDeadlineInterval
            // 
            this.cmbDeadlineInterval.FormattingEnabled = true;
            this.cmbDeadlineInterval.Location = new System.Drawing.Point(51, 502);
            this.cmbDeadlineInterval.MinimumSize = new System.Drawing.Size(602, 0);
            this.cmbDeadlineInterval.Name = "cmbDeadlineInterval";
            this.cmbDeadlineInterval.Size = new System.Drawing.Size(602, 33);
            this.cmbDeadlineInterval.TabIndex = 15;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(51, 245);
            this.cmbUser.MinimumSize = new System.Drawing.Size(602, 0);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(602, 33);
            this.cmbUser.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(54, 386);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status:";
            // 
            // cmbNewIncidentType
            // 
            this.cmbNewIncidentType.FormattingEnabled = true;
            this.cmbNewIncidentType.Location = new System.Drawing.Point(51, 160);
            this.cmbNewIncidentType.MinimumSize = new System.Drawing.Size(602, 0);
            this.cmbNewIncidentType.Name = "cmbNewIncidentType";
            this.cmbNewIncidentType.Size = new System.Drawing.Size(602, 33);
            this.cmbNewIncidentType.TabIndex = 11;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(51, 418);
            this.cmbStatus.MinimumSize = new System.Drawing.Size(602, 0);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(602, 33);
            this.cmbStatus.TabIndex = 14;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(54, 299);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(85, 25);
            this.lblPriority.TabIndex = 13;
            this.lblPriority.Text = "Priority:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(53, 211);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 25);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User:";
            // 
            // lblNewIncidentType
            // 
            this.lblNewIncidentType.AutoSize = true;
            this.lblNewIncidentType.Location = new System.Drawing.Point(53, 125);
            this.lblNewIncidentType.Name = "lblNewIncidentType";
            this.lblNewIncidentType.Size = new System.Drawing.Size(66, 25);
            this.lblNewIncidentType.TabIndex = 11;
            this.lblNewIncidentType.Text = "Type:";
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.sideBar.ColumnCount = 1;
            this.sideBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideBar.Controls.Add(this.tblPnl_UserInfo, 0, 2);
            this.sideBar.Controls.Add(this.flowPnl_Navigation, 0, 3);
            this.sideBar.Controls.Add(this.lbl_LogOut, 0, 4);
            this.sideBar.Controls.Add(this.tblPnl_Logo, 0, 0);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.sideBar.Location = new System.Drawing.Point(3, 3);
            this.sideBar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.sideBar.Name = "sideBar";
            this.sideBar.RowCount = 5;
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.sideBar.Size = new System.Drawing.Size(464, 1048);
            this.sideBar.TabIndex = 1;
            // 
            // tblPnl_UserInfo
            // 
            this.tblPnl_UserInfo.ColumnCount = 1;
            this.tblPnl_UserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnl_UserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnl_UserInfo.Controls.Add(this.lbl_Welcome, 0, 0);
            this.tblPnl_UserInfo.Controls.Add(this.lbl_Username, 0, 1);
            this.tblPnl_UserInfo.Controls.Add(this.lbl_Role, 0, 2);
            this.tblPnl_UserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnl_UserInfo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPnl_UserInfo.Location = new System.Drawing.Point(0, 269);
            this.tblPnl_UserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tblPnl_UserInfo.Name = "tblPnl_UserInfo";
            this.tblPnl_UserInfo.RowCount = 3;
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.Size = new System.Drawing.Size(464, 131);
            this.tblPnl_UserInfo.TabIndex = 1;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome.Location = new System.Drawing.Point(3, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(458, 43);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome,";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(0, 43);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(464, 43);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "{Username}";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Role
            // 
            this.lbl_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Role.Location = new System.Drawing.Point(3, 86);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(458, 45);
            this.lbl_Role.TabIndex = 2;
            this.lbl_Role.Text = "{Role}";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPnl_Navigation
            // 
            this.flowPnl_Navigation.Controls.Add(this.btn_Dashboard);
            this.flowPnl_Navigation.Controls.Add(this.btn_TicketManagement);
            this.flowPnl_Navigation.Controls.Add(this.btn_CreateTicket);
            this.flowPnl_Navigation.Controls.Add(this.btn_UserManagement);
            this.flowPnl_Navigation.Controls.Add(this.btn_CreateUser);
            this.flowPnl_Navigation.Controls.Add(this.btnIncidentManagement);
            this.flowPnl_Navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnl_Navigation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPnl_Navigation.Location = new System.Drawing.Point(0, 451);
            this.flowPnl_Navigation.Margin = new System.Windows.Forms.Padding(0, 51, 0, 0);
            this.flowPnl_Navigation.Name = "flowPnl_Navigation";
            this.flowPnl_Navigation.Size = new System.Drawing.Size(464, 517);
            this.flowPnl_Navigation.TabIndex = 2;
            this.flowPnl_Navigation.WrapContents = false;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btn_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(13, 3);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(461, 80);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // btn_TicketManagement
            // 
            this.btn_TicketManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_TicketManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TicketManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TicketManagement.FlatAppearance.BorderSize = 0;
            this.btn_TicketManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_TicketManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_TicketManagement.ForeColor = System.Drawing.Color.White;
            this.btn_TicketManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_TicketManagement.Image")));
            this.btn_TicketManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TicketManagement.Location = new System.Drawing.Point(13, 89);
            this.btn_TicketManagement.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btn_TicketManagement.Name = "btn_TicketManagement";
            this.btn_TicketManagement.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_TicketManagement.Size = new System.Drawing.Size(461, 80);
            this.btn_TicketManagement.TabIndex = 5;
            this.btn_TicketManagement.Text = "Ticket Management";
            this.btn_TicketManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TicketManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TicketManagement.UseVisualStyleBackColor = false;
            this.btn_TicketManagement.Click += new System.EventHandler(this.Btn_TicketManagement_Click);
            // 
            // btn_CreateTicket
            // 
            this.btn_CreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_CreateTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CreateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateTicket.FlatAppearance.BorderSize = 0;
            this.btn_CreateTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_CreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_CreateTicket.ForeColor = System.Drawing.Color.White;
            this.btn_CreateTicket.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreateTicket.Image")));
            this.btn_CreateTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateTicket.Location = new System.Drawing.Point(13, 175);
            this.btn_CreateTicket.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btn_CreateTicket.Name = "btn_CreateTicket";
            this.btn_CreateTicket.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_CreateTicket.Size = new System.Drawing.Size(461, 80);
            this.btn_CreateTicket.TabIndex = 6;
            this.btn_CreateTicket.Text = "Create Ticket";
            this.btn_CreateTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateTicket.UseVisualStyleBackColor = false;
            this.btn_CreateTicket.Click += new System.EventHandler(this.Btn_CreateTicket_Click);
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_UserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_UserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UserManagement.FlatAppearance.BorderSize = 0;
            this.btn_UserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_UserManagement.ForeColor = System.Drawing.Color.White;
            this.btn_UserManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_UserManagement.Image")));
            this.btn_UserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserManagement.Location = new System.Drawing.Point(13, 261);
            this.btn_UserManagement.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_UserManagement.Size = new System.Drawing.Size(461, 80);
            this.btn_UserManagement.TabIndex = 7;
            this.btn_UserManagement.Text = "User Management";
            this.btn_UserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UserManagement.UseVisualStyleBackColor = false;
            this.btn_UserManagement.Click += new System.EventHandler(this.Btn_UserManagement_Click);
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_CreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateUser.FlatAppearance.BorderSize = 0;
            this.btn_CreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_CreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_CreateUser.ForeColor = System.Drawing.Color.White;
            this.btn_CreateUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreateUser.Image")));
            this.btn_CreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateUser.Location = new System.Drawing.Point(13, 347);
            this.btn_CreateUser.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_CreateUser.Size = new System.Drawing.Size(461, 80);
            this.btn_CreateUser.TabIndex = 8;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            this.btn_CreateUser.Click += new System.EventHandler(this.Btn_CreateUser_Click);
            // 
            // btnIncidentManagement
            // 
            this.btnIncidentManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btnIncidentManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncidentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncidentManagement.FlatAppearance.BorderSize = 0;
            this.btnIncidentManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btnIncidentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncidentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnIncidentManagement.ForeColor = System.Drawing.Color.White;
            this.btnIncidentManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnIncidentManagement.Image")));
            this.btnIncidentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidentManagement.Location = new System.Drawing.Point(13, 433);
            this.btnIncidentManagement.Margin = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.btnIncidentManagement.Name = "btnIncidentManagement";
            this.btnIncidentManagement.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnIncidentManagement.Size = new System.Drawing.Size(461, 80);
            this.btnIncidentManagement.TabIndex = 9;
            this.btnIncidentManagement.Text = "Incident Management";
            this.btnIncidentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncidentManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncidentManagement.UseVisualStyleBackColor = false;
            this.btnIncidentManagement.Click += new System.EventHandler(this.btnIncidentManagement_Click);
            // 
            // lbl_LogOut
            // 
            this.lbl_LogOut.AutoSize = true;
            this.lbl_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_LogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_LogOut.ForeColor = System.Drawing.Color.White;
            this.lbl_LogOut.Location = new System.Drawing.Point(3, 968);
            this.lbl_LogOut.Name = "lbl_LogOut";
            this.lbl_LogOut.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.lbl_LogOut.Size = new System.Drawing.Size(458, 80);
            this.lbl_LogOut.TabIndex = 3;
            this.lbl_LogOut.Text = "Log out";
            this.lbl_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // tblPnl_Logo
            // 
            this.tblPnl_Logo.ColumnCount = 1;
            this.tblPnl_Logo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnl_Logo.Controls.Add(this.pic_Logo, 0, 2);
            this.tblPnl_Logo.Controls.Add(this.label1, 0, 1);
            this.tblPnl_Logo.Controls.Add(this.label2, 0, 0);
            this.tblPnl_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnl_Logo.Location = new System.Drawing.Point(3, 3);
            this.tblPnl_Logo.Name = "tblPnl_Logo";
            this.tblPnl_Logo.RowCount = 3;
            this.tblPnl_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tblPnl_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPnl_Logo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tblPnl_Logo.Size = new System.Drawing.Size(458, 234);
            this.tblPnl_Logo.TabIndex = 4;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(8, 110);
            this.pic_Logo.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(442, 121);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 1;
            this.pic_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Licensed to:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "NoDesk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1923, 1054);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1519, 773);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResizeBegin += new System.EventHandler(this.Main_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_Dashboard.ResumeLayout(false);
            this.rPnl_Dashboard.ResumeLayout(false);
            this.tblPnl_Dashboard.ResumeLayout(false);
            this.rPnl_D1_Open.ResumeLayout(false);
            this.rPnl_D3_Unresolved.ResumeLayout(false);
            this.rPnl_D2_Past.ResumeLayout(false);
            this.rPnl_D4_Resolved.ResumeLayout(false);
            this.pnl_DashBoard_Title.ResumeLayout(false);
            this.pnl_DashBoard_Title.PerformLayout();
            this.header_Dashboard.ResumeLayout(false);
            this.header_Dashboard.PerformLayout();
            this.tab_TicketManagement.ResumeLayout(false);
            this.rPnl_TicketManagement.ResumeLayout(false);
            this.pnl_TicketManagement.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowPnl_TicketManagement_SearchButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.header_TicketManagement.ResumeLayout(false);
            this.header_TicketManagement.PerformLayout();
            this.tab_CreateTicket.ResumeLayout(false);
            this.tblCreateIncident.ResumeLayout(false);
            this.tblCreateIncident.PerformLayout();
            this.rPnl_CreateTicket.ResumeLayout(false);
            this.rPnl_CreateTicket.PerformLayout();
            this.tblCreateTicket.ResumeLayout(false);
            this.tblCreateTicket.PerformLayout();
            this.header_CreateTicket.ResumeLayout(false);
            this.header_CreateTicket.PerformLayout();
            this.tab_UserManagement.ResumeLayout(false);
            this.rPnl_UserManagement.ResumeLayout(false);
            this.header_UserManagement.ResumeLayout(false);
            this.header_UserManagement.PerformLayout();
            this.tab_CreateUser.ResumeLayout(false);
            this.rPnl_CreateUser.ResumeLayout(false);
            this.rPnl_CreateUser.PerformLayout();
            this.header_CreateUser.ResumeLayout(false);
            this.header_CreateUser.PerformLayout();
            this.tab_IncidentManagement.ResumeLayout(false);
            this.tab_IncidentManagement.PerformLayout();
            this.pnlIncidentDetails.ResumeLayout(false);
            this.pnlIncidentDetails.PerformLayout();
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            this.tblPnl_UserInfo.ResumeLayout(false);
            this.flowPnl_Navigation.ResumeLayout(false);
            this.tblPnl_Logo.ResumeLayout(false);
            this.tblPnl_Logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel sideBar;
        private System.Windows.Forms.TableLayoutPanel tblPnl_UserInfo;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.FlowLayoutPanel flowPnl_Navigation;
        private Custom_Controls.RoundedButton btn_Dashboard;
        private Custom_Controls.RoundedButton btn_TicketManagement;
        private Custom_Controls.RoundedButton btn_CreateTicket;
        private Custom_Controls.RoundedButton btn_UserManagement;
        private Custom_Controls.RoundedButton btn_CreateUser;
        private System.Windows.Forms.Label lbl_LogOut;
        private Custom_Controls.FasterTableLayoutPanel tblPnl_Logo;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Custom_Controls.TabControlWithoutBorder tabControl;
        private System.Windows.Forms.TabPage tab_Dashboard;
        private Custom_Controls.RoundedPanel rPnl_Dashboard;
        private Custom_Controls.FasterTableLayoutPanel tblPnl_Dashboard;
        private Custom_Controls.RoundedPanel rPnl_D1_Open;
        private Custom_Controls.CircularProgressBar circleBar_Open;
        private System.Windows.Forms.Label lbl_OpenIncidents_Desc;
        private System.Windows.Forms.Label lbl_OpenIncidents_Title;
        private Custom_Controls.RoundedPanel rPnl_D3_Unresolved;
        private Custom_Controls.CircularProgressBar circleBar_Unresolved;
        private System.Windows.Forms.Label lbl_PastDeadline_Desc;
        private System.Windows.Forms.Label lbl_PastDeadline_Title;
        private Custom_Controls.RoundedPanel rPnl_D2_Past;
        private Custom_Controls.CircularProgressBar circleBar_PastDeadline;
        private System.Windows.Forms.Label lbl_Unresolved_Desc;
        private System.Windows.Forms.Label lbl_Unresolved_Title;
        private Custom_Controls.RoundedPanel rPnl_D4_Resolved;
        private Custom_Controls.CircularProgressBar circleBar_Resolved;
        private System.Windows.Forms.Label lbl_Resolved_Desc;
        private System.Windows.Forms.Label lbl_Resolved_Title;
        private System.Windows.Forms.Panel pnl_DashBoard_Title;
        private Custom_Controls.RoundedButton btn_ShowAllIncidents;
        private System.Windows.Forms.Label lbl_CurrentIncidents;
        private System.Windows.Forms.Panel header_Dashboard;
        private System.Windows.Forms.Label lbl_HeaderDashboard;
        private System.Windows.Forms.TabPage tab_TicketManagement;
        private Custom_Controls.RoundedPanel rPnl_TicketManagement;
        private Custom_Controls.RoundedPanel pnl_TicketManagement;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView_TicketManagement;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_Subject;
        private System.Windows.Forms.ColumnHeader col_User;
        private System.Windows.Forms.ColumnHeader col_Date;
        private System.Windows.Forms.ColumnHeader col_Status;
        private System.Windows.Forms.ColumnHeader col_IsClosed;
        private Custom_Controls.TextBoxWithPrompt txtBox_SearchBar;
        private System.Windows.Forms.FlowLayoutPanel flowPnl_TicketManagement_SearchButtons;
        private Custom_Controls.RoundedButton btn_Display_Tickets_All;
        private Custom_Controls.RoundedButton btn_Display_Tickets_Open;
        private Custom_Controls.RoundedButton btn_Display_Tickets_PastDeadline;
        private Custom_Controls.RoundedButton btn_Display_Tickets_Unresolved;
        private Custom_Controls.RoundedButton btn_Display_Tickets_Resolved;
        private Custom_Controls.RoundedButton btn_Display_Tickets_Closed;
        private System.Windows.Forms.TextBox txtDetailsDescription;
        private System.Windows.Forms.Label lblDetailsDescription;
        private System.Windows.Forms.ComboBox cmbDetailsDeadline;
        private System.Windows.Forms.Label lblDetailsDeadlineDays;
        private System.Windows.Forms.Label lblDetailsWarning;
        private System.Windows.Forms.ComboBox cmbDetailsStatus;
        private System.Windows.Forms.Label lblDetailsStatus;
        private System.Windows.Forms.ComboBox cmbDetailsPriority;
        private System.Windows.Forms.Label lblDetailsPriority;
        private System.Windows.Forms.ComboBox cmbDetailsReporter;
        private System.Windows.Forms.Label lblDetailsUser;
        private System.Windows.Forms.ComboBox cmbDetailsIncidentType;
        private System.Windows.Forms.Label lblDetailsIncidentType;
        private System.Windows.Forms.TextBox txtDetailsSubject;
        private System.Windows.Forms.Label lblTicketDetailsSubjectOfIncident;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Custom_Controls.RoundedButton btnDetailsEscalate;
        private Custom_Controls.RoundedButton btnDetailsUpdate;
        private Custom_Controls.RoundedButton btnDetailsClose;
        private Custom_Controls.RoundedButton btnDetailsDelete;
        private System.Windows.Forms.Panel header_TicketManagement;
        private System.Windows.Forms.Label lbl_HeaderTicketManagement;
        private System.Windows.Forms.TabPage tab_CreateTicket;
        private Custom_Controls.RoundedPanel rPnl_CreateTicket;
        private System.Windows.Forms.TableLayoutPanel tblCreateTicket;
        private System.Windows.Forms.Label lblDateTimeReportedCT;
        private System.Windows.Forms.DateTimePicker dtpReportedCT;
        private System.Windows.Forms.Label lblSubjectOfIncidentCT;
        private System.Windows.Forms.TextBox txtSubjectOfIncidentCT;
        private System.Windows.Forms.TextBox txtDescriptionCT;
        private System.Windows.Forms.Label lblTypeOfIncidentCT;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbDeadlineCT;
        private System.Windows.Forms.ComboBox cmbIncidentTypeCT;
        private System.Windows.Forms.ComboBox cmbPriorityCT;
        private System.Windows.Forms.Label lblDeadlineCT;
        private System.Windows.Forms.Label lblReportedByUserCT;
        private System.Windows.Forms.ComboBox cmbUserCT;
        private System.Windows.Forms.Label lblPriorityCT;
        private System.Windows.Forms.Label lblWarningsCT;
        private Custom_Controls.RoundedButton btnCancelCT;
        private Custom_Controls.RoundedButton btnSubmitTicketCT;
        private System.Windows.Forms.Panel header_CreateTicket;
        private System.Windows.Forms.Label lbl_HeaderCreateTicket;
        private System.Windows.Forms.TabPage tab_UserManagement;
        private Custom_Controls.RoundedPanel rPnl_UserManagement;
        private System.Windows.Forms.Panel header_UserManagement;
        private System.Windows.Forms.Label lbl_HeaderUserManagement;
        private System.Windows.Forms.TabPage tab_CreateUser;
        private Custom_Controls.RoundedPanel rPnl_CreateUser;
        private System.Windows.Forms.Panel header_CreateUser;
        private System.Windows.Forms.Label lbl_HeaderCreateUser;
        private System.Windows.Forms.TableLayoutPanel tblCreateIncident;
        private System.Windows.Forms.Label lblIncidentSubject;
        private System.Windows.Forms.Label lblIncidentType;
        private System.Windows.Forms.Label lblIncidentDescription;
        private System.Windows.Forms.TextBox txtIncidentSubject;
        private System.Windows.Forms.ComboBox cmbIncidentType;
        private System.Windows.Forms.TextBox txtIncidentDescription;
        private Custom_Controls.RoundedButton btnIncidentManagement;
        private System.Windows.Forms.TabPage tab_IncidentManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewIncidents;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbNewIncidentType;
        private System.Windows.Forms.Label lblCreateTicket;
        private System.Windows.Forms.Panel pnlIncidentDetails;
        private System.Windows.Forms.Label lblDescriptionOfIncident;
        private System.Windows.Forms.Label lblTypeOfIncident;
        private System.Windows.Forms.Label lblSubjectOfIncident;
        private System.Windows.Forms.TextBox txtSubjectOfIncident;
        private System.Windows.Forms.TextBox txtDescriptionOfIncident;
        private System.Windows.Forms.Label lblSubmittedByUser;
        private System.Windows.Forms.Panel pnlCreateTicket;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.ComboBox cmbDeadlineInterval;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNewIncidentType;
        private System.Windows.Forms.TextBox txtTypeOfIncident;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.Label lblValidationMessageForIncident;
        private System.Windows.Forms.Label lblValidationForIncidentList;
        private System.Windows.Forms.Label lblValidationCreateTicket;
        private System.Windows.Forms.ComboBox comboEmployeeType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFirstName;
        private Custom_Controls.RoundedButton btnRegisterUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Custom_Controls.RoundedButton btnTransfer;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label label9;
        private Custom_Controls.RoundedButton btnCreatePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblWarning;
    }
}