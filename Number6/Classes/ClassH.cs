using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number6.Classes
{
    internal class ClassH
    {
        public static List<OrderItem> OrderItems = new List<OrderItem> //Лист в котором хранятся предметы заказа
        {
            new OrderItem(){Title="Мяч", Cost=100},
            new OrderItem(){Title="Гантели", Cost=200},
            new OrderItem(){Title="Скакалка", Cost=300}

        };
    }
}
