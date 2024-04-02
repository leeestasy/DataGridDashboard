using DataGridDashboard.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDashboard.ViewModel
{
    public class ProductsViewModel
    {
        public ObservableCollection<Products> ListProducts { get; set; } = new
        ObservableCollection<Products>();
        public ProductsViewModel()
        {
            this.ListProducts.Add(new Products
            {
                Id = 1,
                NameProducts = "ааа",
                Сalorific = "456",
            });
            this.ListProducts.Add(new Products
            {
                Id = 2,
                NameProducts = "ааааап",
                Сalorific = "123",
            });
            this.ListProducts.Add(new Products
            {
                Id = 3,
                NameProducts = "апа",
                Сalorific = "233",
            });
        }
    }
}
