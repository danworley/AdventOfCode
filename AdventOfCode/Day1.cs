using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdventOfCode
{
    public class Day1
    {
        public static long Calc(string x)
        {
            if ( x.Length > 1)
            {
                long match = 0;
                if (x[0] == x[1])
                {
                    match = Convert.ToInt64(x[0].ToString());
                }
                var sum = Calc(x.Substring(1));
                return match + sum;
                //var sum = CalcInner(x.Substring(1));
                //return match + sum + Calc($"{x[x.Length - 1]}{x[0]}");//x[i] + x[0]);
            }
            return 0;
        }
        public static long CalcInner(string x)
        {
            for (int i = 0; i < x.Length - 1; i++)
            {
                long match = 0;
                if (x[i] == x[i + 1])
                {
                    match = Convert.ToInt64(x[i].ToString());
                }
                var sum = Calc(x.Substring(1));
                return match + sum;
            }
            return 0;
        }
    }

    [TestFixture]
    public class Day1Tests
    {
        [Test]
        public void returns_sum_of_numbers()
        {
            Assert.That(Day1.Calc("1122"), Is.EqualTo(3));
        }
    }
}
