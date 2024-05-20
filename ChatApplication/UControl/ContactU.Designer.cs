namespace ChatApplication
{
    partial class ContactU
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
            this.mainP = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contactNameLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastMessageLB = new System.Windows.Forms.Label();
            this.timeP = new System.Windows.Forms.Panel();
            this.timeLB = new System.Windows.Forms.Label();
            this.dpPictureP = new System.Windows.Forms.Panel();
            this.profilePictureBox = new ChatApplication.CustomPictureBox();
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.mainP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.timeP.SuspendLayout();
            this.dpPictureP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainP
            // 
            this.mainP.BackColor = System.Drawing.Color.Transparent;
            this.mainP.Controls.Add(this.panel2);
            this.mainP.Controls.Add(this.timeP);
            this.mainP.Controls.Add(this.dpPictureP);
            this.mainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainP.Location = new System.Drawing.Point(3, 2);
            this.mainP.Margin = new System.Windows.Forms.Padding(1);
            this.mainP.Name = "mainP";
            this.mainP.Size = new System.Drawing.Size(434, 75);
            this.mainP.TabIndex = 0;
            this.mainP.Click += new System.EventHandler(this.ContactUClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contactNameLB);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(79, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel2.Size = new System.Drawing.Size(274, 75);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.ContactUClick);
            this.panel2.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // contactNameLB
            // 
            this.contactNameLB.AutoSize = true;
            this.contactNameLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactNameLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameLB.Location = new System.Drawing.Point(0, 0);
            this.contactNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contactNameLB.Name = "contactNameLB";
            this.contactNameLB.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.contactNameLB.Size = new System.Drawing.Size(77, 28);
            this.contactNameLB.TabIndex = 1;
            this.contactNameLB.Text = "label1";
            this.contactNameLB.Click += new System.EventHandler(this.ContactUClick);
            this.contactNameLB.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.contactNameLB.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lastMessageLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 16);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.ContactUClick);
            this.panel1.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // lastMessageLB
            // 
            this.lastMessageLB.AutoSize = true;
            this.lastMessageLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastMessageLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lastMessageLB.Location = new System.Drawing.Point(0, 0);
            this.lastMessageLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastMessageLB.Name = "lastMessageLB";
            this.lastMessageLB.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lastMessageLB.Size = new System.Drawing.Size(9, 16);
            this.lastMessageLB.TabIndex = 2;
            this.lastMessageLB.Click += new System.EventHandler(this.ContactUClick);
            this.lastMessageLB.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.lastMessageLB.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // timeP
            // 
            this.timeP.Controls.Add(this.timeLB);
            this.timeP.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeP.Location = new System.Drawing.Point(353, 0);
            this.timeP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeP.Name = "timeP";
            this.timeP.Size = new System.Drawing.Size(81, 75);
            this.timeP.TabIndex = 6;
            this.timeP.Click += new System.EventHandler(this.ContactUClick);
            this.timeP.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.timeP.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.timeLB.Location = new System.Drawing.Point(0, 0);
            this.timeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(44, 19);
            this.timeLB.TabIndex = 3;
            this.timeLB.Text = "00:00";
            this.timeLB.Click += new System.EventHandler(this.ContactUClick);
            this.timeLB.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.timeLB.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // dpPictureP
            // 
            this.dpPictureP.BackColor = System.Drawing.Color.Transparent;
            this.dpPictureP.Controls.Add(this.profilePictureBox);
            this.dpPictureP.Dock = System.Windows.Forms.DockStyle.Left;
            this.dpPictureP.Location = new System.Drawing.Point(0, 0);
            this.dpPictureP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpPictureP.Name = "dpPictureP";
            this.dpPictureP.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dpPictureP.Size = new System.Drawing.Size(79, 75);
            this.dpPictureP.TabIndex = 3;
            this.dpPictureP.Click += new System.EventHandler(this.ContactUClick);
            this.dpPictureP.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.dpPictureP.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePictureBox.Image = global::ChatApplication.Properties.Resources.profile_user1;
            this.profilePictureBox.Location = new System.Drawing.Point(7, 6);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(65, 63);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.ContactUClick);
            this.profilePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DpImagePictureBoxPaint);
            this.profilePictureBox.MouseEnter += new System.EventHandler(this.ContactUMouseEnter);
            this.profilePictureBox.MouseLeave += new System.EventHandler(this.ContactUMouseLeave);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 8;
            this.ellipseControl1.TargetControl = this;
            // 
            // ContactU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainP);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContactU";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(440, 79);
            this.mainP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.timeP.ResumeLayout(false);
            this.timeP.PerformLayout();
            this.dpPictureP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainP;
        private System.Windows.Forms.Label contactNameLB;
        private System.Windows.Forms.Label lastMessageLB;
        private System.Windows.Forms.Label timeLB;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Panel dpPictureP;
        private System.Windows.Forms.Panel panel1;
        private CustomPictureBox profilePictureBox;
        private System.Windows.Forms.Panel timeP;
        private System.Windows.Forms.Panel panel2;
    }
}
