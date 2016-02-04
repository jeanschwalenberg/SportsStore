using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract {
    public interface IProductsRepository {

        //part of the Repository Pattern
        //Allows a caller to obtain a sequence of product objects
        IEnumerable<Product> Products { get; }
    }
}
