using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    internal class Queries
    {
        public static List<int> PopulationOver18(List<int> population)
        {
            return (List<int>)(from p in population where p >= 18 select p);
        }

        public static void PrintResult(List<int> population)
        {
            foreach (int p in population)
            {
                Console.WriteLine(p);
            }
        }
    }
}
