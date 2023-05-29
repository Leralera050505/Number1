using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number9
{
    internal class ClassH
    {
        public static List<Session> Sessions = new List<Session>()
        {
        new Session() {TitleFilm="Атака Титанусов", CostTicket=100, DateStart=DateTime.Now.ToString()},
        new Session() {TitleFilm="Сыч - Начало", CostTicket=9999, DateStart=new DateTime(2023,05,14).ToString()},
        new Session() {TitleFilm="Двое в подлодке\nне считая Бояры", CostTicket=666, DateStart=new DateTime(2023,05,15).ToString()},
        new Session() {TitleFilm="Фехтемее", CostTicket=228, DateStart=new DateTime(2023,05,16).ToString()},
        new Session() {TitleFilm="Сыч 2 - Возвращение", CostTicket=6666, DateStart=new DateTime(2023,05,17).ToString()},
        new Session() {TitleFilm="Жесть, Морковь \nи Хоботы", CostTicket=3301, DateStart=new DateTime(2023,05,18).ToString()},
        };
    }
}
