using ProductStoreApi.Models.EfCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProductStoreApi.Models
{
    public partial class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
