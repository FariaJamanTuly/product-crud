using Employee.Shared.Common;
using Employee.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
    public class Products : BaseAuditableEntity, IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public Country? Countries { get; set; }
        public double Rating { get; set; }
        public double price { get; set; }
        public double SellPrice { get; set; }
        public string BarCode { get; set; }
        public string? ImagePath { get; set; }

    }
}
