using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltIn
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public static bool IsLegalAge(int age)
        {
            return age >= 18;
        }
    }
}
