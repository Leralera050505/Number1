using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number19
{
    //19.Разработать класс для хранения данных о покупателе магазина ювелирных украшений. При разработке учитывать основные принципы ООП. 
    internal class JewelryStoreBuyer : Person   // Наследование
    {
        public JewelryStoreBuyer(int id, string name, string surname, string patronymic, DateTime birthday, char gender, int age, string phone, string email, string creditCardNumber)
            : base(id, name, surname, patronymic, birthday, gender, age)    // В производном классе так же обьявляется конструктор, но с помощью ключевого слова base 
                                                                            // параметры передаются в конструктор базового класса, т.е. при вызове конструктора данного класса мы
                                                                            // вызовем и заполним поля базового класса Person
        {
            buyerPhoneNumber = phone;
            buyerEmail = email;
            buyerCreditCardNumber = creditCardNumber;
        }

        private string buyerPhoneNumber { get; set; }
        public string PhoneNumber   //Инкапсуляция
        {
            get
            {
                return buyerPhoneNumber;
            }
            set
            {
                buyerPhoneNumber = value;
            }
        }
        private string buyerEmail { get; set; }
        public string Email   //Инкапсуляция
        {
            get
            {
                return buyerEmail;
            }
            set
            {
                buyerEmail = value;
            }
        }
        private string buyerCreditCardNumber { get; set; }
        public string CreditCardNumber   //Инкапсуляция
        {
            get
            {
                return buyerCreditCardNumber;
            }
            set
            {
                buyerCreditCardNumber = value;
            }
        }
        public override int Age     //Переопределние метода. Полиморфизм
        {
            get => base.Age;
            set { if (value > 17 && value < 110) base.Age = value; }
        }
    }
}
