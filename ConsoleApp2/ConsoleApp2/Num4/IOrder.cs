﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num4
{
    public interface IOrder
    {
        decimal GetPrice();
        string GetDescription();
    }
}
