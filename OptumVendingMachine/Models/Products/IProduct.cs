using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine.Models.Products
{
    public interface IProduct
    {
        Product GetProduct(int id);
    }
}
