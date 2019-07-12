using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class CoatRepository : IProductRepo
    {
        public int GetAmountOfProduct()
        {
            return Coat.countCoat;
        }

        public double GetSumOfProduct()
        {
            double sum = 0;

            for (int i = 0; i < Inventory.products.Count; i++)
            {
                if (Inventory.products[i] is Coat)
                    sum = sum + Convert.ToDouble(Inventory.products[i].Price);
            }
            return sum;
        }
    }
}
