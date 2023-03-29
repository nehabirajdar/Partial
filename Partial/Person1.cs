using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class Calculation
    {
        public int Mul(int a,int b)
        {
            return a * b;
        }

        public int Mod(int a, int b)
        {
            return a % b;
        }

        partial void Sqt(int a)
        {
            Console.WriteLine(a*a);
        }
        public void Test(int a)
        {
            Sqt(a);
        }

    }
}
