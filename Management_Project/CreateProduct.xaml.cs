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
using System.Windows.Shapes;
using Management_Project.Model;

namespace Management_Project
{
    /// <summary>
    /// Interaction logic for CreateProduct.xaml
    /// </summary>
    public partial class CreateProduct : Window
    {
        public CreateProduct()
        {
            InitializeComponent();
            this.DataContext = this;
            List<string> data = new List<string>();
            int count = DataProvider.getAllCategory().Count;
            for (int i = 0; i < count; i++)
            {
                string categoryID = DataProvider.getAllCategory()[i].CategoryID;
                if (!data.Contains(categoryID))
                        data.Add(categoryID);
            }
            Category.ItemsSource = data;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string Id_SP, Loai_SP, Gia_SP, Ten_SP;
            Id_SP = ID.Text;
            Gia_SP = Gia.Text;
            Loai_SP = Category.Text;
            Ten_SP = Ten.Text;
            bool res = DataProvider.AddProduct(Ten_SP, Id_SP, Gia_SP, Loai_SP);
            if (res) MessageBox.Show("Insert successfully !");
            else
                MessageBox.Show("Something went wrong! ");

        }
    }
}
