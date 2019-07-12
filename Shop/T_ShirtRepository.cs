using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class T_ShirtRepository : IProductRepo
    {
        public int GetAmountOfProduct()
        {
            return T_Shirt.counterT_Shirt;
        }

        public double GetSumOfProduct()
        {
            double sum = 0;

            for (int i = 0; i < Inventory.products.Count; i++)
            {
                if (Inventory.products[i] is T_Shirt)
                    sum = sum + Convert.ToDouble(Inventory.products[i].Price);
            }
            return sum;
        }
    }
}
