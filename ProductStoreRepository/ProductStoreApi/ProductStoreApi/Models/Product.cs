using ProductStoreApi.Models.EfCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProductStoreApi.Models
{
    public partial class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int UnitID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Category category { get; set; }
        public Unit unit { get; set; }
    }
}
