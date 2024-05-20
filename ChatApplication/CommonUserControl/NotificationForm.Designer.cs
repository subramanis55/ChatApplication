using ChatApplication;

namespace ChatApplication
{
    partial class NotificationForm
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
            this.NotificationFormTopP = new System.Windows.Forms.Panel();
            this.NotificationTypeLB = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBtn = new ChatApplication.EllipseButton();
            this.MainP = new System.Windows.Forms.Panel();
            this.messageP = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.messageLB = new System.Windows.Forms.Label();
            this.messageContactnameP = new System.Windows.Forms.Panel();
            this.nameLB = new System.Windows.Forms.Label();
            this.IconP = new System.Windows.Forms.Panel();
            this.IconPB = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IncreaseingP = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NotificationFormTopP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainP.SuspendLayout();
            this.messageP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.messageContactnameP.SuspendLayout();
            this.IconP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotificationFormTopP
            // 
            this.NotificationFormTopP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.NotificationFormTopP.Controls.Add(this.NotificationTypeLB);
            this.NotificationFormTopP.Controls.Add(this.panel2);
            this.NotificationFormTopP.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationFormTopP.Location = new System.Drawing.Point(0, 0);
            this.NotificationFormTopP.Name = "NotificationFormTopP";
            this.NotificationFormTopP.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.NotificationFormTopP.Size = new System.Drawing.Size(387, 37);
            this.NotificationFormTopP.TabIndex = 0;
            this.NotificationFormTopP.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // NotificationTypeLB
            // 
            this.NotificationTypeLB.AutoSize = true;
            this.NotificationTypeLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.NotificationTypeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationTypeLB.ForeColor = System.Drawing.Color.White;
            this.NotificationTypeLB.Location = new System.Drawing.Point(10, 2);
            this.NotificationTypeLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotificationTypeLB.Name = "NotificationTypeLB";
            this.NotificationTypeLB.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.NotificationTypeLB.Size = new System.Drawing.Size(60, 27);
            this.NotificationTypeLB.TabIndex = 2;
            this.NotificationTypeLB.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(350, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 33);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.BackgroudColor = System.Drawing.Color.Red;
            this.CancelBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderRadius1 = 0;
            this.CancelBtn.BorderSize1 = 0;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Image = global::ChatApplication.Properties.Resources.icons8_cancel_25__1_;
            this.CancelBtn.Location = new System.Drawing.Point(0, 0);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(35, 33);
            this.CancelBtn.SlowMotionInterval = 5;
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // MainP
            // 
            this.MainP.Controls.Add(this.messageP);
            this.MainP.Controls.Add(this.IconP);
            this.MainP.Controls.Add(this.NotificationFormTopP);
            this.MainP.Controls.Add(this.panel4);
            this.MainP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainP.Location = new System.Drawing.Point(0, 0);
            this.MainP.Name = "MainP";
            this.MainP.Size = new System.Drawing.Size(387, 164);
            this.MainP.TabIndex = 2;
            this.MainP.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // messageP
            // 
            this.messageP.Controls.Add(this.panel3);
            this.messageP.Controls.Add(this.messageContactnameP);
            this.messageP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageP.Location = new System.Drawing.Point(110, 37);
            this.messageP.Name = "messageP";
            this.messageP.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.messageP.Size = new System.Drawing.Size(277, 118);
            this.messageP.TabIndex = 5;
            this.messageP.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.messageLB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 92);
            this.panel3.TabIndex = 8;
            this.panel3.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // messageLB
            // 
            this.messageLB.AllowDrop = true;
            this.messageLB.BackColor = System.Drawing.SystemColors.Control;
            this.messageLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(0, 0);
            this.messageLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(272, 92);
            this.messageLB.TabIndex = 7;
            this.messageLB.Text = "label1";
            this.messageLB.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // messageContactnameP
            // 
            this.messageContactnameP.Controls.Add(this.nameLB);
            this.messageContactnameP.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageContactnameP.Location = new System.Drawing.Point(4, 1);
            this.messageContactnameP.Margin = new System.Windows.Forms.Padding(2);
            this.messageContactnameP.Name = "messageContactnameP";
            this.messageContactnameP.Size = new System.Drawing.Size(272, 24);
            this.messageContactnameP.TabIndex = 9;
            this.messageContactnameP.Visible = false;
            this.messageContactnameP.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.BackColor = System.Drawing.SystemColors.Control;
            this.nameLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(135)))), ((int)(((byte)(85)))));
            this.nameLB.Location = new System.Drawing.Point(0, 0);
            this.nameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(51, 20);
            this.nameLB.TabIndex = 0;
            this.nameLB.Text = "label1";
            this.nameLB.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // IconP
            // 
            this.IconP.Controls.Add(this.IconPB);
            this.IconP.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconP.Location = new System.Drawing.Point(0, 37);
            this.IconP.Name = "IconP";
            this.IconP.Size = new System.Drawing.Size(110, 118);
            this.IconP.TabIndex = 3;
            this.IconP.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // IconPB
            // 
            this.IconPB.Location = new System.Drawing.Point(25, 17);
            this.IconPB.Name = "IconPB";
            this.IconPB.Size = new System.Drawing.Size(55, 46);
            this.IconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPB.TabIndex = 0;
            this.IconPB.TabStop = false;
            this.IconPB.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.IncreaseingP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 9);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // IncreaseingP
            // 
            this.IncreaseingP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.IncreaseingP.Dock = System.Windows.Forms.DockStyle.Left;
            this.IncreaseingP.Location = new System.Drawing.Point(0, 0);
            this.IncreaseingP.Name = "IncreaseingP";
            this.IncreaseingP.Size = new System.Drawing.Size(21, 9);
            this.IncreaseingP.TabIndex = 0;
            this.IncreaseingP.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(104, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20, 25, 0, 0);
            this.panel5.Size = new System.Drawing.Size(312, 105);
            this.panel5.TabIndex = 2;
            this.panel5.Click += new System.EventHandler(this.NotificationFormClick);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 164);
            this.Controls.Add(this.MainP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationForm";
            this.TopMost = true;
            this.NotificationFormTopP.ResumeLayout(false);
            this.NotificationFormTopP.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.MainP.ResumeLayout(false);
            this.messageP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.messageContactnameP.ResumeLayout(false);
            this.messageContactnameP.PerformLayout();
            this.IconP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NotificationFormTopP;
      
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel MainP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel messageP;
        private System.Windows.Forms.Panel IconP;
        private System.Windows.Forms.PictureBox IconPB;
        private System.Windows.Forms.Panel IncreaseingP;
        private EllipseButton CancelBtn;
        private System.Windows.Forms.Label NotificationTypeLB;
        private System.Windows.Forms.Panel messageContactnameP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label messageLB;
        private System.Windows.Forms.Label nameLB;
    }
}