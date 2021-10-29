using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11T1
{
   
        class Program
        {
            static void Main(string[] args)
            {

                Linear linear = new Linear(32, 52);
                linear.Root();
                Console.ReadKey();

            }
        }
        struct Linear
        {

            double k;//Коэффициент 1
            double b;//Коэффициент 2

            public Linear(double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            public void Root()
            {

                double x = -b / k;
                Console.WriteLine("Переменная x ={0}", x);
            }

        }
    
}
