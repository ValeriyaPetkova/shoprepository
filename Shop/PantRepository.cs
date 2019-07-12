using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class PantRepository : IProductRepo
    {
        public int GetAmountOfProduct()
        {
            return Pant.counterPants;
        }

        public double GetSumOfProduct()
        {
            double sum = 0;

            for (int i = 0; i < Inventory.products.Count; i++)
            {
                if (Inventory.products[i] is Pant)
                    sum = sum + Convert.ToDouble(Inventory.products[i].Price);
            }
            return sum;
        }
    }
}
