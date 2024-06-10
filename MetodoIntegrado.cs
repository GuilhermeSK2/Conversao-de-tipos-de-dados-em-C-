using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class MetodoIntegrado
    {
        public static void Main(string[] args)
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));         // Converter de int para string
            Console.WriteLine(Convert.ToDouble(myInt));         // Converter de int para double
            Console.WriteLine(Convert.ToInt32(myDouble));       // Converter de double para int
            Console.WriteLine(Convert.ToString(myBool));        // Converter de bool para string
        }
    }
}
