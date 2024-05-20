using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace ChatApplication

{
    class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(){
            this.Resize += CustomPictureBox_Resize;
        }

        private void CustomPictureBox_Resize(object sender, EventArgs e)
        {
           
                  if(Height>Width)
                   Width=Height;
                   
        }

        protected override void OnPaint(PaintEventArgs args)
        {
              try{
                base.OnPaint(args);
                args.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(path);
            }
            catch{

            }
        
        }

    }
}