using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using korehh;

namespace korehh
{
    class kore
    {
        private double r;
        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
            }
        }
        public kore() { }
        public kore(double R) 
        {
            r = R;
        }
        public double hajm()
        {
            double hajm = Math.Pow(r, 3) * 3.1415 * 4.3;
            return hajm;
        }
        public double sath()
        {
            double sath = Math.Pow(r, 2) * 3.1415 * 4;
            return sath;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("r");
            double r = Convert.ToDouble(Console.ReadLine());
            kore ts = new kore(r);
            double Hajm = ts.hajm();
            Console.WriteLine("Hajm" + Hajm);
            double area = ts.sath();
            Console.WriteLine("area" + area);
        }
    }
}
