namespace ChatApplication.UForms
{
    partial class profileImageViewF
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
            this.bottomP = new System.Windows.Forms.Panel();
            this.informationBtn = new ChatApplication.EllipseButton();
            this.profilePB = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomP
            // 
            this.bottomP.BackColor = System.Drawing.Color.DarkGray;
            this.bottomP.Controls.Add(this.informationBtn);
            this.bottomP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomP.Location = new System.Drawing.Point(0, 364);
            this.bottomP.Name = "bottomP";
            this.bottomP.Padding = new System.Windows.Forms.Padding(2);
            this.bottomP.Size = new System.Drawing.Size(383, 43);
            this.bottomP.TabIndex = 1;
            // 
            // informationBtn
            // 
            this.informationBtn.BackColor = System.Drawing.Color.White;
            this.informationBtn.BackgroudColor = System.Drawing.Color.White;
            this.informationBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.informationBtn.BorderRadius1 = 5;
            this.informationBtn.BorderSize1 = 0;
            this.informationBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.informationBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.informationBtn.FlatAppearance.BorderSize = 0;
            this.informationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationBtn.ForeColor = System.Drawing.Color.White;
            this.informationBtn.Image = global::ChatApplication.Properties.Resources.icons8_information_24;
            this.informationBtn.Location = new System.Drawing.Point(333, 2);
            this.informationBtn.Name = "informationBtn";
            this.informationBtn.Size = new System.Drawing.Size(48, 39);
            this.informationBtn.SlowMotionInterval = 5;
            this.informationBtn.TabIndex = 0;
            this.informationBtn.TextColor = System.Drawing.Color.White;
            this.informationBtn.UseVisualStyleBackColor = false;
            this.informationBtn.Visible = false;
            // 
            // profilePB
            // 
            this.profilePB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePB.Location = new System.Drawing.Point(0, 34);
            this.profilePB.Name = "profilePB";
            this.profilePB.Size = new System.Drawing.Size(383, 330);
            this.profilePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePB.TabIndex = 0;
            this.profilePB.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(57)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = global::ChatApplication.Properties.Resources.icons8_cancel_25__1_;
            this.closeBtn.Location = new System.Drawing.Point(342, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(39, 29);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtnClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.panel1.Size = new System.Drawing.Size(383, 34);
            this.panel1.TabIndex = 3;
            // 
            // profileImageViewF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 407);
            this.Controls.Add(this.profilePB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottomP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileImageViewF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "profileImageViewF";
            this.bottomP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePB;
        private System.Windows.Forms.Panel bottomP;
        private EllipseButton informationBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
    }
}