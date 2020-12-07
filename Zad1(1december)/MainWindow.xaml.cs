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

namespace Zad1_1december_
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
        Class1 one = new Class1();
        private void button_click(object sender, RoutedEventArgs e)
        {
            string[] strings = textBox.Text.Split(' ');
            int[] ints = new int[strings.Length];
            {
                int iteration = 0;
                foreach (string g in strings)
                {
                    ints[iteration] = Convert.ToInt32(strings[iteration]);
                    iteration++;
                }
            }
            one.Change(ints[0], ints[1]);
            one.Out();
        }
    }
}
