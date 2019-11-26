using System;
using System.Collections.Concurrent;
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

            long bal = 123123_123; // Underline é ignorado no integer pois é só a fim de design; 

            char letra = 'A';




            float NumerComVirgula = 12.123f; // f no final especifica tipo para float somentes simples precisao (single precision)
            float numeroComExpoente = 10e6f;
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

            Console.WriteLine($" A letra {letra} em inteiro é: {(int)letra}" ); 
            // U remove sinal.


            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(numeroComExpoente);
            Console.WriteLine(NumerComVirgula);
            Console.Read();

        }
    }
}
