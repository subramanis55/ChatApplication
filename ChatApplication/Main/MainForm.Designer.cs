namespace ChatApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.chatPage = new System.Windows.Forms.TabPage();
            this.alreadyMessagedContactsPanel = new System.Windows.Forms.Panel();
            this.chatPageSearchBoxPanel = new System.Windows.Forms.Panel();
            this.chatPageSearchBox = new ChatApplication.CustomSearchBox();
            this.chatPageTopPanel = new System.Windows.Forms.Panel();
            this.refreshBtn = new ChatApplication.EllipseButton();
            this.contactListBtn = new ChatApplication.EllipseButton();
            this.filterContactsBtn = new ChatApplication.EllipseButton();
            this.chatLB = new System.Windows.Forms.Label();
            this.callsPage = new System.Windows.Forms.TabPage();
            this.StatusPage = new System.Windows.Forms.TabPage();
            this.starredMessagePage = new System.Windows.Forms.TabPage();
            this.archivedPage = new System.Windows.Forms.TabPage();
            this.ArchivedContactsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.chatTabpage = new System.Windows.Forms.TabPage();
            this.chatTabPageMainPanel = new System.Windows.Forms.Panel();
            this.messageShowP = new System.Windows.Forms.Panel();
            this.chatPageTitleU = new ChatApplication.ChatPageTitleU();
            this.messageTextBoxPanel = new System.Windows.Forms.Panel();
            this.messageTB = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attachmentBtn = new ChatApplication.EllipseButton();
            this.sentBtnP = new System.Windows.Forms.Panel();
            this.sentBtn = new ChatApplication.EllipseButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.defaultPage = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuControl = new ChatApplication.MenuControl();
            this.customTooltip1 = new ChatApplication.CustomTooltip();
            this.menuTabControl.SuspendLayout();
            this.chatPage.SuspendLayout();
            this.chatPageSearchBoxPanel.SuspendLayout();
            this.chatPageTopPanel.SuspendLayout();
            this.archivedPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.chatTabpage.SuspendLayout();
            this.chatTabPageMainPanel.SuspendLayout();
            this.messageTextBoxPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sentBtnP.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.chatPage);
            this.menuTabControl.Controls.Add(this.callsPage);
            this.menuTabControl.Controls.Add(this.StatusPage);
            this.menuTabControl.Controls.Add(this.starredMessagePage);
            this.menuTabControl.Controls.Add(this.archivedPage);
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuTabControl.ItemSize = new System.Drawing.Size(10, 10);
            this.menuTabControl.Location = new System.Drawing.Point(83, 0);
            this.menuTabControl.MinimumSize = new System.Drawing.Size(400, 0);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.Padding = new System.Drawing.Point(0, 0);
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(400, 600);
            this.menuTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuTabControl.TabIndex = 0;
            // 
            // chatPage
            // 
            this.chatPage.Controls.Add(this.alreadyMessagedContactsPanel);
            this.chatPage.Controls.Add(this.chatPageSearchBoxPanel);
            this.chatPage.Controls.Add(this.chatPageTopPanel);
            this.chatPage.Location = new System.Drawing.Point(4, 14);
            this.chatPage.Name = "chatPage";
            this.chatPage.Size = new System.Drawing.Size(392, 582);
            this.chatPage.TabIndex = 0;
            this.chatPage.UseVisualStyleBackColor = true;
            // 
            // alreadyMessagedContactsPanel
            // 
            this.alreadyMessagedContactsPanel.AutoScroll = true;
            this.alreadyMessagedContactsPanel.BackColor = System.Drawing.Color.Transparent;
            this.alreadyMessagedContactsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alreadyMessagedContactsPanel.Location = new System.Drawing.Point(0, 141);
            this.alreadyMessagedContactsPanel.Name = "alreadyMessagedContactsPanel";
            this.alreadyMessagedContactsPanel.Size = new System.Drawing.Size(392, 441);
            this.alreadyMessagedContactsPanel.TabIndex = 0;
            // 
            // chatPageSearchBoxPanel
            // 
            this.chatPageSearchBoxPanel.Controls.Add(this.chatPageSearchBox);
            this.chatPageSearchBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatPageSearchBoxPanel.Location = new System.Drawing.Point(0, 75);
            this.chatPageSearchBoxPanel.Name = "chatPageSearchBoxPanel";
            this.chatPageSearchBoxPanel.Padding = new System.Windows.Forms.Padding(20, 4, 20, 8);
            this.chatPageSearchBoxPanel.Size = new System.Drawing.Size(392, 66);
            this.chatPageSearchBoxPanel.TabIndex = 1;
            this.chatPageSearchBoxPanel.Resize += new System.EventHandler(this.mainSearchBoxPanelResize);
            // 
            // chatPageSearchBox
            // 
            this.chatPageSearchBox.BackColor = System.Drawing.Color.White;
            this.chatPageSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.chatPageSearchBox.BorderSize = 4;
            this.chatPageSearchBox.IsPlaceholder = true;
            this.chatPageSearchBox.IsSearchIconVisible = false;
            this.chatPageSearchBox.IsUnderLine = true;
            this.chatPageSearchBox.Location = new System.Drawing.Point(34, 12);
            this.chatPageSearchBox.MinimumSize = new System.Drawing.Size(0, 40);
            this.chatPageSearchBox.Multiline = true;
            this.chatPageSearchBox.Name = "chatPageSearchBox";
            this.chatPageSearchBox.Padding = new System.Windows.Forms.Padding(7);
            this.chatPageSearchBox.PlaceholderText = "Search or start new chat";
            this.chatPageSearchBox.ReadOnly = false;
            this.chatPageSearchBox.Size = new System.Drawing.Size(310, 43);
            this.chatPageSearchBox.TabIndex = 0;
            // 
            // chatPageTopPanel
            // 
            this.chatPageTopPanel.Controls.Add(this.refreshBtn);
            this.chatPageTopPanel.Controls.Add(this.contactListBtn);
            this.chatPageTopPanel.Controls.Add(this.filterContactsBtn);
            this.chatPageTopPanel.Controls.Add(this.chatLB);
            this.chatPageTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatPageTopPanel.Location = new System.Drawing.Point(0, 0);
            this.chatPageTopPanel.MinimumSize = new System.Drawing.Size(0, 75);
            this.chatPageTopPanel.Name = "chatPageTopPanel";
            this.chatPageTopPanel.Padding = new System.Windows.Forms.Padding(15);
            this.chatPageTopPanel.Size = new System.Drawing.Size(392, 75);
            this.chatPageTopPanel.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.refreshBtn.BorderRadius1 = 10;
            this.refreshBtn.BorderSize1 = 0;
            this.refreshBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.refreshBtn.EllipseColor = System.Drawing.Color.White;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Image = global::ChatApplication.Properties.Resources.RefreshIcon__2_;
            this.refreshBtn.Location = new System.Drawing.Point(237, 15);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(54, 45);
            this.refreshBtn.SlowMotionInterval = 5;
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.TextColor = System.Drawing.Color.White;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtnClicked);
            // 
            // contactListBtn
            // 
            this.contactListBtn.BackColor = System.Drawing.Color.Transparent;
            this.contactListBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.contactListBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.contactListBtn.BorderRadius1 = 10;
            this.contactListBtn.BorderSize1 = 0;
            this.contactListBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.contactListBtn.EllipseColor = System.Drawing.Color.White;
            this.contactListBtn.FlatAppearance.BorderSize = 0;
            this.contactListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactListBtn.ForeColor = System.Drawing.Color.White;
            this.contactListBtn.Image = global::ChatApplication.Properties.Resources.icons8_create_20;
            this.contactListBtn.Location = new System.Drawing.Point(291, 15);
            this.contactListBtn.Name = "contactListBtn";
            this.contactListBtn.Size = new System.Drawing.Size(42, 45);
            this.contactListBtn.SlowMotionInterval = 5;
            this.contactListBtn.TabIndex = 2;
            this.contactListBtn.TextColor = System.Drawing.Color.White;
            this.contactListBtn.UseVisualStyleBackColor = false;
            // 
            // filterContactsBtn
            // 
            this.filterContactsBtn.BackColor = System.Drawing.Color.Transparent;
            this.filterContactsBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.filterContactsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.filterContactsBtn.BorderRadius1 = 10;
            this.filterContactsBtn.BorderSize1 = 0;
            this.filterContactsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterContactsBtn.EllipseColor = System.Drawing.Color.White;
            this.filterContactsBtn.FlatAppearance.BorderSize = 0;
            this.filterContactsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterContactsBtn.ForeColor = System.Drawing.Color.White;
            this.filterContactsBtn.Image = global::ChatApplication.Properties.Resources.icons8_align_left_19;
            this.filterContactsBtn.Location = new System.Drawing.Point(333, 15);
            this.filterContactsBtn.Name = "filterContactsBtn";
            this.filterContactsBtn.Size = new System.Drawing.Size(44, 45);
            this.filterContactsBtn.SlowMotionInterval = 5;
            this.filterContactsBtn.TabIndex = 1;
            this.filterContactsBtn.TextColor = System.Drawing.Color.White;
            this.filterContactsBtn.UseVisualStyleBackColor = false;
            // 
            // chatLB
            // 
            this.chatLB.AutoSize = true;
            this.chatLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.chatLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLB.Location = new System.Drawing.Point(15, 15);
            this.chatLB.Name = "chatLB";
            this.chatLB.Size = new System.Drawing.Size(67, 30);
            this.chatLB.TabIndex = 0;
            this.chatLB.Text = "Chats";
            this.chatLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // callsPage
            // 
            this.callsPage.Location = new System.Drawing.Point(4, 14);
            this.callsPage.Name = "callsPage";
            this.callsPage.Size = new System.Drawing.Size(392, 582);
            this.callsPage.TabIndex = 2;
            this.callsPage.UseVisualStyleBackColor = true;
            // 
            // StatusPage
            // 
            this.StatusPage.Location = new System.Drawing.Point(4, 14);
            this.StatusPage.Name = "StatusPage";
            this.StatusPage.Padding = new System.Windows.Forms.Padding(3);
            this.StatusPage.Size = new System.Drawing.Size(392, 582);
            this.StatusPage.TabIndex = 1;
            this.StatusPage.UseVisualStyleBackColor = true;
            // 
            // starredMessagePage
            // 
            this.starredMessagePage.Location = new System.Drawing.Point(4, 14);
            this.starredMessagePage.Name = "starredMessagePage";
            this.starredMessagePage.Size = new System.Drawing.Size(392, 582);
            this.starredMessagePage.TabIndex = 3;
            this.starredMessagePage.UseVisualStyleBackColor = true;
            // 
            // archivedPage
            // 
            this.archivedPage.Controls.Add(this.ArchivedContactsPanel);
            this.archivedPage.Controls.Add(this.panel2);
            this.archivedPage.Location = new System.Drawing.Point(4, 14);
            this.archivedPage.Name = "archivedPage";
            this.archivedPage.Size = new System.Drawing.Size(392, 582);
            this.archivedPage.TabIndex = 4;
            this.archivedPage.UseVisualStyleBackColor = true;
            // 
            // ArchivedContactsPanel
            // 
            this.ArchivedContactsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivedContactsPanel.Location = new System.Drawing.Point(0, 88);
            this.ArchivedContactsPanel.Name = "ArchivedContactsPanel";
            this.ArchivedContactsPanel.Size = new System.Drawing.Size(392, 494);
            this.ArchivedContactsPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(392, 88);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archived";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.chatTabpage);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Controls.Add(this.defaultPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ItemSize = new System.Drawing.Size(10, 10);
            this.mainTabControl.Location = new System.Drawing.Point(483, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(501, 600);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 2;
            // 
            // chatTabpage
            // 
            this.chatTabpage.Controls.Add(this.chatTabPageMainPanel);
            this.chatTabpage.Location = new System.Drawing.Point(4, 14);
            this.chatTabpage.Name = "chatTabpage";
            this.chatTabpage.Size = new System.Drawing.Size(493, 582);
            this.chatTabpage.TabIndex = 0;
            this.chatTabpage.UseVisualStyleBackColor = true;
            // 
            // chatTabPageMainPanel
            // 
            this.chatTabPageMainPanel.BackColor = System.Drawing.Color.White;
            this.chatTabPageMainPanel.Controls.Add(this.messageShowP);
            this.chatTabPageMainPanel.Controls.Add(this.chatPageTitleU);
            this.chatTabPageMainPanel.Controls.Add(this.messageTextBoxPanel);
            this.chatTabPageMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTabPageMainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.chatTabPageMainPanel.Location = new System.Drawing.Point(0, 0);
            this.chatTabPageMainPanel.Name = "chatTabPageMainPanel";
            this.chatTabPageMainPanel.Size = new System.Drawing.Size(493, 582);
            this.chatTabPageMainPanel.TabIndex = 2;
            // 
            // messageShowP
            // 
            this.messageShowP.AutoScroll = true;
            this.messageShowP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.messageShowP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.messageShowP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageShowP.Location = new System.Drawing.Point(0, 75);
            this.messageShowP.MaximumSize = new System.Drawing.Size(0, 900);
            this.messageShowP.Name = "messageShowP";
            this.messageShowP.Size = new System.Drawing.Size(493, 433);
            this.messageShowP.TabIndex = 5;
            this.messageShowP.Scroll += new System.Windows.Forms.ScrollEventHandler(this.messageShowPScroll);
            // 
            // chatPageTitleU
            // 
            this.chatPageTitleU.BackColor = System.Drawing.Color.White;
            this.chatPageTitleU.ConatctName = "label1";
            this.chatPageTitleU.Contact = null;
            this.chatPageTitleU.ContactImagePath = null;
            this.chatPageTitleU.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatPageTitleU.Group = null;
            this.chatPageTitleU.groupinfoText = "Offline";
            this.chatPageTitleU.IsArchived = false;
            this.chatPageTitleU.IsGroup = false;
            this.chatPageTitleU.IsOnline = false;
            this.chatPageTitleU.Location = new System.Drawing.Point(0, 0);
            this.chatPageTitleU.Margin = new System.Windows.Forms.Padding(4);
            this.chatPageTitleU.MinimumSize = new System.Drawing.Size(0, 70);
            this.chatPageTitleU.Name = "chatPageTitleU";
            this.chatPageTitleU.Padding = new System.Windows.Forms.Padding(6);
            this.chatPageTitleU.Size = new System.Drawing.Size(493, 75);
            this.chatPageTitleU.TabIndex = 6;
            // 
            // messageTextBoxPanel
            // 
            this.messageTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.messageTextBoxPanel.Controls.Add(this.messageTB);
            this.messageTextBoxPanel.Controls.Add(this.panel1);
            this.messageTextBoxPanel.Controls.Add(this.sentBtnP);
            this.messageTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageTextBoxPanel.Location = new System.Drawing.Point(0, 508);
            this.messageTextBoxPanel.Name = "messageTextBoxPanel";
            this.messageTextBoxPanel.Padding = new System.Windows.Forms.Padding(5);
            this.messageTextBoxPanel.Size = new System.Drawing.Size(493, 74);
            this.messageTextBoxPanel.TabIndex = 2;
            // 
            // messageTB
            // 
            this.messageTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTB.Location = new System.Drawing.Point(71, 5);
            this.messageTB.Name = "messageTB";
            this.messageTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.messageTB.Size = new System.Drawing.Size(320, 64);
            this.messageTB.TabIndex = 2;
            this.messageTB.Text = "";
            this.messageTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTBKeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.attachmentBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(66, 64);
            this.panel1.TabIndex = 3;
            // 
            // attachmentBtn
            // 
            this.attachmentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.attachmentBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.attachmentBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.attachmentBtn.BorderRadius1 = 10;
            this.attachmentBtn.BorderSize1 = 0;
            this.attachmentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachmentBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.attachmentBtn.FlatAppearance.BorderSize = 0;
            this.attachmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachmentBtn.ForeColor = System.Drawing.Color.White;
            this.attachmentBtn.Image = global::ChatApplication.Properties.Resources.paper_clip__3_;
            this.attachmentBtn.Location = new System.Drawing.Point(10, 10);
            this.attachmentBtn.Name = "attachmentBtn";
            this.attachmentBtn.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.attachmentBtn.Size = new System.Drawing.Size(46, 44);
            this.attachmentBtn.SlowMotionInterval = 5;
            this.attachmentBtn.TabIndex = 3;
            this.attachmentBtn.TextColor = System.Drawing.Color.White;
            this.attachmentBtn.UseVisualStyleBackColor = false;
            this.attachmentBtn.Click += new System.EventHandler(this.attachmentBtnClick);
            // 
            // sentBtnP
            // 
            this.sentBtnP.Controls.Add(this.sentBtn);
            this.sentBtnP.Dock = System.Windows.Forms.DockStyle.Right;
            this.sentBtnP.Location = new System.Drawing.Point(391, 5);
            this.sentBtnP.Name = "sentBtnP";
            this.sentBtnP.Padding = new System.Windows.Forms.Padding(10);
            this.sentBtnP.Size = new System.Drawing.Size(97, 64);
            this.sentBtnP.TabIndex = 1;
            // 
            // sentBtn
            // 
            this.sentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sentBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sentBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sentBtn.BorderRadius1 = 10;
            this.sentBtn.BorderSize1 = 0;
            this.sentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentBtn.EllipseColor = System.Drawing.Color.Cyan;
            this.sentBtn.FlatAppearance.BorderSize = 0;
            this.sentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.sentBtn.Image = global::ChatApplication.Properties.Resources.SentIconBlack;
            this.sentBtn.Location = new System.Drawing.Point(10, 10);
            this.sentBtn.Name = "sentBtn";
            this.sentBtn.Size = new System.Drawing.Size(77, 44);
            this.sentBtn.SlowMotionInterval = 12;
            this.sentBtn.TabIndex = 0;
            this.sentBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.sentBtn.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(493, 582);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 14);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(493, 582);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 14);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(493, 582);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // defaultPage
            // 
            this.defaultPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.defaultPage.BackgroundImage = global::ChatApplication.Properties.Resources.Icon_LightGreen;
            this.defaultPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.defaultPage.Location = new System.Drawing.Point(4, 14);
            this.defaultPage.Name = "defaultPage";
            this.defaultPage.Size = new System.Drawing.Size(493, 582);
            this.defaultPage.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mainTabControl);
            this.panel5.Controls.Add(this.menuTabControl);
            this.panel5.Controls.Add(this.menuControl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(984, 600);
            this.panel5.TabIndex = 3;
            // 
            // menuControl
            // 
            this.menuControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.menuControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.Margin = new System.Windows.Forms.Padding(2);
            this.menuControl.Name = "menuControl";
            this.menuControl.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuControl.Size = new System.Drawing.Size(83, 600);
            this.menuControl.TabIndex = 3;
            // 
            // customTooltip1
            // 
            this.customTooltip1.OwnerDraw = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 591);
            this.Name = "MainForm";
            this.Text = "Messager";
            this.menuTabControl.ResumeLayout(false);
            this.chatPage.ResumeLayout(false);
            this.chatPageSearchBoxPanel.ResumeLayout(false);
            this.chatPageTopPanel.ResumeLayout(false);
            this.chatPageTopPanel.PerformLayout();
            this.archivedPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.chatTabpage.ResumeLayout(false);
            this.chatTabPageMainPanel.ResumeLayout(false);
            this.messageTextBoxPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.sentBtnP.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage chatPage;
        private System.Windows.Forms.TabPage callsPage;
        private System.Windows.Forms.TabPage StatusPage;
        private System.Windows.Forms.TabPage starredMessagePage;
        private System.Windows.Forms.TabPage archivedPage;
        private System.Windows.Forms.Panel chatPageSearchBoxPanel;
        private System.Windows.Forms.Panel chatPageTopPanel;
        private EllipseButton filterContactsBtn;
        private System.Windows.Forms.Label chatLB;
        private EllipseButton contactListBtn;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage chatTabpage;
        private System.Windows.Forms.Panel chatTabPageMainPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage defaultPage;
        private System.Windows.Forms.Panel panel5;

        private CustomTooltip customTooltip1;
        private CustomSearchBox chatPageSearchBox;
        private System.Windows.Forms.Panel messageTextBoxPanel;
        private System.Windows.Forms.Panel alreadyMessagedContactsPanel;
        private System.Windows.Forms.Panel messageShowP;
        private System.Windows.Forms.RichTextBox messageTB;
        private System.Windows.Forms.Panel sentBtnP;
        private EllipseButton sentBtn;
        private EllipseButton attachmentBtn;
        private System.Windows.Forms.Panel panel1;
        private EllipseButton refreshBtn;
        private ChatPageTitleU chatPageTitleU;
        private System.Windows.Forms.Panel ArchivedContactsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private MenuControl menuControl;
    }
}