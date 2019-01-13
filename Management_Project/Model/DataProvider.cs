using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Project.Model
{
    class DataProvider
    {
        public static bool checkLogin(String username, String password)
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var dataset = db.Users.Where(x => x.Username == username && x.Password == password).ToList();
            if (dataset.Count > 0) return true;
            return false;
        }
        
        public static ObservableCollection<TonKho> getAllProduct()
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            var dataset = db.Products.Where(x => x.isDeleted == "0").ToList();
            ObservableCollection<TonKho> result = new ObservableCollection<TonKho>();
            for (int i = 0; i < dataset.Count; i++)
            {
                TonKho temp = new TonKho();
                temp.STT = (i+1).ToString();
                temp.Name = dataset[i].Name;
                temp.ProductID = dataset[i].ProductID;
                temp.CategoryID = dataset[i].CategoryID;
                temp.Cost = dataset[i].Cost;
                result.Add(temp);
            }
            return result;
        }

        public static bool AddProduct(string Ten_SP, string ID_SP, string Gia_SP, string Loai_SP)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                Product product = new Product();
                product.Name = Ten_SP;
                product.isDeleted = "0";
                product.ProductID = ID_SP;
                product.Cost = Gia_SP;
                product.CategoryID = Loai_SP;
                db.Products.Add(product);
                int res = db.SaveChanges();
                if (res > 0) return true;
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        public static bool DeleteProducts(string ID)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var itemToRemove = db.Products.SingleOrDefault(x => x.ProductID == ID); //returns a single item.

                if (itemToRemove != null)
                {
                    db.Products.Remove(itemToRemove);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UpdateProducts(string Ten_SP, string ID_SP, string Gia_SP, string Loai_SP)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                Product p = db.Products.First(x => x.ProductID == ID_SP);
                p.Name = Ten_SP;
                p.CategoryID = Loai_SP;
                p.Cost = Gia_SP;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static ObservableCollection<Category1> getAllCategory()
        {
            QuanLyBanHangEntities db = new QuanLyBanHangEntities();
            ObservableCollection<Category1> result = new ObservableCollection<Category1>();
            var dataset = db.Categories.Where(x => x.isDeleted == "0").ToList();
            for (int i = 0; i < dataset.Count; i++)
            {
                Category1 temp = new Category1();
                temp.STT = i + 1;
                temp.Name = dataset[i].Name;
                temp.CategoryID = dataset[i].CategoryID;
                result.Add(temp);
            }
            return result;
        }

        public static bool AddCategory(string CategoryID, string Name)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                Category category = new Category();
                category.isDeleted = "0";
                category.CategoryID = CategoryID;
                category.Name = Name;
                db.Categories.Add(category);
                int res = db.SaveChanges();
                if (res > 0) return true;
                return false;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool DeleteCategory(string CategoryID)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var itemToRemove = db.Categories.SingleOrDefault(x => x.CategoryID == CategoryID); //returns a single item.
                if (itemToRemove != null)
                {
                    db.Categories.Remove(itemToRemove);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UpdateCategory(string CategoryID,string CategoryName)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                Category p = db.Categories.First(x => x.CategoryID == CategoryID);
                p.Name = CategoryName;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
       
        public static Product GetInfoProduct(string ProductID)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                Product p = new Product();
                p = db.Products.First(x => x.ProductID == ProductID);
                return p;
            }
            catch (Exception e)
            {
                return new Product();
            }
        }

        public static bool CreateBill(List<Item> items,string CustomerName,string BillID,string Total,string tt)
        {
            try
            {
                // Insert into table Bill
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                Bill ItemBill = new Bill();
                ItemBill.Total = Total;
                ItemBill.CustomerName = CustomerName;
                ItemBill.Bill_ID = BillID;
                ItemBill.TrangThai = tt;
                DateTime today = DateTime.Today;
                ItemBill.Created_at = today;
                db.Bills.Add(ItemBill);
                // Insert into table BillInfo
                for (int i = 0; i < items.Count; i++) {
                    BillInfo billInfo = new BillInfo();
                    billInfo.Bill_ID = BillID;
                    billInfo.ProductID = items[i].ProductID;
                    billInfo.Qty = Int32.Parse(items[i].Qty);
                    db.BillInfoes.Add(billInfo);
                }
                int res = db.SaveChanges();
                if (res > 0) return true;
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static List<KeyValuePair<string, int>> GetRevenue(DateTime start,DateTime end)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var ListDate = db.Bills.Where(m => m.Created_at >= start && m.Created_at <= end).Select(m => m.Created_at).Distinct().ToList();
                //Find total Revenue in this date
                List<int> TotalRevenue = new List<int>();
                for(int i = 0; i < ListDate.Count; i++)
                {
                    DateTime d = DateTime.Parse(ListDate[i].ToString());
                    var count = db.Bills.Where(x => x.Created_at == d).ToList();
                    int total = 0;
                    for (int j = 0; j < count.Count; j++)
                    {
                        total += Int32.Parse(count[j].Total);
                    }
                    TotalRevenue.Add(total);
                }
                List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
                for(int i = 0; i < ListDate.Count; i++)
                {
                    DateTime d = DateTime.Parse(ListDate[i].ToString());
                    valueList.Add(new KeyValuePair<string, int>(d.ToString("dd/MM/yyyy"), TotalRevenue[i]));
                }
                return valueList;


            }
            catch (Exception e)
            {
                List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
                return valueList;

            }
        }

        public static List<KeyValuePair<string, int>> GetProducts(DateTime start, DateTime end)
        {
            try
            {
                QuanLyBanHangEntities db = new QuanLyBanHangEntities();
                var dataset = (from p in db.Bills
                               join q in db.BillInfoes
                               on p.Bill_ID equals q.Bill_ID
                               where p.Created_at >= start && p.Created_at <= end
                               select q
                              ).ToList();
                List<string> ProductID = new List<string>();
                List<string> ProductName = new List<string>();
                List<int> Qty = new List<int>();
                for(int i = 0; i < dataset.Count; i++)
                {
                    int index = ProductID.IndexOf(dataset[i].ProductID);
                    int t = Int32.Parse(dataset[i].Qty.ToString());
                    if (index != -1)
                    {
                        Qty[index] = Qty[index] + t;
                    }
                    else {
                        ProductID.Add(dataset[i].ProductID);
                        Qty.Add(t);
                    }
                }
                for(int i = 0; i < ProductID.Count; i++)
                {
                    string str = ProductID[i].Trim();
                    Product p = db.Products.First(x => x.ProductID == str);
                    ProductName.Add(p.Name);
                }

                List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
                for(int i = 0;i< ProductName.Count; i++)
                {
                    string Name = ProductName[i].Trim();
                    valueList.Add(new KeyValuePair<string, int>(Name, Qty[i]));
                }
                return valueList;


            }
            catch (Exception e)
            {
                List<KeyValuePair<string, int>> valueList = new List<KeyValuePair<string, int>>();
                return valueList;

            }
        }
    }

    public class TonKho
    {
        public string STT { get; set; }
        public string Name { get; set; }
        public string ProductID { get; set; }
        public string CategoryID { get; set; }
        public string Cost { get; set; }

    }

    public class Category1
    {
        public int STT { get; set; }
        public string CategoryID { get; set; }
        public string Name { get; set; }
    }
}
