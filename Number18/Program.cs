using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TouristUser touristUser = new TouristUser(); //Инициализация пользователя туристического агентства
            touristUser.Id = 1;
            touristUser.Email = "User@Mail.com";
            touristUser.MoneyScore = 100;
            touristUser.TouristVisaCode = "AJ403HP2";
            touristUser.SetPassword("password1234");
            touristUser.SetRegistrationDate();
            Console.WriteLine(touristUser.GetPassword());
            Console.ReadKey();

        }
    }

    public class User
    {
        public int Id { get; set; }
        public static string Name { get; set; }
        public string Email { get; set; }
        protected string Password { get; set; }
    }

    public class TouristUser : User // Проявление Наследования
    {

        public string TouristVisaCode { get; set; }
        public double MoneyScore { get; set; }
        private DateTime RegistationDate { get; set; }
        public void SetRegistrationDate()
        {
            RegistationDate = DateTime.Now;
        }

        //---------------------------------------------------------------------------------------
        public string GetPassword()
        {
            return Password.Substring(0, Password.Length - "_Cipher".Length);
        }                                                                                           //Проявление Инкапсуляции
        public void SetPassword(string password)
        {
            Password = password + "_Cipher";
        }
        //---------------------------------------------------------------------------------------
    }
}
