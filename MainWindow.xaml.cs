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

        int price;
        float a;
        float i=1;
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
        private void borsh_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Говядина\nСвёкла\nМорковь\nЛук\nТоматная паста\nМасло\nКапуста\nКартофель\nЛавровый лист\nСметана", "Состав");
        }
        private void karbonara_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Спагетти\nОливковое масло\nЧеснок\nВетчина\nЯичный желток\nТертый сыр пармезан\nСливки\nСоль\nМолотый черный перец", "Состав");
        }
        private void golybci_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Капуста\nЛук репчатый\nМорковь\nСвинина\nТоматный сок\nРис\nПерец\nРастительное масло", "Состав");
        }

        private void limonad_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Лимонный сок\nВода\nСахар", "Состав");
        }
        private void kompot_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ягоды замороженные\nВода\nСахар", "Состав");
        }
        private void dennoch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Сахар\nСметана\nПшеничная мука\nКуриные яйца\nПищевая сода\nКакао-порошок\nСгущенное молоко", "Состав");
        }

        private void krasn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Пшеничная мука\nСахар\nКакао-порошок\nСода\nРазрыхлитель\nКуриные яйца\nМасло\nСливки\nСметана\nКрасный пищевой краситель", "Состав");
        }

        private void rass_Click1(object sender, RoutedEventArgs e)
        {
            price = 160;
          
                zakaz.Text += "№" + Convert.ToString(i++) + "Рассольник цена " + Convert.ToString(price) + " рублей" + Environment.NewLine;
                a = float.Parse(itog.Text);
                itog.Text = Convert.ToString(a + price);
            
        }

        private void borsh_Click_2(object sender, RoutedEventArgs e)
        {
            price = 200;
            zakaz.Text += "№" + Convert.ToString(i++) + "Борщ цена " + Convert.ToString(price) + " рублей" + Environment.NewLine;
            a = float.Parse(itog.Text);
            itog.Text = Convert.ToString(a + price);
        }

        private void karbonara_Click_3(object sender, RoutedEventArgs e)
        {
            price = 320;
            zakaz.Text += "№" + Convert.ToString(i++) + "Паста карбонара цена " + Convert.ToString(price) + " рублей" + Environment.NewLine;
            a = float.Parse(itog.Text);
            itog.Text = Convert.ToString(a + price);
        }

        private void golybci_Click_4(object sender, RoutedEventArgs e)
        {
            price = 100;
            zakaz.Text += "№" + Convert.ToString(i++) + "Ленивые голубцы цена " + Convert.ToString(price) + " рублей" + Environment.NewLine;
            a = float.Parse(itog.Text);
            itog.Text = Convert.ToString(a + price);
        }

    }
}
