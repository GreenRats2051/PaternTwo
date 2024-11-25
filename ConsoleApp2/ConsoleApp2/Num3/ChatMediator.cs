using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num3
{
    public class ChatMediator : IChatMediator
    {
        private List<IChatMember> _members = new List<IChatMember>();

        public void RegisterMember(IChatMember member)
        {
            _members.Add(member);
        }

        public void SendMessage(string message, IChatMember sender)
        {
            foreach (var member in _members)
            {
                if (member != sender)
                {
                    member.ReceiveMessage(message);
                }
            }
        }
    }
}
