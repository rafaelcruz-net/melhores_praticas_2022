using System;

namespace DIP
{
    public class Telefone : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Enviei um Telefone");
        }
    }

}