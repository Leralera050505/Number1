using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number22
{
    //22.Разработать класс для хранения данных о животном в питомце для бездомных животных. При разработке учитывать основные принципы ООП.

    //Полиморфизм(переопределение) и наследование есть в 19 и 21 и 23(только наследование). В задании сказано создать КЛАСС поэтому я сделал
    //дополнительные классы предки и переопределение методов и свойств только в некоторых заданиях
    public class Animal
    {
        public Animal(int idAnimal, int idCategory, int idType, string nickname, int age, bool isVaccination)
        {
            this.idAnimal = idAnimal;
            this.idCategory = idCategory;
            this.idType = idType;
            this.nickname = nickname;
            this.age = age;
            this.isVaccination = isVaccination;

        }
        private int idAnimal { get; set; }
        public int IdAnimal     //Получение значения приватного поля через свойство
        {
            get
            {
                return idAnimal;
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
        private int idType { get; set; }
        public int IdType     //Получение значения приватного поля через свойство
        {
            get
            {
                return idType;
            }
        }
        private string nickname { get; set; }
        public string Nickname     //Получение значения приватного поля через свойство
        {
            get
            {
                return nickname;
            }
        }
        private int age { get; set; }
        public int Age     //Получение значения приватного поля через свойство
        {
            get
            {
                return age;
            }
        }
        private bool isVaccination { get; set; }
        public bool IsVaccination     //Получение значения приватного поля через свойство
        {
            get
            {
                return isVaccination;
            }
        }


    }
}
