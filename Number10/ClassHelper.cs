using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number10
{
    internal class ClassHelper
    {
        public static List<Premier> premiers = new List<Premier>() {
            new Premier() {Name="Межвидовые реценденты", Description="Семейный спектакль", AgeRestriction="0+", Cost=1000, DurationInMinutes=100, StartDate=new DateTime(2023,05,14,12,0,0), ImagePath=@"C:\Users\Alexander\source\repos\Adyskin3K\Task10\Images\1.jpg" },
            new Premier() {Name="Техасская мазня говном", Description="Какашки хех", AgeRestriction="6+", Cost=500, DurationInMinutes=120, StartDate=new DateTime(2023,05,14,13,40,0), ImagePath = @"C:\Users\Alexander\source\repos\Adyskin3K\Task10\Images\2.jpg"},
            new Premier() {Name="Хайфлит", Description="Deus in nobis!", AgeRestriction="12+", Cost=600, DurationInMinutes=1000, StartDate=new DateTime(2023,05,14,10,0,0), ImagePath = @"C:\Users\Alexander\source\repos\Adyskin3K\Task10\Images\3.jpg"},
            new Premier() {Name="Шрекс", Description="МММ", AgeRestriction="18+", Cost=100, DurationInMinutes=60, StartDate=new DateTime(2023,05,14,12,12,12), ImagePath = @"C:\Users\Alexander\source\repos\Adyskin3K\Task10\Images\4.jpg"},
            new Premier() {Name="Хз", Description="Шутки кончились", AgeRestriction="0+", Cost=0, DurationInMinutes=180, StartDate=new DateTime(2023,05,14,0,0,0)}
        };
    }
}
