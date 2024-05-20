using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace ChatApplication
{
    
    
    public enum NotificationType
    {
        Information, Error, Success, Warning,Message,File,None
    }
   public class NotificationThrowManager
    {
        public event EventHandler OnClickNotification;
      
        Timer arrangeTimer = new Timer();
        private int x= Screen.PrimaryScreen.Bounds.Width - 50; 
        private int y = Screen.PrimaryScreen.Bounds.Height - 80;
     
        public int BorderRadius
        {
            set
            {
                NotificationForm.BorderRadius = value;
            }
            get
            {
                return NotificationForm.BorderRadius;
            }
        }
        List<NotificationForm> NotifiactionList = new List<NotificationForm>();
        public void ArrangeNotification(){      
        for (int i=0;i< NotifiactionList.Count; i++){
                NotifiactionList[i].Location = new System.Drawing.Point(x- NotifiactionList[i].Width,y- (NotifiactionList[i].Height*(NotifiactionList.Count-i)-10*i));
        }
        }
      
        public void CreateMessageNotification(Message message,string name){         
            NotificationForm obj = new NotificationForm(message, name, NotificationType.Message);        
            obj.OnEnd +=DisposeNotification;
            obj.OnClickNotification += NotificationFormClickInvoke;
            obj.Show();
            NotifiactionList.Add(obj);      
            ArrangeNotification();
        }
        public void CreateFileNotification(Message message, string name)
        {
            NotificationForm obj = new NotificationForm(message, name, NotificationType.File);
            obj.OnEnd += DisposeNotification;
            obj.OnClickFileNotification += MainForm.NotificationOnClickFileSaveInvoke;
            obj.Show();
            NotifiactionList.Add(obj);
            ArrangeNotification();
        }
        public void CreateNotification(string message,NotificationType notificationType)
        {
            NotificationForm obj = new NotificationForm(message, notificationType);
            obj.OnEnd += DisposeNotification;            
            obj.Show();
            NotifiactionList.Add(obj);           
            ArrangeNotification();
        }
        private void DisposeNotification(object sender,EventArgs args){
            NotifiactionList.Remove(((NotificationForm)sender));
          ((Control)sender).Dispose();
            ArrangeNotification();
        }
        public void NotificationFormClickInvoke(object sender,EventArgs args){
            OnClickNotification?.Invoke(this,args);

        }
    }
}
