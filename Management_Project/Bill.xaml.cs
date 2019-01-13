using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Bill.xaml
    /// </summary>
    public partial class Bill : Window
    {
        private bool changeQty = false;
        private bool changeID = false;
        private bool changeBillID = false;
        private bool changeName = false;
        private List<Item> Items = new List<Item>();
        private int totalCost = 0;
        public Bill()
        {
            InitializeComponent();

            // Load data into ListProducts
            List<string> ls = new List<string>();
            ObservableCollection<TonKho> result = DataProvider.getAllProduct();
            int count = result.Count;
            for(int i = 0; i < count; i++)
            {
                ls.Add(result[i].ProductID);
            }
            List_Products.ItemsSource = ls;


        }

        private void List_Products_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            changeQty = true;
            if (changeID && changeQty) AddProduct.IsEnabled = true;

        }

        private void Ten_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n;
            bool isNumeric = int.TryParse(Qty.Text, out n);
            if (isNumeric)
            {
                changeID = true;
                if (changeID && changeQty) AddProduct.IsEnabled = true;
            }
            else changeID = false;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            // Get Products Id  +  Qty
            string ProductID = List_Products.Text;
            string Quantity = Qty.Text;
            Product p = new Product();
            p = DataProvider.GetInfoProduct(ProductID);
            try
            {
                if (p != null)
                {
                    Item it = new Item();
                    it.Cost = (Int32.Parse(p.Cost) * Int32.Parse(Quantity)).ToString();
                    it.Name = p.Name;
                    it.Qty = Quantity;
                    it.ProductID = p.ProductID;
                    Items.Add(it);
                    ListProducts.ItemsSource = null;
                    ListProducts.ItemsSource = Items;
                    Total.Text = (totalCost + Int32.Parse(it.Cost)).ToString();
                }
            }
            catch(Exception )
            {
                // do nothing
            }

        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            changeBillID = true;
            if (changeName && changeBillID) CreateBill.IsEnabled = true;
        }

        private void Ten_TextChanged(object sender, TextChangedEventArgs e)
        {
            changeName = true;
            if (changeName && changeBillID) CreateBill.IsEnabled = true;
        }

        private void CreateBill_Click(object sender, RoutedEventArgs e)
        {
            string customerName = Ten.Text;
            string billID = ID.Text;
            string total = Total.Text;
            bool result = DataProvider.CreateBill(Items,customerName,billID,total);
            if (result)
            {
                MessageBox.Show("Create bill successfully!");
                this.Close();
            }
            else MessageBox.Show("Something went wrong!");
        }
    }

    public class Item
    {
        public string Cost { get; set; }
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string Qty { get; set; }
    }
}
