using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_learning
{
    class Classes
    {
        public int AddTen(ref int a) {
            a += a;
            return a;
        }
        // out for return more that 2 params

        public int AddAge(int[] test) {
            int count = 0;
            for (int i = 0; i < test.Length; i++)
            {
                count += test[i];
            }
            return count;
        }



        /*  public double Average(params double[] array) {
              double avg = 0;
              foreach (var d in array)
              {

                  return d / array.Length;
              }
       }*/
    }
}