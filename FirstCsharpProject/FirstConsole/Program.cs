using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade = 18;
            short bla = 123;

            Console.WriteLine(idade);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(sbyte.MinValue);

            // com sinal somente para byte usa s 'sbyte'
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            // U remove sinal.
            Console.Read();
        }
    }
}
