using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.UControl
{
    public partial class ChatSenter : UserControl
    {
        public EventHandler<string> MsgReady;
        public EventHandler<string> FilePathReady;
        public EventHandler<bool> FilePictureBoxClicked;
        private int initialHeightOfRichtextbox;
        private Point initialLocationRichtextbox;
        private Size initialSize;
        public Point initialLocation;
        public ChatSenter()
        {
            InitializeComponent();
            richTextBox1.BackColor = Color.Empty;
            richTextBox1.Font = new Font("Noto Emoji", 12);

         
            pictureBox2.MouseLeave += MouseLev1;
            pictureBox3.MouseLeave += MouseLev1;
           
            pictureBox3.MouseEnter += MouseEnt1;
            pictureBox2.MouseEnter += MouseEnt1;


            initialHeightOfRichtextbox = richTextBox1.Height;
            initialLocationRichtextbox = richTextBox1.Location;
            initialSize = this.Size;
        }
        private void MouseEnt1(object o, EventArgs e)
        {
            PictureBox p = (PictureBox)o;
            p.BackColor = Color.FromArgb(200, 200, 200);

        }
        private void MouseLev1(object o, EventArgs e)
        {
            PictureBox p = (PictureBox)o;
            p.BackColor = Color.FromArgb(254, 254, 254);

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox1.ForeColor == Color.FromArgb(200, 200, 200))
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            MsgReady?.Invoke(sender, richTextBox1.Text);
            richTextBox1.Text = "Type a message";
            richTextBox1.ForeColor = Color.FromArgb(200, 200, 200);

            Size = initialSize;
            Location = initialLocation;
            //   richTextBox1.Height = initialHeightOfRichtextbox;
            //  richTextBox1.Location = initialLocationRichtextbox;

            flag = 0;


        }
        private int flag = 0, flag2 = 0;


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.ForeColor == Color.FromArgb(200, 200, 200) && !richTextBox1.Text.Equals("Type a message") && richTextBox1.Text.Length >= 1)
            {
                richTextBox1.Text = richTextBox1.Text.ToString().Substring(0, 1);
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
            // Measure the width of the text
            int textWidth = TextRenderer.MeasureText(richTextBox1.Text, richTextBox1.Font).Width;

            if (textWidth >= richTextBox1.Width && flag == 0)//&& flag!=1)
            {

                this.Height += initialHeightOfRichtextbox;
                this.Location = new Point(this.Location.X, this.Location.Y - initialHeightOfRichtextbox);
                richTextBox1.Location = new Point(richTextBox1.Location.X, richTextBox1.Location.Y - initialHeightOfRichtextbox);//(int)((float)richTextBox1.Height/1.5));
                richTextBox1.Height *= 2;

                flag = 1;
                flag2 = 1;
            }

            else if (textWidth <= richTextBox1.Width && richTextBox1.Height > initialHeightOfRichtextbox && flag2 == 1)
            {
                this.Height = initialHeightOfRichtextbox;
                this.Location = new Point(this.Location.X, this.Location.Y + initialHeightOfRichtextbox);
                richTextBox1.Location = new Point(richTextBox1.Location.X, richTextBox1.Location.Y + initialHeightOfRichtextbox);//(int)((float)richTextBox1.Height/1.5));
                                                                                                                                 //  richTextBox1.Height /= 2;
                flag = 0;
            }

        }


        public string FilePath { get; set; }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                string Msg = richTextBox1.Text;
                MsgReady?.Invoke(sender, Msg.Substring(0, Msg.Length - 1));
                richTextBox1.Text = "Type a message";
                richTextBox1.ForeColor = Color.FromArgb(200, 200, 200);

                Size = initialSize;
                Location = initialLocation;
                //   richTextBox1.Height = initialHeightOfRichtextbox;
                //  richTextBox1.Location = initialLocationRichtextbox;

                flag = 0;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                richTextBox1.Text = "Type a message";
                richTextBox1.ForeColor = Color.FromArgb(200, 200, 200);

                Size = initialSize;
                Location = initialLocation;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FilePictureBoxClicked?.Invoke(sender, true);

            using (OpenFileDialog saveFileDialog = new OpenFileDialog())
            {
                saveFileDialog.Filter = "All files (*.*)|*.*|" +
                        "Text files (*.txt)|*.txt|" +
                        "PDF files (*.pdf)|*.pdf|" +
                        "Word documents (*.docx)|*.docx|" +
                        "Excel files (*.xlsx)|*.xlsx|" +
                        "Image files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif|" +
                        "Audio files (*.mp3, *.wav)|*.mp3;*.wav|" +
                        "Video files (*.mp4, *.avi)|*.mp4;*.avi|" +
                        "Executable files (*.exe)|*.exe|" +
                        "Compressed files (*.zip, *.rar)|*.zip;*.rar";



                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = saveFileDialog.FileName;
                    FilePathReady?.Invoke(sender, FilePath);
                }
            }


            //  using (FileStream fileStream = File.OpenRead(FilePath))


        }

    }
}
