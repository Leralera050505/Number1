using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number21
{
    // 21. Разработать класс для хранения данных о товаре в строительном магазине. При разработке учитывать основные принципы ООП. 
    internal class ConstructionGood : Product  //наследование
    {
        public ConstructionGood(int id, int quantity, string name, double price, int type, int category) : base(id, quantity, name, price)
        // В производном классе так же обьявляется конструктор, но с помощью ключевого слова base 
        // параметры передаются в конструктор базового класса, т.е. при вызове конструктора данного класса мы
        // вызовем и заполним поля базового класса Product
        {
            idType = type;
            idCategory = category;
        }
        private int idType { get; set; }
        public int IdType     //Получение значения приватного поля через свойство
        {
            get
            {
                return idType;
            }
        }
        private int idCategory { get; set; }
        public int IdCategory     //Получение значения приватного поля через свойство
        {
            get
            {
                return idCategory;
            }
        }
        public override double GetFullPrice(int quantity)  //переопределение метода из наследуемого класса
        {
            return Price * quantity * 1.1;
        }


    }
}
