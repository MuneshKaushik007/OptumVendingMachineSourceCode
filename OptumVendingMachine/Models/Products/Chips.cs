using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine.Models.Products
{
    public class Chips : Product
    {
        public Chips() : base()
        {
            ID = 2;
            Name = "Chips";
            Price = 0.50;
        }
    }
}
