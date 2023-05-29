using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number21
{
    // 21. Разработать класс для хранения данных о товаре в строительном магазине. При разработке учитывать основные принципы ООП. 
    public class Product
    {
        public Product(int id, int quantity, string name, double price)
        {
            idProd = id;
            quantityInStock = quantity;
            prodName = name;
            prodPrice = price;

        }

        private int idProd { get; set; }
        public int IdProd     //Получение значения приватного поля через свойство
        {
            get
            {
                return idProd;
            }
        }
        private int quantityInStock { get; set; }
        public int Quantity     //Получение значения приватного поля через свойство
        {
            get
            {
                return quantityInStock;
            }
        }
        private double prodPrice { get; set; }
        public double Price     //Получение значения приватного поля через свойство
        {
            get
            {
                return prodPrice;
            }
        }
        public virtual double GetFullPrice(int quantity)  //метод возвращает цену за все товары(какое то их количество)
        {
            return prodPrice * quantity;
        }
        private string prodName { get; set; }
        public string ProdName     //Получение значения приватного поля через свойство
        {
            get
            {
                return prodName;
            }
        }

    }
}
