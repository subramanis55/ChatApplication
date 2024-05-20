namespace ChatApplication.UForms
{
    partial class MessageF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.okBtn = new ChatApplication.EllipseButton();
            this.messageLB = new System.Windows.Forms.Label();
            this.messageBoxTopP = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.messageBoxTopP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.okBtn);
            this.panel2.Controls.Add(this.messageLB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 160);
            this.panel2.TabIndex = 3;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.LightGray;
            this.okBtn.BackgroudColor = System.Drawing.Color.LightGray;
            this.okBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.okBtn.BorderRadius1 = 10;
            this.okBtn.BorderSize1 = 0;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.Black;
            this.okBtn.Location = new System.Drawing.Point(138, 108);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(69, 30);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "Ok";
            this.okBtn.TextColor = System.Drawing.Color.Black;
            this.okBtn.UseVisualStyleBackColor = false;
            // 
            // messageLB
            // 
            this.messageLB.AutoSize = true;
            this.messageLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.Location = new System.Drawing.Point(71, 25);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(90, 20);
            this.messageLB.TabIndex = 3;
            this.messageLB.Text = "messageLB";
            // 
            // messageBoxTopP
            // 
            this.messageBoxTopP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(65)))));
            this.messageBoxTopP.Controls.Add(this.closeBtn);
            this.messageBoxTopP.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageBoxTopP.Location = new System.Drawing.Point(0, 0);
            this.messageBoxTopP.Name = "messageBoxTopP";
            this.messageBoxTopP.Padding = new System.Windows.Forms.Padding(2);
            this.messageBoxTopP.Size = new System.Drawing.Size(383, 35);
            this.messageBoxTopP.TabIndex = 2;
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
            this.closeBtn.Size = new System.Drawing.Size(39, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // MessageF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 195);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.messageBoxTopP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageF";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.messageBoxTopP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private EllipseButton okBtn;
        private System.Windows.Forms.Label messageLB;
        private System.Windows.Forms.Panel messageBoxTopP;
        private System.Windows.Forms.Button closeBtn;
    }
}