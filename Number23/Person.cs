using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number23
{
    //23.Разработать класс для хранения данных о студенте колледжа. При разработке учитывать основные принципы ООП. 
    internal class Person
    {
        private int IdPerson { get; set; }
        private string PersonName { get; set; }
        private string PersonSurname { get; set; }
        private string PersonPatronymic { get; set; }
        private DateTime PersonBirthday { get; set; }
        private char PersonGender { get; set; }
        private int PersonAge { get; set; }
        public virtual int Age  //Виртуальный метод который можно будет переопределить в классе наследнике(полиморфизм)
        {
            get => PersonAge;
            set { if (value > 0 && value < 110) PersonAge = value; }
        }
        public Person(int id, string name, string surname, string patronymic, DateTime birthday, char gender, int age)     //Инкапсуляция.
                                                                                                                           //Можем задать значение приватным полям через конструктор класса.
        {
            PersonName = name;
            PersonAge = age;
            PersonSurname = surname;
            PersonPatronymic = patronymic;
            PersonBirthday = birthday;
            PersonGender = gender;
            IdPerson = id;
        }
        public string GetPersonName     //Получение значения приватного поля через свойство
        {
            get
            {
                return PersonName;
            }
        }
        public string SetPersonName     //Установка значения приватного поля через свойство
        {
            set
            {
                PersonName = value;
            }
        }


    }
}
