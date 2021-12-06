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

namespace ксюша_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Triangle triangle = new Triangle();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void углы_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(a.Text, out _) && int.TryParse(b.Text, out _) && int.TryParse(c.Text, out _))
            {
                triangle.Number1 = Convert.ToInt32(a.Text);
                triangle.Number2 = Convert.ToInt32(b.Text);
                triangle.Number3 = Convert.ToInt32(c.Text);

                double corner1;
                double corner2;
                double corner3;
                triangle.Corners(out corner1, out corner2, out corner3);
                MessageBox.Show("углы треугольника с заданными сторонами равна\n" + corner1.ToString()+"\n" + corner2.ToString() + "\n" + corner3.ToString());
            }
            else
            {
                MessageBox.Show("введи правельно");
            }
        }
        private void площадь_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(a.Text, out _) && int.TryParse(b.Text, out _) && int.TryParse(c.Text, out _))
            {
                triangle.Number1 = Convert.ToInt32(a.Text);
                triangle.Number2 = Convert.ToInt32(b.Text);
                triangle.Number3 = Convert.ToInt32(c.Text);

                MessageBox.Show("площадь треугольника с заданными сторонами равна    " + triangle.S().ToString());
            }
            else
            {
                MessageBox.Show("введи правельно");
            }
        }
        private void информация(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы ИСП-31 Митрохина Ксения.Практическая работа №7"+ "\n Использовать класс Triad (тройка положительных чисел). Определить производный класс Triangle с полями - сторонами.Определить методы вычисления углов иплощади треугольника.");
        }

        private void выход(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
