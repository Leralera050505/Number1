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
using static Number6.Classes.ClassH;

namespace Number6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetOrderList();
            tbTitleOrder.Text += " " + DateTime.Now.ToString() + " " + DateTime.Now.DayOfWeek; // Выводит дату время и день недели к заказу (чисто экстеръер)
        }
        void GetOrderList() // Метод для генерации ListView
        {
            LvOrdertList.ItemsSource = OrderItems;
        }
    }
}
