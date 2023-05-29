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
using Number5.Class;
using static Number5.Class.ClassHelper;


namespace Number5
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
            if (string.IsNullOrWhiteSpace(TbName.Text))
            {
                MessageBox.Show("Кличка не может быть пустой");
                return;
            }
            else
            {
                Pet pet = new Pet();
                pet.Name = TbName.Text;
                pet.Kind = CbKind.Text;
                pet.Gender = CbGender.Text;

                TbName.Text = null;
                CbKind.SelectedIndex = 0;
                CbGender.SelectedIndex = 0;

                pets.Add(pet);
                MessageBox.Show("Питомец добавлен");
            }
        }
    }
}
