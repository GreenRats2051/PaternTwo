using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num3
{
    public class ChatMember : IChatMember
    {
        private string _name;
        private IChatMediator _mediator;

        public ChatMember(string name, IChatMediator mediator)
        {
            _name = name;
            _mediator = mediator;
            _mediator.RegisterMember(this);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_name} отправляет сообщение: {message}");
            _mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{_name} получил сообщение: {message}");
        }
    }
}
