using System;

namespace DIP
{
    public class Email : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Enviei um Email");
        }
    }
    
}