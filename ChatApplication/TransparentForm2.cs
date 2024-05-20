using ChatApplication.Manager;
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
    public partial class TransparentForm2 : Form
    {
        private Control control;
        public Control Control
        {
            set
            {
                control = value;
            }
            get
            {
                return control;
            }
        }
        public TransparentForm2()
        {
            InitializeComponent();
            Disposed += TransparentFormDisposed; ;
            FormClosed += TransparentFormFormClosed;
            Click += TransparentFormClick;

            FeaturesMethods.AltTabFormShowStop(this.Handle);
        }

        private void TransparentFormDisposed(object sender, EventArgs e)
        {
            try
            {
                Control.Dispose();
            }
            catch
            { }

        }

        private void TransparentFormFormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Control.Dispose();
            }
            catch
            {
            }
            this.Dispose();
        }


        public void TransparentFormClick(object sender, EventArgs e)
        {
            try
            {
                Control.Dispose();
            }
            catch
            {
            }
            this.Dispose();
        }
    }
}
