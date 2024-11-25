using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Num4
{
    public class ExpressDelivery : IOrder
    {
        protected IOrder _order;

        public ExpressDelivery(IOrder order)
        {
            _order = order;
        }

        public virtual decimal GetPrice() => _order.GetPrice() + 30;
        public virtual string GetDescription() => _order.GetDescription() + ", Оперативная доставка";
    }
}
