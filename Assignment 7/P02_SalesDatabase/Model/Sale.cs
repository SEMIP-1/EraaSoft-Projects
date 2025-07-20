using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Sale
    {
        // SaleId
        public int Id { get; set; }
        // Date
        public DateTime Date { get; set; }
        // Product
        public List<Product>? Products { get; set; }
        // Customer
        public List<Customer>? Customers { get; set; }
        // Store
        public List<Store>? Stores { get; set; }
    }
}
