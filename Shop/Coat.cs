using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Coat : Product
    {
        private string LengthOfCoat { get; set; }
        internal static int countCoat = 0;
        private static double sum = 0;
        public override double Sum { get { return sum; } }

        public Coat(decimal price, string color, string size, string material)
            : base("Coat", price, color, size, material)
        {
            base.Sum = base.Sum + Convert.ToDouble(Price);
            sum = sum + Convert.ToDouble(Price);
            LengthOfCoat = "Normal";
            countCoat++;
        }

        public Coat(decimal price, string color, string size, string material, string length)
           : base("Coat", price, color, size, material)
        {
            base.Sum = base.Sum + Convert.ToDouble(Price);
            sum = sum + Convert.ToDouble(Price);
            LengthOfCoat = length;
            countCoat++;
        }

        public Coat()
        {

        }

        public override string ToString()
        {
            return Type + ", " + Color + ", " + Price + "$, " + Size + ", " + Material + ", " + LengthOfCoat + Environment.NewLine;
        }

        public override string GetAmount()
        {
            return String.Format("The amount of all coats is " + countCoat);
        }

        public override string GetSumOfProduct()
        {
            return String.Format("The sum of all coats is " + Sum);
        }
    }
}
