using CSharp483.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppData
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaRepositorio pRepos = new PessoaRepositorio();
            var lista = pRepos.ListarTodos();
            foreach (var p in lista)
            {
                Console.WriteLine( $"{p.Id}, {p.Nome}, {p.Idade} ");
                    
            }

            Console.Read();

        }
    }
}
