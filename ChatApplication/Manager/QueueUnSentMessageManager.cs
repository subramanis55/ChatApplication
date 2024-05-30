using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChatApplication.Manager
{
    public static class QueueUnSentMessageManager
    {
        private static System.Windows.Forms.Timer QueueTimer = new System.Windows.Forms.Timer();
        public static List<Message> QueueMessages_List = new List<Message>();
        public static bool IsQueueOn;
        public static void QueueSetUp()
        {
            if (!DatabaseManager.IsConnectedToServer)
            {
                QueueMessages_List.Clear();
                QueueMessages_List.AddRange(MessagesManager.GetUnSentMessages());
                QueueMessages_List.AddRange(MessagesManager.GetUnSentGroupMessages());
            }
        }
        public static void QueueStart()
        {
            IsQueueOn = true;
             QueueMessageSent(new object(), EventArgs.Empty);
            IsQueueOn = false;
        }
        public static void QueueMessageSent(object sender, EventArgs args)
        {
            for (int i = 0; i < QueueMessages_List.Count; i++)
            {
                if (QueueMessages_List[i].GroupId > 0)
                    QueueGroupMessageSent(QueueMessages_List[i]);
                else
                {
                    QueueMessageSent(QueueMessages_List[i]);
                }
                QueueMessages_List.RemoveAt(i);
                i--;
            }
        }
        public static async void QueueMessageSent(Message message)
        {
            var data = NetworkManager.MessageSent(message, ContactsManager.ContactDictionary[message.ToHostName]);     //// *** need  to change
            if (data.Status != TaskStatus.Faulted)
            {
                MessagesManager.UpdateIsSent(message);
            }
        }
        public static async void QueueGroupMessageSent(Message message)
        {
            Task data;
            try{
                data= NetworkManager.MessageSent(message, ContactsManager.ContactDictionary[message.ToHostName]);
                if (data.Status != TaskStatus.Faulted)
                {
                    MessagesManager.DeleteUnSentGroupMessage(message);
                    if (!MessagesManager.IsUnSentGroupMessage(message))
                    {
                        MessagesManager.UpdateIsSent(message);
                    }
                }
            }
            catch{

            }
          
          
        }

    }
}
