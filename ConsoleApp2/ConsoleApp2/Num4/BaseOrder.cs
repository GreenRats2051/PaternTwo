using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num4
{
    public class BaseOrder : IOrder
    {
        public decimal Price { get; set; } = 100;

        public decimal GetPrice() => Price;
        public string GetDescription() => "Базовый заказ";
    }
}
