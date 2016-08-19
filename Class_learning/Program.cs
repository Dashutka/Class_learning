using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_learning
{
    public class Program
    {
        static void Main(string[] args) {

            Classes test = new Classes();

            int[] array = new int[10] { 10, 2, 3, 5, 6, 4, 5, 4, 6, 10 };
            //  Console.WriteLine($"{array.Sum([]10)}");

            int a = 4;
            test.AddTen(ref a);
            Console.WriteLine($"{a}");

            if (int.TryParse("12347", out a))
            {
                Console.WriteLine(a);

            } else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();

            string aa = "abc";
            MethodString(aa);
        }

        static void MethodString(string test) {
           // test[0] = test;
            test += "123";
            Console.WriteLine(test);
        }
    }
}
