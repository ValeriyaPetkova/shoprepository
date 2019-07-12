using System;
using System.Collections.Generic;

namespace Shop
{
    public class T_Shirt : Product
    {
        internal static int counterT_Shirt = 0;
        private static double sum = 0;
        public override double Sum { get { return sum; } }

        public T_Shirt(decimal price, string color, string size, string material)
            : base("T-Shirt", price, color, size, material)
        {
          
            sum = sum + Convert.ToDouble(Price);
            counterT_Shirt++;
        }

        public T_Shirt(string type, decimal price, string color, string size, string material)
           : base(type, price, color, size, material)
        {
            sum = sum + Convert.ToDouble(Price);
            counterT_Shirt++;
        }

        public T_Shirt()
        {
            
        }

        public override string ToString()
        {
            return Type + ", " + Color + ", " + Price + "$, " + Size + ", " + Material + Environment.NewLine;
        }

        public override string GetAmount()
        {
            return String.Format("The amount of all T-Shirts is " + counterT_Shirt);
        }

        public override string GetSumOfProduct()
        {
            return String.Format("The sum of all T-Shirts is " + Sum);
        }
    }
}
