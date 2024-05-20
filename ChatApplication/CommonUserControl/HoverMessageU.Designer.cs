namespace ChatApplication
{
    partial class MessageDateU
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
            this.ellipseControl2 = new ChatApplication.EllipseControl();
            this.messageLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ellipseControl2
            // 
            this.ellipseControl2.CornerRadius = 7;
            this.ellipseControl2.TargetControl = this;
            // 
            // messageLB
            // 
            this.messageLB.AutoSize = true;
            this.messageLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.messageLB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.messageLB.Location = new System.Drawing.Point(31, 4);
            this.messageLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLB.Name = "messageLB";
            this.messageLB.Size = new System.Drawing.Size(61, 17);
            this.messageLB.TabIndex = 1;
            this.messageLB.Text = "Message";
            this.messageLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoverMessageU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.messageLB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HoverMessageU";
            this.Size = new System.Drawing.Size(125, 25);
            this.Load += new System.EventHandler(this.HoverMessageU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EllipseControl ellipseControl2;
        private System.Windows.Forms.Label messageLB;
    }
}
