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

namespace Number2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbFirstName.Text))
                {
                    MessageBox.Show("Имя не может быть пустым");
                    return;
                }
                if (string.IsNullOrWhiteSpace(TbLastName.Text))
                {
                    MessageBox.Show("Фамилия не может быть пустой");
                    return;
                }
                if (string.IsNullOrWhiteSpace(TbNumber.Text))
                {
                    MessageBox.Show("Номер телефона не может быть пустым");
                    return;
                }
                if (Convert.ToInt64(TbNumber.Text) < 0)
                {
                    MessageBox.Show("Номер телефона должна быть заполнена числами");
                    return;
                }
                if (string.IsNullOrWhiteSpace(TbEmail.Text))
                {
                    MessageBox.Show("Почта не может быть пустой");
                    return;
                }
                else
                {
                    Client client = new Client();
                    client.FirstName = TbFirstName.Text;
                    client.LastName = TbLastName.Text;
                    client.MiddleName = TbMiddleName.Text;
                    client.Number = TbNumber.Text;
                    client.Email = TbEmail.Text;
                    client.Gender = CbGender.Text;
                    TbFirstName.Text = null;
                    TbLastName.Text = null;
                    TbMiddleName.Text = null;
                    TbNumber.Text = null;
                    TbEmail.Text = null;
                    CbGender.SelectedIndex = 0;
                    ClassHelper.clients.Add(client);
                    MessageBox.Show("Клиент добавлен");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
