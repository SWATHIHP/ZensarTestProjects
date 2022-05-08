using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Models.EfCore
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
