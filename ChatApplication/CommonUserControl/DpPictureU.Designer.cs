namespace ChatApplication
{
    partial class DpPictureU
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
            this.editBtn = new ChatApplication.EllipseButton();
            this.dpPB = new ChatApplication.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dpPB)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.editBtn.BorderColor = System.Drawing.Color.Transparent;
            this.editBtn.BorderRadius1 = 12;
            this.editBtn.BorderSize1 = 0;
            this.editBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.Wheat;
            this.editBtn.Image = global::ChatApplication.Properties.Resources.icons8_add_24__4_;
            this.editBtn.Location = new System.Drawing.Point(86, 84);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(17, 20);
            this.editBtn.SlowMotionInterval = 5;
            this.editBtn.TabIndex = 1;
            this.editBtn.TextColor = System.Drawing.Color.Wheat;
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // dpPB
            // 
            this.dpPB.BackColor = System.Drawing.Color.Transparent;
            this.dpPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpPB.Image = global::ChatApplication.Properties.Resources.profile_user;
            this.dpPB.Location = new System.Drawing.Point(0, 0);
            this.dpPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpPB.Name = "dpPB";
            this.dpPB.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.dpPB.Size = new System.Drawing.Size(105, 105);
            this.dpPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dpPB.TabIndex = 0;
            this.dpPB.TabStop = false;
            // 
            // DpPictureU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dpPB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DpPictureU";
            this.Size = new System.Drawing.Size(104, 105);
            ((System.ComponentModel.ISupportInitialize)(this.dpPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPictureBox dpPB;
        private EllipseButton editBtn;
    }
}
