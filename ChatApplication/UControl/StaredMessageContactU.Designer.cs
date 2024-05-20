namespace ChatApplication.UControl
{
    partial class StaredMessageContactU
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
            this.timeP = new System.Windows.Forms.Panel();
            this.timeLB = new System.Windows.Forms.Label();
            this.dpPictureP = new System.Windows.Forms.Panel();
            this.profilePictureBox = new ChatApplication.CustomPictureBox();
            this.mainP.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.mainP.Location = new System.Drawing.Point(0, 0);
            this.mainP.Margin = new System.Windows.Forms.Padding(1);
            this.mainP.Name = "mainP";
            this.mainP.Size = new System.Drawing.Size(368, 56);
            this.mainP.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contactNameLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(59, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel2.Size = new System.Drawing.Size(248, 56);
            this.panel2.TabIndex = 7;
            // 
            // contactNameLB
            // 
            this.contactNameLB.AutoSize = true;
            this.contactNameLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.contactNameLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameLB.Location = new System.Drawing.Point(0, 0);
            this.contactNameLB.Name = "contactNameLB";
            this.contactNameLB.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.contactNameLB.Size = new System.Drawing.Size(62, 21);
            this.contactNameLB.TabIndex = 1;
            this.contactNameLB.Text = "label1";
            // 
            // timeP
            // 
            this.timeP.Controls.Add(this.timeLB);
            this.timeP.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeP.Location = new System.Drawing.Point(307, 0);
            this.timeP.Name = "timeP";
            this.timeP.Size = new System.Drawing.Size(61, 56);
            this.timeP.TabIndex = 6;
            // 
            // timeLB
            // 
            this.timeLB.AutoSize = true;
            this.timeLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.timeLB.Location = new System.Drawing.Point(0, 0);
            this.timeLB.Name = "timeLB";
            this.timeLB.Size = new System.Drawing.Size(34, 13);
            this.timeLB.TabIndex = 3;
            this.timeLB.Text = "00:00";
            // 
            // dpPictureP
            // 
            this.dpPictureP.BackColor = System.Drawing.Color.Transparent;
            this.dpPictureP.Controls.Add(this.profilePictureBox);
            this.dpPictureP.Dock = System.Windows.Forms.DockStyle.Left;
            this.dpPictureP.Location = new System.Drawing.Point(0, 0);
            this.dpPictureP.Name = "dpPictureP";
            this.dpPictureP.Padding = new System.Windows.Forms.Padding(5);
            this.dpPictureP.Size = new System.Drawing.Size(59, 56);
            this.dpPictureP.TabIndex = 3;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePictureBox.Image = global::ChatApplication.Properties.Resources.profile_user1;
            this.profilePictureBox.Location = new System.Drawing.Point(5, 5);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(49, 46);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // StaredMessageContactU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainP);
            this.Name = "StaredMessageContactU";
            this.Size = new System.Drawing.Size(368, 56);
            this.mainP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.timeP.ResumeLayout(false);
            this.timeP.PerformLayout();
            this.dpPictureP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label contactNameLB;
        private System.Windows.Forms.Panel timeP;
        private System.Windows.Forms.Label timeLB;
        private System.Windows.Forms.Panel dpPictureP;
        private CustomPictureBox profilePictureBox;
    }
}
