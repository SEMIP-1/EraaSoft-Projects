using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Product
    {
        // ProductId
        public int Id { get; set; }
        // Name(up to 50 characters, unicode)
        public string Name { get; set; }= string.Empty;
        [Column (TypeName = "nvarchar(50)")]
        // Description(up to 250 characters, unicode)
        public string? Description { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        // Quantity(real number)
        public int Quantity { get; set; }
        // Price
        public decimal Price { get; set; }
        // Sales
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}
