using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.UControl
{
    public partial class SelectedMessageOperationForm : Form
    {
        public event EventHandler OnclickCloseChatBtn;
        public event EventHandler OnclickdeleteSelectedMessageBtn;
        public SelectedMessageOperationForm()
        {
            InitializeComponent();
            //LostFocus += SelectedMessageOperationFormLostFocus;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Focus();
        }


        private void deleteSelectedMessageBtnClicked(object sender, EventArgs e)
        {
            OnclickdeleteSelectedMessageBtn?.Invoke(this, EventArgs.Empty);
        }

        private void CloseChatBtnClicked(object sender, EventArgs e)
        {
            OnclickCloseChatBtn?.Invoke(this, EventArgs.Empty);
        }

        private void BtnMouseEnter(object sender, EventArgs e)
        {
           ((Control)sender).BackColor =  Color.FromArgb(200, 200, 200);
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Transparent;
        }
    }
}
