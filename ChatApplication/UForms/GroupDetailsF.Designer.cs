namespace ChatApplication.UForms
{
    partial class GroupDetailsF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupDetailsF));
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.overviewPage = new System.Windows.Forms.TabPage();
            this.adminNameLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupLeaveBtn = new ChatApplication.EllipseButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupnameErrorLB = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupNameTB = new ChatApplication.CustomSearchBox();
            this.groupNameTBEditBtn = new ChatApplication.EllipseButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dpPictureU = new ChatApplication.DpPictureU();
            this.panel13 = new System.Windows.Forms.Panel();
            this.overviewPageTitleLabel = new System.Windows.Forms.Label();
            this.groupMemberPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupMembersShowP = new System.Windows.Forms.Panel();
            this.addOrRemoveChoiceP = new System.Windows.Forms.Panel();
            this.RemoveGroupMemberBtn = new ChatApplication.EllipseButton();
            this.addGroupMemberBtn = new ChatApplication.EllipseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new ChatApplication.CustomSearchBox();
            this.addGroupMemberNextP = new System.Windows.Forms.Panel();
            this.cancelBtn = new ChatApplication.EllipseButton();
            this.addGroupMemberNextBtn = new ChatApplication.EllipseButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleLB = new System.Windows.Forms.Label();
            this.groupMainTabControl = new System.Windows.Forms.TabControl();
            this.groupMenuControl = new ChatApplication.UControl.GroupMenuControl();
            this.overviewPage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupMemberPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.addOrRemoveChoiceP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addGroupMemberNextP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupMainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // overviewPage
            // 
            this.overviewPage.BackColor = System.Drawing.Color.White;
            this.overviewPage.Controls.Add(this.adminNameLabel);
            this.overviewPage.Controls.Add(this.panel5);
            this.overviewPage.Controls.Add(this.panel11);
            this.overviewPage.Controls.Add(this.panel12);
            this.overviewPage.Controls.Add(this.panel13);
            this.overviewPage.Location = new System.Drawing.Point(4, 14);
            this.overviewPage.Name = "overviewPage";
            this.overviewPage.Size = new System.Drawing.Size(281, 431);
            this.overviewPage.TabIndex = 3;
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNameLabel.Location = new System.Drawing.Point(20, 300);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(101, 20);
            this.adminNameLabel.TabIndex = 5;
            this.adminNameLabel.Text = "AdminName  ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupLeaveBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 66);
            this.panel5.TabIndex = 4;
            // 
            // groupLeaveBtn
            // 
            this.groupLeaveBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.groupLeaveBtn.BackgroudColor = System.Drawing.Color.Gainsboro;
            this.groupLeaveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.groupLeaveBtn.BorderRadius1 = 8;
            this.groupLeaveBtn.BorderSize1 = 0;
            this.groupLeaveBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupLeaveBtn.FlatAppearance.BorderSize = 0;
            this.groupLeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupLeaveBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLeaveBtn.ForeColor = System.Drawing.Color.Red;
            this.groupLeaveBtn.Location = new System.Drawing.Point(61, 14);
            this.groupLeaveBtn.Name = "groupLeaveBtn";
            this.groupLeaveBtn.Size = new System.Drawing.Size(152, 35);
            this.groupLeaveBtn.SlowMotionInterval = 5;
            this.groupLeaveBtn.TabIndex = 3;
            this.groupLeaveBtn.Text = "Exit from Group";
            this.groupLeaveBtn.TextColor = System.Drawing.Color.Red;
            this.groupLeaveBtn.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupnameErrorLB);
            this.panel11.Controls.Add(this.panel6);
            this.panel11.Controls.Add(this.groupNameTBEditBtn);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 199);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel11.Size = new System.Drawing.Size(281, 98);
            this.panel11.TabIndex = 2;
            // 
            // groupnameErrorLB
            // 
            this.groupnameErrorLB.AutoSize = true;
            this.groupnameErrorLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupnameErrorLB.ForeColor = System.Drawing.Color.Red;
            this.groupnameErrorLB.Location = new System.Drawing.Point(21, 67);
            this.groupnameErrorLB.Name = "groupnameErrorLB";
            this.groupnameErrorLB.Size = new System.Drawing.Size(38, 17);
            this.groupnameErrorLB.TabIndex = 14;
            this.groupnameErrorLB.Text = "Error";
            this.groupnameErrorLB.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupNameTB);
            this.panel6.Location = new System.Drawing.Point(3, 17);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(232, 47);
            this.panel6.TabIndex = 4;
            // 
            // groupNameTB
            // 
            this.groupNameTB.BackColor = System.Drawing.Color.White;
            this.groupNameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupNameTB.BorderSize = 4;
            this.groupNameTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupNameTB.Enabled = false;
            this.groupNameTB.IsPlaceholder = true;
            this.groupNameTB.IsSearchIconVisible = false;
            this.groupNameTB.IsUnderLine = true;
            this.groupNameTB.Location = new System.Drawing.Point(7, 0);
            this.groupNameTB.Multiline = false;
            this.groupNameTB.Name = "groupNameTB";
            this.groupNameTB.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.groupNameTB.PlaceholderText = "";
            this.groupNameTB.ReadOnly = false;
            this.groupNameTB.Size = new System.Drawing.Size(226, 47);
            this.groupNameTB.TabIndex = 2;
            this.groupNameTB.TabStop = false;
            // 
            // groupNameTBEditBtn
            // 
            this.groupNameTBEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.groupNameTBEditBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.groupNameTBEditBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.groupNameTBEditBtn.BorderRadius1 = 10;
            this.groupNameTBEditBtn.BorderSize1 = 0;
            this.groupNameTBEditBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupNameTBEditBtn.FlatAppearance.BorderSize = 0;
            this.groupNameTBEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupNameTBEditBtn.ForeColor = System.Drawing.Color.Transparent;
            this.groupNameTBEditBtn.Image = global::ChatApplication.Properties.Resources.edit_24_Black1;
            this.groupNameTBEditBtn.Location = new System.Drawing.Point(241, 20);
            this.groupNameTBEditBtn.Name = "groupNameTBEditBtn";
            this.groupNameTBEditBtn.Size = new System.Drawing.Size(32, 30);
            this.groupNameTBEditBtn.SlowMotionInterval = 5;
            this.groupNameTBEditBtn.TabIndex = 3;
            this.groupNameTBEditBtn.TextColor = System.Drawing.Color.Transparent;
            this.groupNameTBEditBtn.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.dpPictureU);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 59);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(281, 140);
            this.panel12.TabIndex = 0;
            // 
            // dpPictureU
            // 
            this.dpPictureU.BackColor = System.Drawing.Color.Transparent;
            this.dpPictureU.DpPicturPath = "";
            this.dpPictureU.EditBtnImage = global::ChatApplication.Properties.Resources.icons8_edit_18;
            this.dpPictureU.EditBtnVisible = false;
            this.dpPictureU.Image = ((System.Drawing.Image)(resources.GetObject("dpPictureU.Image")));
            this.dpPictureU.Location = new System.Drawing.Point(73, 15);
            this.dpPictureU.Margin = new System.Windows.Forms.Padding(2);
            this.dpPictureU.Name = "dpPictureU";
            this.dpPictureU.Size = new System.Drawing.Size(114, 106);
            this.dpPictureU.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.overviewPageTitleLabel);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(20, 0, 0, 15);
            this.panel13.Size = new System.Drawing.Size(281, 59);
            this.panel13.TabIndex = 1;
            // 
            // overviewPageTitleLabel
            // 
            this.overviewPageTitleLabel.AutoSize = true;
            this.overviewPageTitleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.overviewPageTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewPageTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.overviewPageTitleLabel.Name = "overviewPageTitleLabel";
            this.overviewPageTitleLabel.Size = new System.Drawing.Size(89, 24);
            this.overviewPageTitleLabel.TabIndex = 0;
            this.overviewPageTitleLabel.Text = "Overview";
            // 
            // groupMemberPage
            // 
            this.groupMemberPage.BackColor = System.Drawing.Color.White;
            this.groupMemberPage.Controls.Add(this.panel4);
            this.groupMemberPage.Location = new System.Drawing.Point(4, 14);
            this.groupMemberPage.Name = "groupMemberPage";
            this.groupMemberPage.Size = new System.Drawing.Size(281, 431);
            this.groupMemberPage.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.groupMembersShowP);
            this.panel4.Controls.Add(this.addOrRemoveChoiceP);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.addGroupMemberNextP);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 431);
            this.panel4.TabIndex = 8;
            // 
            // groupMembersShowP
            // 
            this.groupMembersShowP.AutoScroll = true;
            this.groupMembersShowP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMembersShowP.Location = new System.Drawing.Point(0, 192);
            this.groupMembersShowP.Name = "groupMembersShowP";
            this.groupMembersShowP.Padding = new System.Windows.Forms.Padding(4);
            this.groupMembersShowP.Size = new System.Drawing.Size(281, 201);
            this.groupMembersShowP.TabIndex = 1;
            // 
            // addOrRemoveChoiceP
            // 
            this.addOrRemoveChoiceP.Controls.Add(this.RemoveGroupMemberBtn);
            this.addOrRemoveChoiceP.Controls.Add(this.addGroupMemberBtn);
            this.addOrRemoveChoiceP.Dock = System.Windows.Forms.DockStyle.Top;
            this.addOrRemoveChoiceP.Location = new System.Drawing.Point(0, 119);
            this.addOrRemoveChoiceP.Name = "addOrRemoveChoiceP";
            this.addOrRemoveChoiceP.Padding = new System.Windows.Forms.Padding(15, 0, 15, 3);
            this.addOrRemoveChoiceP.Size = new System.Drawing.Size(281, 73);
            this.addOrRemoveChoiceP.TabIndex = 7;
            // 
            // RemoveGroupMemberBtn
            // 
            this.RemoveGroupMemberBtn.BackColor = System.Drawing.Color.Silver;
            this.RemoveGroupMemberBtn.BackgroudColor = System.Drawing.Color.Silver;
            this.RemoveGroupMemberBtn.BorderColor = System.Drawing.Color.Black;
            this.RemoveGroupMemberBtn.BorderRadius1 = 10;
            this.RemoveGroupMemberBtn.BorderSize1 = 0;
            this.RemoveGroupMemberBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveGroupMemberBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.RemoveGroupMemberBtn.FlatAppearance.BorderSize = 0;
            this.RemoveGroupMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.RemoveGroupMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveGroupMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveGroupMemberBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveGroupMemberBtn.Image = global::ChatApplication.Properties.Resources.contact__4_;
            this.RemoveGroupMemberBtn.Location = new System.Drawing.Point(15, 37);
            this.RemoveGroupMemberBtn.Name = "RemoveGroupMemberBtn";
            this.RemoveGroupMemberBtn.Size = new System.Drawing.Size(251, 33);
            this.RemoveGroupMemberBtn.SlowMotionInterval = 5;
            this.RemoveGroupMemberBtn.TabIndex = 7;
            this.RemoveGroupMemberBtn.Text = "     Remove Member";
            this.RemoveGroupMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveGroupMemberBtn.TextColor = System.Drawing.Color.White;
            this.RemoveGroupMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveGroupMemberBtn.UseCompatibleTextRendering = true;
            this.RemoveGroupMemberBtn.UseVisualStyleBackColor = false;
            // 
            // addGroupMemberBtn
            // 
            this.addGroupMemberBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.addGroupMemberBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.addGroupMemberBtn.BorderColor = System.Drawing.Color.Black;
            this.addGroupMemberBtn.BorderRadius1 = 10;
            this.addGroupMemberBtn.BorderSize1 = 0;
            this.addGroupMemberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGroupMemberBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addGroupMemberBtn.FlatAppearance.BorderSize = 0;
            this.addGroupMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupMemberBtn.ForeColor = System.Drawing.Color.White;
            this.addGroupMemberBtn.Image = global::ChatApplication.Properties.Resources.user_avatar__2_;
            this.addGroupMemberBtn.Location = new System.Drawing.Point(15, 0);
            this.addGroupMemberBtn.Name = "addGroupMemberBtn";
            this.addGroupMemberBtn.Size = new System.Drawing.Size(251, 33);
            this.addGroupMemberBtn.SlowMotionInterval = 5;
            this.addGroupMemberBtn.TabIndex = 6;
            this.addGroupMemberBtn.Text = "      Add Member";
            this.addGroupMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGroupMemberBtn.TextColor = System.Drawing.Color.White;
            this.addGroupMemberBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addGroupMemberBtn.UseCompatibleTextRendering = true;
            this.addGroupMemberBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel1.Size = new System.Drawing.Size(281, 60);
            this.panel1.TabIndex = 8;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.searchBox.BorderSize = 4;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox.IsPlaceholder = true;
            this.searchBox.IsSearchIconVisible = false;
            this.searchBox.IsUnderLine = true;
            this.searchBox.Location = new System.Drawing.Point(15, 5);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.searchBox.PlaceholderText = "Search Name";
            this.searchBox.ReadOnly = false;
            this.searchBox.Size = new System.Drawing.Size(251, 50);
            this.searchBox.TabIndex = 2;
            this.searchBox.TabStop = false;
            // 
            // addGroupMemberNextP
            // 
            this.addGroupMemberNextP.Controls.Add(this.cancelBtn);
            this.addGroupMemberNextP.Controls.Add(this.addGroupMemberNextBtn);
            this.addGroupMemberNextP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addGroupMemberNextP.Location = new System.Drawing.Point(0, 393);
            this.addGroupMemberNextP.Name = "addGroupMemberNextP";
            this.addGroupMemberNextP.Padding = new System.Windows.Forms.Padding(4);
            this.addGroupMemberNextP.Size = new System.Drawing.Size(281, 38);
            this.addGroupMemberNextP.TabIndex = 5;
            this.addGroupMemberNextP.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn.BackgroudColor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn.BorderColor = System.Drawing.Color.Black;
            this.cancelBtn.BorderRadius1 = 10;
            this.cancelBtn.BorderSize1 = 0;
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancelBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(126, 30);
            this.cancelBtn.SlowMotionInterval = 5;
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // addGroupMemberNextBtn
            // 
            this.addGroupMemberNextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.addGroupMemberNextBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.addGroupMemberNextBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addGroupMemberNextBtn.BorderRadius1 = 10;
            this.addGroupMemberNextBtn.BorderSize1 = 0;
            this.addGroupMemberNextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addGroupMemberNextBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addGroupMemberNextBtn.FlatAppearance.BorderSize = 0;
            this.addGroupMemberNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupMemberNextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupMemberNextBtn.ForeColor = System.Drawing.Color.White;
            this.addGroupMemberNextBtn.Location = new System.Drawing.Point(150, 4);
            this.addGroupMemberNextBtn.Name = "addGroupMemberNextBtn";
            this.addGroupMemberNextBtn.Size = new System.Drawing.Size(127, 30);
            this.addGroupMemberNextBtn.SlowMotionInterval = 5;
            this.addGroupMemberNextBtn.TabIndex = 4;
            this.addGroupMemberNextBtn.Text = "Next";
            this.addGroupMemberNextBtn.TextColor = System.Drawing.Color.White;
            this.addGroupMemberNextBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.titleLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 15);
            this.panel2.Size = new System.Drawing.Size(281, 59);
            this.panel2.TabIndex = 3;
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.Location = new System.Drawing.Point(20, 20);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(148, 24);
            this.titleLB.TabIndex = 0;
            this.titleLB.Text = "Group Members";
            // 
            // groupMainTabControl
            // 
            this.groupMainTabControl.Controls.Add(this.groupMemberPage);
            this.groupMainTabControl.Controls.Add(this.overviewPage);
            this.groupMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMainTabControl.ItemSize = new System.Drawing.Size(10, 10);
            this.groupMainTabControl.Location = new System.Drawing.Point(97, 0);
            this.groupMainTabControl.Name = "groupMainTabControl";
            this.groupMainTabControl.Padding = new System.Drawing.Point(0, 4);
            this.groupMainTabControl.SelectedIndex = 0;
            this.groupMainTabControl.Size = new System.Drawing.Size(289, 449);
            this.groupMainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.groupMainTabControl.TabIndex = 9;
            // 
            // groupMenuControl
            // 
            this.groupMenuControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupMenuControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupMenuControl.Location = new System.Drawing.Point(0, 0);
            this.groupMenuControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMenuControl.Name = "groupMenuControl";
            this.groupMenuControl.Size = new System.Drawing.Size(97, 449);
            this.groupMenuControl.TabIndex = 4;
            // 
            // GroupDetailsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 449);
            this.Controls.Add(this.groupMainTabControl);
            this.Controls.Add(this.groupMenuControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupDetailsF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GroupMemberF";
            this.overviewPage.ResumeLayout(false);
            this.overviewPage.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.groupMemberPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.addOrRemoveChoiceP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.addGroupMemberNextP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupMainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.TabControl groupMainTabControl;
        private System.Windows.Forms.TabPage groupMemberPage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel groupMembersShowP;
        private System.Windows.Forms.Panel addGroupMemberNextP;
        private EllipseButton cancelBtn;
        private EllipseButton addGroupMemberNextBtn;
        private System.Windows.Forms.Panel addOrRemoveChoiceP;
        private EllipseButton RemoveGroupMemberBtn;
        private EllipseButton addGroupMemberBtn;
        private CustomSearchBox searchBox;
        private System.Windows.Forms.TabPage overviewPage;
        private System.Windows.Forms.Panel panel11;
        private EllipseButton groupNameTBEditBtn;
        private CustomSearchBox groupNameTB;
        private System.Windows.Forms.Panel panel12;
        private DpPictureU dpPictureU;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label overviewPageTitleLabel;
        private EllipseButton groupLeaveBtn;
        private UControl.GroupMenuControl groupMenuControl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label adminNameLabel;
        private System.Windows.Forms.Label groupnameErrorLB;
    }
}