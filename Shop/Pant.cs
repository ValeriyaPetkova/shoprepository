using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Pant : Product
    {
        internal static int counterPants = 0;        
        private string TypeOfPant { get; set; }
        private static double sum = 0;
        public override double Sum { get { return sum; } }

        public Pant(decimal price, string color, string size, string material)
            : base("Pant", price, color, size, material)
        {
            base.Sum = base.Sum + Convert.ToDouble(Price);
            sum = sum + Convert.ToDouble(Price);
            counterPants++;
            TypeOfPant = "Casual Pants";
        }

        public Pant(decimal price, string color, string size, string material, string kindOfPants)
           : base("Pant", price, color, size, material)
        {
            base.Sum = base.Sum + Convert.ToDouble(Price);
            sum = sum + Convert.ToDouble(Price);
            counterPants++;
            TypeOfPant = kindOfPants;
        }

        public Pant()
        {

        }

        public override string ToString()
        {
            return Type + ", " + Color + ", " + Price + "$, " + Size + ", " + Material + ", " + TypeOfPant + Environment.NewLine;
        }

        public override string GetAmount()
        {
            return String.Format("The amount of all pants is " + counterPants);
        }

        public override string GetSumOfProduct()
        {
            return String.Format("The sum of all pants is " + Sum);
        }
    }
}
