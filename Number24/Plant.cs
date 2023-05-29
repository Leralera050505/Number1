using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number24
{
    //24.Разработать класс для хранения данных о растениях цветочной оранжереи. При разработке учитывать основные принципы ООП.
    //
    //Полиморфизм(переопределение) и наследование есть в 19 и 21 и 23(только наследование). В задании сказано создать КЛАСС поэтому я сделал
    //дополнительные классы предки и переопределение методов и свойств только в некоторых заданиях

    public class Plant
    {
        public Plant(int id, int idtype, string name, string description, int quantity, double price)   //конструктор для заполнения приватных полей(инкапсуляция)
        {
            idPlant = id;
            idPlantType = idtype;
            namePlant = name;
            descriptionPlant = description;
            quantityPlant = quantity;
            pricePlant = price;
        }

        private int idPlant { get; set; }
        public int IdPlant      //ниже, публичные свойства для получения значений приватных полей
        {
            get { return idPlant; }
        }
        private int idPlantType { get; set; }
        public int IdPlantType
        {
            get { return idPlantType; }
        }

        private string namePlant { get; set; }
        public string NamePlant
        {
            get { return namePlant; }
        }
        private string descriptionPlant { get; set; }
        public string DescriptionPlant
        {
            get { return descriptionPlant; }
        }
        private int quantityPlant { get; set; }
        public int QuantityPlant
        {
            get { return quantityPlant; }
        }
        private double pricePlant { get; set; }
        public double PricePlant
        {
            get { return pricePlant; }
        }


    }
}
