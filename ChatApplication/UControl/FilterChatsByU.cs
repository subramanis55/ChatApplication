using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class FilterChatByF : Form
    {
        public TransparentForm transparentFormObj;
        public event EventHandler OnClickUnreadBtn;
        public event EventHandler OnClickContactBtn;
        public event EventHandler OnClickNonContactBtn;
        public event EventHandler OnClickGroupBtn;
        public event EventHandler OnClickDraftsBtn;
        public event EventHandler OnClickAllBtn;
        public event EventHandler OnClickFilterContactsBy;
        public FilterChatByF()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += FormKeyDown;
            unreadBtn.Click += UnreadBtnClick;
            contactBtn.Click += ContactBtnClick;
            allBtn.Click += AllBtnClick;
            groupsBtn.Click += GroupsBtnClick;
            //LostFocus += FilterChatsByULostFocus;
            Focus();
        }

        private void AllBtnClick(object sender, EventArgs e)
        {
            OnClickAllBtn?.Invoke(this, EventArgs.Empty);
            this.Close();


        }
        protected override void OnLostFocus(EventArgs e)
        {
           
            base.OnLostFocus(e);
            this.Close();
        }
        //private void FilterChatsByULostFocus(object sender, EventArgs e)
        //{
        // this.Close();
        //}

        private void DraftsBtnClick(object sender, EventArgs e)
        {
            OnClickDraftsBtn?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void GroupsBtnClick(object sender, EventArgs e)
        {
            OnClickGroupBtn?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void NonContactBtnClick(object sender, EventArgs e)
        {
            OnClickNonContactBtn?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void ContactBtnClick(object sender, EventArgs e)
        {
            OnClickContactBtn?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
       
        private void UnreadBtnClick(object sender, EventArgs e)
        {
            OnClickUnreadBtn?.Invoke(this,EventArgs.Empty);
            this.Close();
        }

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = ColorTranslator.FromHtml("#D4D2D1");
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.Transparent;
        }

        private void ClickFilterContactsBy(object sender, EventArgs e)
        {
            OnClickFilterContactsBy?.Invoke(sender,EventArgs.Empty);
        }
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers & Keys.Alt) == Keys.Alt)
            {
                transparentFormObj.Dispose();
            }
        }
    }
}
