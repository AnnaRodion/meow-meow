using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rates
{
    public class Rates
    {
        public static decimal SumRate(int t, decimal V, int k)
        {
            return (V * t * k + V);
        }

        public static decimal HardRate(decimal j, decimal m, decimal n, decimal P)
        {
            return (decimal)Math.Pow((double)(1 + (j/100) / m), (double)n) * P;
        }
    }
}
