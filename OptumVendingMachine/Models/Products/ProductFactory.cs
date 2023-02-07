using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine.Models.Products
{
    public class ProductFactory : IProduct
    {
        public Product GetProduct(int id)
        {
            switch (id)
            {
                case 1:
                    return new Cola();
                case 2:
                    return new Chips();
                case 3:
                    return new Candy();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
