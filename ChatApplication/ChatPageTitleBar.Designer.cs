namespace ChatApplication
{
    partial class ChatPageTitleBar
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
            this.SearchButton = new ChatApplication.EllipseButton();
            this.ProfilePicture = new ChatApplication.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Menu;
            this.SearchButton.BackgroudColor = System.Drawing.SystemColors.Menu;
            this.SearchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchButton.BorderRadius1 = 10;
            this.SearchButton.BorderSize1 = 0;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Image = global::ChatApplication.Properties.Resources.icons8_search_18;
            this.SearchButton.Location = new System.Drawing.Point(758, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(50, 38);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.TextColor = System.Drawing.Color.White;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ProfilePicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProfilePicture.Location = new System.Drawing.Point(10, 10);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(59, 38);
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePictureClick);
            // 
            // ChatPageTitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ProfilePicture);
            this.Name = "ChatPageTitleBar";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(818, 58);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPictureBox ProfilePicture;
        private EllipseButton SearchButton;
    }
}
