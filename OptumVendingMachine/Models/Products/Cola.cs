using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine.Models.Products
{
    public class Cola : Product
    {
        public Cola() : base()
        {
            ID = 1;
            Name = "Cola";
            Price = 1.00;
        }
    }
}
