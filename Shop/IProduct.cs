using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    interface IProduct
    {
        string GetAmount();
        string GetSumOfProduct();
        double Sum { get; set; }
    }
}
