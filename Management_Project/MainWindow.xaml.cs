﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public int itemPerPage = 8;
        public ObservableCollection<TonKho> TonKhoList { get; set; }
        public int currentPage = 0;
        public MainWindow()
        {
            InitializeComponent();
            updateData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CreateProduct product = new CreateProduct();
            product.Closed += (s, args) => this.updateData();
            product.Show();

        }
        public void updateData()
        {
            ListProducts.ItemsSource = null;
            TonKhoList = new ObservableCollection<TonKho>();
            this.DataContext = this;
            int count = DataProvider.getAllProduct().Count;
            for (int i = currentPage * itemPerPage; i < count; i++)
            {
                this.TonKhoList.Add(DataProvider.getAllProduct()[i]);
                if (i % itemPerPage == itemPerPage - 1) break;
            }
            ListProducts.ItemsSource = TonKhoList;
            if ((currentPage + 1) * itemPerPage >= count)
            {
                Next.IsEnabled = false;
            }
            else Next.IsEnabled = true;
            if (currentPage > 0) Previous.IsEnabled = true;
            else Previous.IsEnabled = false;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int count = ListProducts.SelectedItems.Count;
            for (int x = 0; x < count; x++)
            {
                var product = ListProducts.SelectedItems[x] as TonKho;
                DataProvider.DeleteProducts(product.ProductID);
            }
            if (count > 0) MessageBox.Show("Delete " + count + " row successfully!");
            else MessageBox.Show("Nothing to delete");
            updateData();

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            int count = ListProducts.SelectedItems.Count;
            if (count == 0)
            {
                MessageBox.Show("Nothing to change");
                return;
            }
            ChangeProducts newWindow = new ChangeProducts();
            for (int x = 0; x < count; x++)
            {
                var product = ListProducts.SelectedItems[x] as TonKho;
                newWindow.ID.Text = product.ProductID.Trim();
                newWindow.Ten.Text = product.Name.Trim();
                newWindow.Gia.Text = product.Cost.Trim();
                newWindow.Loai.Text = product.CategoryID.Trim();
            }
            newWindow.Closed += (s, args) => this.updateData();
            newWindow.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            currentPage++;
            updateData();
        }
        private void Previous_Click_1(object sender, RoutedEventArgs e)
        {
            currentPage--;
            updateData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Bill window = new Bill();
            window.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ThongKeDoanhThu window = new ThongKeDoanhThu();
            window.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ThongKeSanPham window = new ThongKeSanPham();
            window.Show();
        }

        private void ListProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Delete.IsEnabled = true;
            Change.IsEnabled = true;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ThongKeChiTiet window = new ThongKeChiTiet();
            window.Show();
        }
    }
}
