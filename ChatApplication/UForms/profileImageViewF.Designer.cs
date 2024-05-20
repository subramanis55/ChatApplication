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
            this.bottomP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).BeginInit();
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
            this.profilePB.Location = new System.Drawing.Point(0, 0);
            this.profilePB.Name = "profilePB";
            this.profilePB.Size = new System.Drawing.Size(383, 364);
            this.profilePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePB.TabIndex = 0;
            this.profilePB.TabStop = false;
            // 
            // profileImageViewF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 407);
            this.Controls.Add(this.profilePB);
            this.Controls.Add(this.bottomP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileImageViewF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "profileImageViewF";
            this.bottomP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePB;
        private System.Windows.Forms.Panel bottomP;
        private EllipseButton informationBtn;
    }
}