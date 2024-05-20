using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class DpPictureU : UserControl
    {
     
        private string dpPicturePath = "";
        private OpenFileDialog OpenFileDialog = new OpenFileDialog();
        public EventHandler<string> OnClickDpPicturePathGet;

        public bool EditBtnVisible
        {
            set
            {
                editBtn.Visible = value;
            }
            get
            {
                return editBtn.Visible;
            }
        }
        public Image Image{
        get{
                return dpPB.Image;
        }
        set{
                if (dpPB.Image != null)
                    dpPB.Image.Dispose();
                dpPB.Image = value;
        }
        }
        public Image EditBtnImage
        {
            get
            {
                return editBtn.Image;
            }
            set
            {
                editBtn.Image = value;
            }
        }
        public string DpPicturPath
        {
            get
            {
                return dpPicturePath;
            }
            set
            {
               
                if (value != "")
                {
                    if (dpPB.Image != null)
                        dpPB.Image.Dispose();
                    dpPicturePath = value;
                    dpPB.Image = Image.FromFile(dpPicturePath);
                }
               
            }
        }
        
        public DpPictureU()
        {
            InitializeComponent();
            Resize += DpPictureUResize;
            editBtn.Click += AddDpBtnClicked;
            dpPB.Click += DpPBClick;
        }

        private void DpPBClick(object sender, EventArgs e)
        {
           
        }

        private void AddDpBtnClicked(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "PNG|*.png|JPEG|*.jpeg";
           DialogResult result= OpenFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DpPicturPath = OpenFileDialog.FileName;
                OnClickDpPicturePathGet?.Invoke(this,DpPicturPath);
            }
        }

        private void DpPictureUResize(object sender, EventArgs e)
        {
            editBtn.Location = new Point(Width - editBtn.Width, Height - editBtn.Height);
        }
    }
}
