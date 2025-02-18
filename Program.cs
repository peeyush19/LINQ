using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace LINQ_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] age = { 25, 45, 16, 14, 19, 20, 24, 30 };

            var a = from i in age where i > 20 select i;
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
