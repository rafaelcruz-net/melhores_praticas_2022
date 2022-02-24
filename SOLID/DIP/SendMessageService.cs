using System;

namespace DIP
{
    public class SendMessageService
    {

        public IMessage Message { get; set; }

        public SendMessageService(IMessage message)
        {
            this.Message = message;
        }

        public void SendMessage()
        {
            this.Message.Send();
        }
    }

}