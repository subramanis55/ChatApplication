using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
   public class Message
    {
    public string MessageText{ set; get; }
    public int MessageId{ set; get; }
    public DateTime DateAndTime{ set; get; }
    public string FromHostName{ set; get; }
    public string ToHostName { set; get; }    
    public int GroupId { set; get; }
    public bool IsSent{ set; get; }
    public bool IsFile { set; get;}
    public string FileName { get; set; }
    public long FileSize { get; set; }

     public Message(int messageId,string fromHostName, string toHostName, int groupId, DateTime dateAndTime, string messageText, bool isSent, bool isFile, string fileName)
    {
            MessageId = messageId;
            FromHostName = fromHostName;
            ToHostName = toHostName;
            GroupId = groupId;
            MessageText = messageText;
            DateAndTime = dateAndTime;
            IsSent = isSent;
            FileName = fileName;
            IsFile = isFile;
    }
        public Message()
        {

        }
    }
}
