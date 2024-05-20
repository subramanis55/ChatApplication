namespace ChatApplication.UControl
{
    partial class SelectedMessageOperationForm
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
            this.ellipseControl1 = new ChatApplication.EllipseControl();
            this.deleteSelectedMessagesBtn = new System.Windows.Forms.Label();
            this.CloseChatBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 8;
            this.ellipseControl1.TargetControl = this;
            // 
            // deleteSelectedMessagesBtn
            // 
            this.deleteSelectedMessagesBtn.AllowDrop = true;
            this.deleteSelectedMessagesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteSelectedMessagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedMessagesBtn.Image = global::ChatApplication.Properties.Resources.icons8_delete_24;
            this.deleteSelectedMessagesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteSelectedMessagesBtn.Location = new System.Drawing.Point(0, 0);
            this.deleteSelectedMessagesBtn.Name = "deleteSelectedMessagesBtn";
            this.deleteSelectedMessagesBtn.Size = new System.Drawing.Size(139, 26);
            this.deleteSelectedMessagesBtn.TabIndex = 3;
            this.deleteSelectedMessagesBtn.Text = "Delete";
            this.deleteSelectedMessagesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteSelectedMessagesBtn.Click += new System.EventHandler(this.deleteSelectedMessageBtnClicked);
            this.deleteSelectedMessagesBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.deleteSelectedMessagesBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // CloseChatBtn
            // 
            this.CloseChatBtn.AllowDrop = true;
            this.CloseChatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseChatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseChatBtn.Image = global::ChatApplication.Properties.Resources.CloseChatIcon1;
            this.CloseChatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseChatBtn.Location = new System.Drawing.Point(0, 26);
            this.CloseChatBtn.Name = "CloseChatBtn";
            this.CloseChatBtn.Size = new System.Drawing.Size(139, 26);
            this.CloseChatBtn.TabIndex = 4;
            this.CloseChatBtn.Text = "CloseChat";
            this.CloseChatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseChatBtn.Click += new System.EventHandler(this.CloseChatBtnClicked);
            this.CloseChatBtn.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.CloseChatBtn.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // SelectedMessageOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(139, 55);
            this.Controls.Add(this.CloseChatBtn);
            this.Controls.Add(this.deleteSelectedMessagesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectedMessageOperationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SelectedMessageOperationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Label CloseChatBtn;
        private System.Windows.Forms.Label deleteSelectedMessagesBtn;
    }
}