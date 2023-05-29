using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number23
{
    internal class Student : Person  //наследование
    {
        public Student(int id, string name, string surname, string patronymic, DateTime birthday, char gender, int age, int idGroup, string phoneNumber, string passportNumber, string email, string snus, int idScholarshipType) : base(id, name, surname, patronymic, birthday, gender, age)
        {
            // В производном классе так же обьявляется конструктор, но с помощью ключевого слова base 
            // параметры передаются в конструктор базового класса, т.е. при вызове конструктора данного класса мы
            // вызовем и заполним поля базового класса Person
            this.idGroup = idGroup;
            this.phoneNumber = phoneNumber;
            this.passportNumber = passportNumber;
            this.email = email;
            this.idScholarshipType = idScholarshipType;
        }
        private int idGroup { get; set; }   //снизу инкапсуляция и сверху тоже 
        public int IdGroup
        {
            get { return idGroup; }
        }
        private int idScholarshipType { get; set; }
        public int IdScholarshipType
        {
            get { return idScholarshipType; }
        }
        private string phoneNumber { get; set; }
        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
        private string passportNumber { get; set; }
        public string PassportNumber
        {
            get { return passportNumber; }
        }

        private string email { get; set; }
        public string Email
        {
            get { return email; }
        }
    }
}
