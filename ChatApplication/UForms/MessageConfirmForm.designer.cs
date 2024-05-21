namespace ChatApplication
{
    partial class MessageConfirmForm
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
            this.messageBoxTopP = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noBtn = new ChatApplication.EllipseButton();
            this.yesBtn = new ChatApplication.EllipseButton();
            this.messageLB = new System.Windows.Forms.Label();
            this.messageBoxTopP.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageBoxTopP
            // 
            this.messageBoxTopP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.messageBoxTopP.Controls.Add(this.closeBtn);
            this.messageBoxTopP.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageBoxTopP.Location = new System.Drawing.Point(1, 1);
            this.messageBoxTopP.Name = "messageBoxTopP";
            this.messageBoxTopP.Padding = new System.Windows.Forms.Padding(2);
            this.messageBoxTopP.Size = new System.Drawing.Size(363, 35);
            this.messageBoxTopP.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(57)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = global::ChatApplication.Properties.Resources.icons8_cancel_25__1_;
            this.closeBtn.Location = new System.Drawing.Point(322, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(39, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.noBtn);
            this.panel2.Controls.Add(this.yesBtn);
            this.panel2.Controls.Add(this.messageLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 152);
            this.panel2.TabIndex = 1;
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.LightGray;
            this.noBtn.BackgroudColor = System.Drawing.Color.LightGray;
            this.noBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.noBtn.BorderRadius1 = 10;
            this.noBtn.BorderSize1 = 0;
            this.noBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noBtn.ForeColor = System.Drawing.Color.Black;
            this.noBtn.Location = new System.Drawing.Point(191, 103);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(69, 30);
            this.noBtn.SlowMotionInterval = 5;
            this.noBtn.TabIndex = 6;
            this.noBtn.Text = "No";
            this.noBtn.TextColor = System.Drawing.Color.Black;
            this.noBtn.UseVisualStyleBackColor = false;
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.yesBtn.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.yesBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.yesBtn.BorderRadius1 = 10;
            this.yesBtn.BorderSize1 = 0;
            this.yesBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(98, 103);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(73, 30);
            this.yesBtn.SlowMotionInterval = 5;
            this.yesBtn.TabIndex = 5;
            this.yesBtn.Text = "Yes";
            this.yesBtn.TextColor = System.Drawing.Color.White;
            this.yesBtn.UseVisualStyleBackColor = false;
            // 
            // messageLB
            // 
            this.messageLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(57, 15);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(254, 75);
            this.messageLB.TabIndex = 3;
            this.messageLB.Text = "label1";
            // 
            // MessageConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(365, 189);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.messageBoxTopP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageConfirmForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageConfirmForm";
            this.messageBoxTopP.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messageBoxTopP;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label messageLB;
        private ChatApplication.EllipseButton noBtn;
        private ChatApplication.EllipseButton yesBtn;
    }
}