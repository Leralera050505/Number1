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
using System.Xml.Linq;

namespace Number1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CmbGender.ItemsSource = new List<String>() { "M", "Ж" };
            CmbGender.SelectedIndex = 0;
        }

        private void BtmAdd_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //на пустые поля
                if (String.IsNullOrEmpty(TbLactName.Text))
                {
                    MessageBox.Show("Поле имя Пустое");
                    return;
                }
                 if (String.IsNullOrEmpty(TbFirstName.Text))
                {
                    MessageBox.Show("Поле фамлия Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(TbPatronymic.Text))
                {
                    MessageBox.Show("Поле отчество Пустое");
                    return;
                }
                 if (String.IsNullOrEmpty(TbLsctPhone.Text))
                {
                    MessageBox.Show("Поле телефон Пустое");
                    return;
                }
                 if (String.IsNullOrEmpty(DpDate.Text))
                {
                    MessageBox.Show("Поле дата Пустое");
                    return;
                }
                //на спецюсимволы
                if (!TbFirstName.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }
                if (!TbFirstName.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Поле фамилия содержит недопустимые символы");
                    return;
                }
                if (!TbPatronymic.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }
                if (TbLsctPhone.Text.All(Char.IsDigit))
                {

                    MessageBox.Show("Поле имя содержит недопустимые символы");
                    return;
                }

                //на длинну телефона
                if (TbLsctPhone.Text.Length != 11)
                {
                    MessageBox.Show("Телефон неверный");
                    return;
                }

                //проверка даты
                DateTime dateTime = Convert.ToDateTime(DpDate.Text);
                if (dateTime > DateTime.Now || DateTime.Now.Year - dateTime.Year < 18)
                {
                    MessageBox.Show("Некорректная дата");
                    return;
                }

                MessageBox.Show("Пользоваьтель добавлен"); //Имитация добавления
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

    }
}
