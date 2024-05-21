namespace ChatApplication
{
    partial class ContactListU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headingLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBox = new ChatApplication.CustomSearchBox();
            this.contactLoadP = new System.Windows.Forms.Panel();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.groupCreateNextBtn = new ChatApplication.EllipseButton();
            this.groupCreateNextP = new System.Windows.Forms.Panel();
            this.cancelBtn = new ChatApplication.EllipseButton();
            this.addGroupSimpleU = new ChatApplication.AddGroupSimpleU();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupCreateNextP.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headingLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.panel1.Size = new System.Drawing.Size(296, 48);
            this.panel1.TabIndex = 0;
            // 
            // headingLB
            // 
            this.headingLB.AutoSize = true;
            this.headingLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.headingLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLB.Location = new System.Drawing.Point(15, 15);
            this.headingLB.Name = "headingLB";
            this.headingLB.Size = new System.Drawing.Size(102, 25);
            this.headingLB.TabIndex = 0;
            this.headingLB.Text = "New Chat";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(296, 56);
            this.panel2.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.searchBox.BorderSize = 4;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox.IsSearchIconVisible = false;
            this.searchBox.IsUnderLine = true;
            this.searchBox.Location = new System.Drawing.Point(6, 5);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Padding = new System.Windows.Forms.Padding(15, 7, 7, 7);
            this.searchBox.PlaceholderText = "Search Name";
            this.searchBox.ReadOnly = false;
            this.searchBox.Size = new System.Drawing.Size(284, 45);
            this.searchBox.TabIndex = 1;
            // 
            // contactLoadP
            // 
            this.contactLoadP.AutoScroll = true;
            this.contactLoadP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactLoadP.Location = new System.Drawing.Point(0, 142);
            this.contactLoadP.Name = "contactLoadP";
            this.contactLoadP.Padding = new System.Windows.Forms.Padding(4);
            this.contactLoadP.Size = new System.Drawing.Size(296, 229);
            this.contactLoadP.TabIndex = 2;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 10;
            this.ellipseControl1.TargetControl = this;
            // 
            // groupCreateNextBtn
            // 
            this.groupCreateNextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.groupCreateNextBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.groupCreateNextBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.groupCreateNextBtn.BorderRadius1 = 10;
            this.groupCreateNextBtn.BorderSize1 = 0;
            this.groupCreateNextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupCreateNextBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupCreateNextBtn.FlatAppearance.BorderSize = 0;
            this.groupCreateNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCreateNextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCreateNextBtn.ForeColor = System.Drawing.Color.White;
            this.groupCreateNextBtn.Location = new System.Drawing.Point(160, 4);
            this.groupCreateNextBtn.Name = "groupCreateNextBtn";
            this.groupCreateNextBtn.Size = new System.Drawing.Size(132, 30);
            this.groupCreateNextBtn.SlowMotionInterval = 5;
            this.groupCreateNextBtn.TabIndex = 4;
            this.groupCreateNextBtn.Text = "Next";
            this.groupCreateNextBtn.TextColor = System.Drawing.Color.White;
            this.groupCreateNextBtn.UseVisualStyleBackColor = false;
            // 
            // groupCreateNextP
            // 
            this.groupCreateNextP.Controls.Add(this.cancelBtn);
            this.groupCreateNextP.Controls.Add(this.groupCreateNextBtn);
            this.groupCreateNextP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupCreateNextP.Location = new System.Drawing.Point(0, 371);
            this.groupCreateNextP.Name = "groupCreateNextP";
            this.groupCreateNextP.Padding = new System.Windows.Forms.Padding(4);
            this.groupCreateNextP.Size = new System.Drawing.Size(296, 38);
            this.groupCreateNextP.TabIndex = 4;
            this.groupCreateNextP.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.BackgroudColor = System.Drawing.Color.White;
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
            this.cancelBtn.Size = new System.Drawing.Size(135, 30);
            this.cancelBtn.SlowMotionInterval = 5;
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // addGroupSimpleU
            // 
            this.addGroupSimpleU.BackColor = System.Drawing.Color.Transparent;
            this.addGroupSimpleU.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGroupSimpleU.LabelText = "New Group";
            this.addGroupSimpleU.Location = new System.Drawing.Point(0, 104);
            this.addGroupSimpleU.Margin = new System.Windows.Forms.Padding(4);
            this.addGroupSimpleU.Name = "addGroupSimpleU";
            this.addGroupSimpleU.Padding = new System.Windows.Forms.Padding(20, 0, 15, 0);
            this.addGroupSimpleU.Size = new System.Drawing.Size(296, 38);
            this.addGroupSimpleU.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.contactLoadP);
            this.panel4.Controls.Add(this.groupCreateNextP);
            this.panel4.Controls.Add(this.addGroupSimpleU);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 409);
            this.panel4.TabIndex = 5;
            // 
            // ContactListU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel4);
            this.Name = "ContactListU";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(300, 413);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupCreateNextP.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headingLB;
        private System.Windows.Forms.Panel contactLoadP;
        private CustomSearchBox searchBox;
        private EllipseButton groupCreateNextBtn;
        private System.Windows.Forms.Panel groupCreateNextP;
        private EllipseButton cancelBtn;
        private AddGroupSimpleU addGroupSimpleU;
        private System.Windows.Forms.Panel panel4;
    }
}
