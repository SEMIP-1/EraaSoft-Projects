using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Customer
    {
        // CustomerId
        public int Id { get; set; }
        // Name(up to 100 characters, unicode)
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        // Email(up to 80 characters, not unicode)
        public string Email { get; set; } = string.Empty;
        [Column(TypeName = "varchar(80)")]
        // CreaditCardNumber(string)
        public string CreditCardNumber { get; set; } = string.Empty;
        // Sales
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}
