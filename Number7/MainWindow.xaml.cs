using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Number7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Собирает ФИО из полей 0-вого работника, класс worker, workers - название списка рабочих в classhelper'e.
            tblFio.Text = tblFio.Text + ClassHelper.workers[0].Name + " " + ClassHelper.workers[0].Surename + " " + ClassHelper.workers[0].Patron;
            //Вывод даты
            tblAge.Text = tblAge.Text + ClassHelper.workers[0].DateOfBirth.ToShortDateString(); //Последняя ф-я убирает время из даты
            //Вывод должности
            tblDuty.Text = tblDuty.Text + ClassHelper.workers[0].Duty;
            //Вывод картинки
            BitmapImage image = new BitmapImage(ClassHelper.workers[0].PhotoPath); //Создаётся имадж по юри ссылке из поля класса
            imgPhoto.Source = image;
        }
    }
}
