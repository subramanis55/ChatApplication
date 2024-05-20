namespace ChatApplication
{
    partial class FilterChatByF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupsBtn = new ChatApplication.EllipseButton();
            this.contactBtn = new ChatApplication.EllipseButton();
            this.allBtn = new ChatApplication.EllipseButton();
            this.unreadBtn = new ChatApplication.EllipseButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 15);
            this.panel1.Size = new System.Drawing.Size(182, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(169)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Chats By";
            // 
            // groupsBtn
            // 
            this.groupsBtn.BackColor = System.Drawing.Color.Transparent;
            this.groupsBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.groupsBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.groupsBtn.BorderRadius1 = 10;
            this.groupsBtn.BorderSize1 = 0;
            this.groupsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupsBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupsBtn.FlatAppearance.BorderSize = 0;
            this.groupsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.groupsBtn.Image = global::ChatApplication.Properties.Resources.user;
            this.groupsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsBtn.Location = new System.Drawing.Point(0, 122);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupsBtn.Size = new System.Drawing.Size(182, 40);
            this.groupsBtn.SlowMotionInterval = 5;
            this.groupsBtn.TabIndex = 4;
            this.groupsBtn.Text = "   Groups";
            this.groupsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.groupsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.groupsBtn.UseVisualStyleBackColor = false;
            this.groupsBtn.Click += new System.EventHandler(this.ClickFilterContactsBy);
            this.groupsBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.groupsBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // contactBtn
            // 
            this.contactBtn.BackColor = System.Drawing.Color.Transparent;
            this.contactBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.contactBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.contactBtn.BorderRadius1 = 10;
            this.contactBtn.BorderSize1 = 0;
            this.contactBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.contactBtn.FlatAppearance.BorderSize = 0;
            this.contactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.contactBtn.Image = global::ChatApplication.Properties.Resources.icons8_contact_26;
            this.contactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactBtn.Location = new System.Drawing.Point(0, 88);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.contactBtn.Size = new System.Drawing.Size(182, 34);
            this.contactBtn.SlowMotionInterval = 5;
            this.contactBtn.TabIndex = 2;
            this.contactBtn.Text = "   Contact";
            this.contactBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.contactBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contactBtn.UseVisualStyleBackColor = false;
            this.contactBtn.Click += new System.EventHandler(this.ClickFilterContactsBy);
            this.contactBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.contactBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.Transparent;
            this.allBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.allBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.allBtn.BorderRadius1 = 10;
            this.allBtn.BorderSize1 = 0;
            this.allBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.allBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.allBtn.FlatAppearance.BorderSize = 0;
            this.allBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.allBtn.Image = global::ChatApplication.Properties.Resources.icons8_book_22;
            this.allBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allBtn.Location = new System.Drawing.Point(0, 48);
            this.allBtn.Name = "allBtn";
            this.allBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.allBtn.Size = new System.Drawing.Size(182, 40);
            this.allBtn.SlowMotionInterval = 5;
            this.allBtn.TabIndex = 5;
            this.allBtn.Text = "    All";
            this.allBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.allBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.ClickFilterContactsBy);
            this.allBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.allBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // unreadBtn
            // 
            this.unreadBtn.BackColor = System.Drawing.Color.Transparent;
            this.unreadBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.unreadBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.unreadBtn.BorderRadius1 = 10;
            this.unreadBtn.BorderSize1 = 0;
            this.unreadBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.unreadBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.unreadBtn.FlatAppearance.BorderSize = 0;
            this.unreadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unreadBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unreadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.unreadBtn.Image = global::ChatApplication.Properties.Resources.chat;
            this.unreadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unreadBtn.Location = new System.Drawing.Point(0, 162);
            this.unreadBtn.Name = "unreadBtn";
            this.unreadBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.unreadBtn.Size = new System.Drawing.Size(182, 40);
            this.unreadBtn.SlowMotionInterval = 5;
            this.unreadBtn.TabIndex = 6;
            this.unreadBtn.Text = "   Unread";
            this.unreadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unreadBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.unreadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.unreadBtn.UseVisualStyleBackColor = false;
            // 
            // FilterChatByF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(182, 213);
            this.Controls.Add(this.unreadBtn);
            this.Controls.Add(this.groupsBtn);
            this.Controls.Add(this.contactBtn);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterChatByF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Panel panel1;
        private EllipseButton groupsBtn;
        private EllipseButton contactBtn;
        private System.Windows.Forms.Label label1;
        private EllipseButton allBtn;
        private EllipseButton unreadBtn;
    }
}
