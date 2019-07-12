using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public abstract class Product : IProduct
    {
        public string Type { get; private set; }
        public decimal Price { get; private set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }        
        private static int counter = 0;
        public virtual double Sum { get; set; }

        public Product(string type, decimal price, string color, string size, string material)
        {
            Type = type;
            Price = price;
            Color = color;
            Size = size;
            Material = material;            
            counter++;
        }

        public Product()
        {

        }

        public virtual string GetAmount()
        {
            return String.Format("The amount of products is " + counter);
        }

        public virtual string GetSumOfProduct()
        {
            return String.Format("The sum of all products is " + Sum);
        }                          
    }
}
