using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number8
{
    internal class ClassHelper
    {
        public static List<Recording> recordings = new List<Recording>()
        {
        new Recording() { IdRecording = 1,Service = "Пломбирование", Client = "Иванов И. И.",StartRecording = new DateTime(2000,1,1,22, 35, 25),EndRecording = new DateTime(2000, 1, 1,23, 35, 5)},
        new Recording() { IdRecording = 2,Service = "Обычный осмортр", Client = "Сычов В. А.",StartRecording = new DateTime(2000,1,2,11, 45, 55),EndRecording = new DateTime(2000, 1, 2,  12, 15, 55)},
        new Recording() { IdRecording = 3,Service = "Удадение зуба мудрости", Client = "Соколов А. А.",StartRecording = new DateTime(2010,1,3,5, 10, 35),EndRecording = new DateTime(2010, 1, 3,6, 15, 35)},
        new Recording() { IdRecording = 4,Service = "Пломбирование", Client = "Григорьев А. Е.",StartRecording = new DateTime(2010, 1, 4,2, 15, 15),EndRecording = new DateTime(2010, 1, 4,2, 45, 15)},
        new Recording() { IdRecording = 5,Service = "Удадение зуба", Client = "Степанова Д. П.",StartRecording = new DateTime(2011, 1, 5,12, 25, 50),EndRecording = new DateTime(2011, 1, 5,14, 25, 50)}
        };
    }
}
