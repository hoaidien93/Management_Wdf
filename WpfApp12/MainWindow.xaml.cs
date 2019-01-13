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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            HDEntities hd = new HDEntities();
            HD info = new HD()
            {
                Name = "HoaiDien5",
                Password = "HoaiDien",
                Username = "HoaiDien1"
            };
            //var us = hd.HDs.Where(b => b.Name == "HoaiDien");
            hd.HDs.Add(info);
            hd.SaveChanges();
            DtGrid.ItemsSource = hd.HDs.ToList();
        }

        private void DtGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
