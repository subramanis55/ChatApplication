namespace ChatApplication
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ChatPage = new System.Windows.Forms.TabPage();
            this.callsPage = new System.Windows.Forms.TabPage();
            this.StatusPage = new System.Windows.Forms.TabPage();
            this.starredMessagePage = new System.Windows.Forms.TabPage();
            this.archivedPage = new System.Windows.Forms.TabPage();
            this.menuControl1 = new ChatApplication.MenuControl();
            this.chatPageTitleBar = new ChatApplication.ChatPageTitleBar();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ChatPage);
            this.tabControl1.Controls.Add(this.callsPage);
            this.tabControl1.Controls.Add(this.StatusPage);
            this.tabControl1.Controls.Add(this.starredMessagePage);
            this.tabControl1.Controls.Add(this.archivedPage);
            this.tabControl1.Location = new System.Drawing.Point(197, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // ChatPage
            // 
            this.ChatPage.Location = new System.Drawing.Point(4, 22);
            this.ChatPage.Name = "ChatPage";
            this.ChatPage.Size = new System.Drawing.Size(318, 309);
            this.ChatPage.TabIndex = 0;
            this.ChatPage.UseVisualStyleBackColor = true;
            // 
            // callsPage
            // 
            this.callsPage.Location = new System.Drawing.Point(4, 22);
            this.callsPage.Name = "callsPage";
            this.callsPage.Size = new System.Drawing.Size(318, 309);
            this.callsPage.TabIndex = 2;
            this.callsPage.UseVisualStyleBackColor = true;
            // 
            // StatusPage
            // 
            this.StatusPage.Location = new System.Drawing.Point(4, 22);
            this.StatusPage.Name = "StatusPage";
            this.StatusPage.Padding = new System.Windows.Forms.Padding(3);
            this.StatusPage.Size = new System.Drawing.Size(318, 309);
            this.StatusPage.TabIndex = 1;
            this.StatusPage.UseVisualStyleBackColor = true;
            // 
            // starredMessagePage
            // 
            this.starredMessagePage.Location = new System.Drawing.Point(4, 22);
            this.starredMessagePage.Name = "starredMessagePage";
            this.starredMessagePage.Size = new System.Drawing.Size(318, 309);
            this.starredMessagePage.TabIndex = 3;
            this.starredMessagePage.UseVisualStyleBackColor = true;
            // 
            // archivedPage
            // 
            this.archivedPage.Location = new System.Drawing.Point(4, 22);
            this.archivedPage.Name = "archivedPage";
            this.archivedPage.Size = new System.Drawing.Size(318, 309);
            this.archivedPage.TabIndex = 4;
            this.archivedPage.UseVisualStyleBackColor = true;
            // 
            // menuControl1
            // 
            this.menuControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.menuControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuControl1.Location = new System.Drawing.Point(0, 0);
            this.menuControl1.Margin = new System.Windows.Forms.Padding(2);
            this.menuControl1.Name = "menuControl1";
            this.menuControl1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuControl1.Size = new System.Drawing.Size(50, 497);
            this.menuControl1.TabIndex = 1;
            // 
            // chatPageTitleBar
            // 
            this.chatPageTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatPageTitleBar.Location = new System.Drawing.Point(50, 0);
            this.chatPageTitleBar.Name = "chatPageTitleBar";
            this.chatPageTitleBar.Size = new System.Drawing.Size(641, 59);
            this.chatPageTitleBar.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 497);
            this.Controls.Add(this.chatPageTitleBar);
            this.Controls.Add(this.menuControl1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ChatPage;
        private System.Windows.Forms.TabPage callsPage;
        private System.Windows.Forms.TabPage StatusPage;
        private System.Windows.Forms.TabPage starredMessagePage;
        private System.Windows.Forms.TabPage archivedPage;
        private MenuControl menuControl1;
        private ChatPageTitleBar chatPageTitleBar;
    }
}