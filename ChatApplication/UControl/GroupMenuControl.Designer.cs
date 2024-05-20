namespace ChatApplication.UControl
{
    partial class GroupMenuControl
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
            this.memberBtn = new ChatApplication.HoverButton();
            this.overviewBtn = new ChatApplication.HoverButton();
            this.SuspendLayout();
            // 
            // memberBtn
            // 
            this.memberBtn.BackColor = System.Drawing.Color.Transparent;
            this.memberBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.memberBtn.BorderColor = System.Drawing.Color.Transparent;
            this.memberBtn.BorderRadius1 = 10;
            this.memberBtn.BorderSize1 = 0;
            this.memberBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.memberBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.memberBtn.EndPoint = -3;
            this.memberBtn.FlatAppearance.BorderSize = 0;
            this.memberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.memberBtn.ForeColor = System.Drawing.Color.Black;
            this.memberBtn.IsFormUp = false;
            this.memberBtn.IsSelected = false;
            this.memberBtn.Location = new System.Drawing.Point(0, 62);
            this.memberBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(184, 62);
            this.memberBtn.SlowMotionInterval = 5;
            this.memberBtn.TabIndex = 21;
            this.memberBtn.Text = "Member";
            this.memberBtn.TextColor = System.Drawing.Color.Black;
            this.memberBtn.UseVisualStyleBackColor = false;
            // 
            // overviewBtn
            // 
            this.overviewBtn.BackColor = System.Drawing.Color.Transparent;
            this.overviewBtn.BackgroudColor = System.Drawing.Color.Transparent;
            this.overviewBtn.BorderColor = System.Drawing.Color.Transparent;
            this.overviewBtn.BorderRadius1 = 10;
            this.overviewBtn.BorderSize1 = 0;
            this.overviewBtn.ButtonSideHoverlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.overviewBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.overviewBtn.EllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.overviewBtn.EndPoint = 39;
            this.overviewBtn.FlatAppearance.BorderSize = 0;
            this.overviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overviewBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewBtn.ForeColor = System.Drawing.Color.Black;
            this.overviewBtn.IsFormUp = false;
            this.overviewBtn.IsSelected = true;
            this.overviewBtn.Location = new System.Drawing.Point(0, 0);
            this.overviewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(184, 62);
            this.overviewBtn.SlowMotionInterval = 5;
            this.overviewBtn.TabIndex = 19;
            this.overviewBtn.Text = "Overview";
            this.overviewBtn.TextColor = System.Drawing.Color.Black;
            this.overviewBtn.UseVisualStyleBackColor = false;
            // 
            // GroupMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memberBtn);
            this.Controls.Add(this.overviewBtn);
            this.Name = "GroupMenuControl";
            this.Size = new System.Drawing.Size(184, 454);
            this.ResumeLayout(false);

        }

        #endregion
        private HoverButton memberBtn;
        private HoverButton overviewBtn;
    }
}
