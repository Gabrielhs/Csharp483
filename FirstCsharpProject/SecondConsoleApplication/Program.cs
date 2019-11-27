using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            float salario = 100.49f;
            float aumento = 50.51f;

            float salarioComAumento = 151.00f;
            // problemas com arredondamento com  tipo de variavel float;
            Console.WriteLine($"salario: {salario}, aumento: {aumento}  e salario com aumento : {salarioComAumento}");
            Console.WriteLine(salario + aumento);
            Console.WriteLine((salario + aumento) == salarioComAumento);

            bool validacao = true;
            bool resultado = (10 % 2 == 1); // sobra da divisão. w
            Console.WriteLine(resultado);

            if (resultado == validacao)
            {
                Console.WriteLine("bla bla bla");
            }
            else
            {
                Console.WriteLine(" xablau !! ");
            }

            Console.Read();
            

        }
    }
}
