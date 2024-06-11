using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class ConversaoImplicita
    {
        public static void Main(string[] args)
        {
            int myInt = 9;
            double myDouble = myInt; // Conversão automática: int para double

            Console.WriteLine(myInt);       // Saída 9
            Console.WriteLine(myDouble);    // Saída 9
        }
    }
}
