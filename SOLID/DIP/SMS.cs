using System;

namespace DIP
{
    public class SMS : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Enviei um SMS");
        }
    }

}