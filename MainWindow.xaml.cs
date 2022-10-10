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

namespace ISRPO_Palashicheva_PR7
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

        private void chips_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {  
            MessageBox.Show("Сыр\nПомидоры\nЗелень\nЧеснок\nМайонез\nКартофельные чипсы\nОливки", "Состав");
        }

        private void kanape_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Помидоры черри\nСыр мини моцарелла\nПесто", "Состав");
        }

        private void rasso_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Спинка куриная\nКартофель\nМорковь\nЛук репчатый\nПерловка\nМасло растительное\nОгурцы соленые\nРассол огуречный", "Состав");
        }
    }
}
