using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine.Models.Products
{
    public class Candy : Product
    {
        public Candy() : base()
        {
            ID = 3;
            Name = "Candy";
            Price = 0.65;
        }
    }
}
