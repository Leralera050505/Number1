using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number25
{
    //25.Разработать класс для хранения данных об автомобилях, находящихся в таксопарке. При разработке учитывать основные принципы ООП. 

    //Полиморфизм(переопределение) и наследование есть в 19 и 21 и 23(только наследование). В задании сказано создать КЛАСС поэтому я сделал
    //дополнительные классы предки и переопределение методов и свойств только в некоторых заданиях
    public class Car
    {
        public Car(int id, int idtype, int idowner, string model, bool worked, double cost)  //конструктор для заполнения приватных полей(инкапсуляция)
        {
            idCar = id;
            idType = idtype;
            idOwner = idowner;
            modelName = model;
            isWorked = worked;
            estimatedСost = cost;

        }
        //ниже, публичные свойства для получения значений приватных полей
        private int idCar { get; set; }
        public int IdCar
        {
            get { return idCar; }
        }
        private int idType { get; set; }
        public int IdType
        {
            get { return idType; }
        }

        private int idOwner { get; set; }
        public int IdOwner
        {
            get { return idOwner; }
        }
        private string modelName { get; set; }
        public string ModelName
        {
            get { return modelName; }
        }
        private bool isWorked { get; set; }
        public bool IsWorked
        {
            get { return isWorked; }
        }
        private double estimatedСost { get; set; }
        public double EstimatedСost
        {
            get { return estimatedСost; }
        }

    }
}
