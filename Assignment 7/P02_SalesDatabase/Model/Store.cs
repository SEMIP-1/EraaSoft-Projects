using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Model
{
    internal class Store
    {
        // StoreId
        public int Id { get; set; }
        // Name(up to 80 characters, unicode)
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(80)")]
        // Sales
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
    }
}
