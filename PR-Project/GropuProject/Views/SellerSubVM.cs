using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GropuProject.Views
{
    public partial class SellerSubVM : ObservableObject
    {
        [ObservableProperty]
        public int id;
       

        [ObservableProperty]
        public string proName;

        [ObservableProperty]
        public int proPrice;

        [ObservableProperty]
        public int proQuantity;

        [ObservableProperty]
        public int salesTax;

        [ObservableProperty]
        ObservableCollection<Person1> products;

        public Person1 SelectedProduct { get; set; }



        [RelayCommand]
        public void AddProduct()
        {
            Person1 p1 = new Person1() { Id = Id, ProName = ProName, ProPrice = ProPrice, SalesTax = SalesTax, ProQuantity=ProQuantity };
            using (var db = new Person1Context())
            {
                db.Products.Add(p1);
                db.SaveChanges();
                Id = 0;
                ProName = "";
                ProPrice = 0;
                ProQuantity = 0;
                SalesTax = 0;
            }
            LoadPerson();


        }

        [RelayCommand]
        public void UpdateProducts()
        {
            if (SelectedProduct == null)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }
            using (var db = new Person1Context())
            {

                var selectedProduct = db.Products.FirstOrDefault(p => p.Id == SelectedProduct.Id);

                if (selectedProduct != null)
                {

                    selectedProduct.ProName = ProName;
                    selectedProduct.ProPrice = ProPrice;
                    selectedProduct.ProQuantity = ProQuantity;
                    selectedProduct.SalesTax = SalesTax;


                    db.SaveChanges();
                    Id = 0;
                    ProName = "";
                    ProPrice = 0;
                    ProQuantity = 0;
                    SalesTax = 0;

                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }
        [RelayCommand]
        public void DeleteProduct()
        {
            if (SelectedProduct == null)
            {
                MessageBox.Show("Please select a person to delete.");
                return;
            }

            using (var db = new Person1Context())
            {

                var selectedProduct = db.Products.FirstOrDefault(p => p.Id == SelectedProduct.Id);

                if (selectedProduct != null)
                {

                    db.Products.Remove(selectedProduct);


                    db.SaveChanges();


                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }

        public Person1 GetPersonById(int id)
        {
            using (var db = new Person1Context())
            {
                return db.Products.FirstOrDefault(p => p.Id == id);
            }
        }
        [RelayCommand]
        private void ReadProduct()
        {
            if (id == 0)
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            Person1 product = GetPersonById(id);

            if (product != null)
            {
                MessageBox.Show($"Id: {product.Id}\nProName: {product.ProName}\nProPrice: {product.ProPrice}\nProQuantity: {product.ProQuantity}\nSalesTax: {product.SalesTax}");
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }





        public void LoadPerson()
        {
            using (var db = new Person1Context())
            {
                var list = db.Products.OrderByDescending(p => p.Id).ToList();
                Products = new ObservableCollection<Person1>(list);
            }
        }
        public SellerSubVM()
        {
            LoadPerson();

        }
    }
}
