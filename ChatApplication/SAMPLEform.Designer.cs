namespace ChatApplication
{
    partial class SAMPLEform
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
            this.Mathanbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.Subramanibtn = new System.Windows.Forms.Button();
            this.SivaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mathanbtn
            // 
            this.Mathanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mathanbtn.Location = new System.Drawing.Point(12, 105);
            this.Mathanbtn.Name = "Mathanbtn";
            this.Mathanbtn.Size = new System.Drawing.Size(114, 57);
            this.Mathanbtn.TabIndex = 9;
            this.Mathanbtn.Text = "madan";
            this.Mathanbtn.UseVisualStyleBackColor = true;
            this.Mathanbtn.Click += new System.EventHandler(this.ConnectMadan_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(587, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 107);
            this.button2.TabIndex = 8;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTextBox.Location = new System.Drawing.Point(132, 12);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(545, 362);
            this.MessageTextBox.TabIndex = 6;
            this.MessageTextBox.Text = "";
            // 
            // LogTextBox
            // 
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.Location = new System.Drawing.Point(132, 392);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(449, 107);
            this.LogTextBox.TabIndex = 5;
            this.LogTextBox.Text = "";
            // 
            // Subramanibtn
            // 
            this.Subramanibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subramanibtn.Location = new System.Drawing.Point(12, 168);
            this.Subramanibtn.Name = "Subramanibtn";
            this.Subramanibtn.Size = new System.Drawing.Size(114, 57);
            this.Subramanibtn.TabIndex = 10;
            this.Subramanibtn.Text = "subramani";
            this.Subramanibtn.UseVisualStyleBackColor = true;
            this.Subramanibtn.Click += new System.EventHandler(this.ConnectSubramani);
            // 
            // SivaBtn
            // 
            this.SivaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SivaBtn.Location = new System.Drawing.Point(12, 231);
            this.SivaBtn.Name = "SivaBtn";
            this.SivaBtn.Size = new System.Drawing.Size(114, 57);
            this.SivaBtn.TabIndex = 11;
            this.SivaBtn.Text = "SivaSuriya";
            this.SivaBtn.UseVisualStyleBackColor = true;
            this.SivaBtn.Click += new System.EventHandler(this.ConnectSiva);
            // 
            // SAMPLEform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 511);
            this.Controls.Add(this.SivaBtn);
            this.Controls.Add(this.Subramanibtn);
            this.Controls.Add(this.Mathanbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Name = "SAMPLEform";
            this.Text = "SAMPLEform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Mathanbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Button Subramanibtn;
        private System.Windows.Forms.Button SivaBtn;
    }
}