using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Inventory 
    {
        public static List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }
              
        public int GetAllProducts()
        {
            return products.Count;
        }       

        public string GetAllByType(IProduct product)
        {
           return product.GetAmount(); 
        }

        public string GetAllByType(IProduct product, IProduct p)
        {
            return product.GetAmount() + " and " + Environment.NewLine + p.GetAmount();                    
        }

        public string GetSum(IProduct product)
        {
            return product.GetSumOfProduct();
        }

        public string GetSum(IProduct product, IProduct p)
        {
            return product.GetSumOfProduct() + " and " + Environment.NewLine + p.GetSumOfProduct() +
                    Environment.NewLine + "All: " + (product.Sum + p.Sum);
        }        

        public double GetAllSum()
        {
            double sum = 0;
            for (int i = 0; i < products.Count; i++)
            {
                sum += Convert.ToDouble(products[i].Price);
            }
            return sum;
        }
    }
}
