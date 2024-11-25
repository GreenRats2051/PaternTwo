﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num3
{
    public interface IChatMediator
    {
        void RegisterMember(IChatMember member);
        void SendMessage(string message, IChatMember sender);
    }
}
