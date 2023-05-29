using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Number7
{
    internal class ClassHelper
    {
        public static List<Worker> workers = new List<Worker>()
        {
            //Здесб создаётся экземпляр worker из стрингов и 1 даты
            new Worker() {Name = "Иван", Surename = "Иванов", Patron="Иванович", DateOfBirth = Convert.ToDateTime("06.05.04"), Duty="Раб",
           //Это ссылка на картинку. Важно запомнить
            PhotoPath = new Uri("/Photo.jpg",UriKind.Relative)}
        };
    }
}
