using Microsoft.Win32;
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

namespace Number3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathPhoto = @"/res/not_found.jpg"; //Заглушка на случай отсутсвия обложки к фильму
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)//Метод для добавления обложки
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                try //Валидация на формат
                {
                    ImImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    pathPhoto = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Изоображение имеет неверный формат"); 
                }

            }
        }

        private void btnAddFilm_Click(object sender, RoutedEventArgs e)//Метод для добавления фильма в ClassH.films (Лист фильмов)
        {
            if (tbTitle.Text == "" || tbCost.Text == "" || btnpath.Content.ToString() == "...")//Валидация на заполненность полей
            {
                MessageBox.Show("Все поля должны быть заполненными");
                return;
            }
            Film film = new Film();
            film.Title = tbTitle.Text;
            try //Валидация на цену
            {
                film.Cost = Convert.ToDouble(tbCost.Text);
                if (film.Cost < 0)
                {
                    film.Cost = 0;
                    MessageBox.Show("Цена Не может быть отрицацельной");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Цена указана не верно");
                return;
            }
            film.Genre = cmbGenre.Text;
            film.Rating = cmbRating.Text;
            film.VideoPath = btnpath.Content.ToString();
            ClassH.films.Add(film);
            MessageBox.Show($"Фильм {film.Title} успешно добавлен");

        }

        private void btnpath_Click(object sender, RoutedEventArgs e) //Метод для выбора файла для фильма
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                try //Валидация на формат
                {
                    btnpath.Content = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Видео имеет неверный формат");
                }
            }
        }
    }
}
