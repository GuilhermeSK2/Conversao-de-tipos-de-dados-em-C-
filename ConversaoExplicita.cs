using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_de_tipos_de_dados_em_C_
{
    internal class ConversaoExplicita
    {
        public static void Main(string[] args)
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;     // Conversão manual: double para int
            Console.WriteLine(myInt);       // Saída 9.78
            Console.WriteLine(myDouble);    // Saída 9
        }
    }
}
