using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDashboard.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string NameProducts { get; set; }
        public int Сalorific { get; set; }
        public Products(int id, string nameProducts, int calorific)
        {
            this.Id = id;
            this.NameProducts = nameProducts;
            this.Сalorific = calorific;
        }
    }
}
