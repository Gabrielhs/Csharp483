﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dApllicationReferenceTypes
{
    class Delegados
    {
        public void Executar()
        {
            Multiplicacao conta = Triplicar;
            Console.WriteLine(conta(10));

            int Duplicar(int numero)
            {
                return numero * 2;
            }

            int Triplicar(int numero)
            {
                return numero * 3;
            }

            int Quadrado(int numero)
            {
                return numero * numero;
            }
        }
    }
    delegate int Multiplicacao(int numero);

    

    class Teste
    {
        Multiplicacao conta;
        public Teste()
        {
           

            conta = Triplicar;
        }


        int Duplicar(int numero)
        {
            return numero * 2;
        }

        int Triplicar(int numero)
        {
            return numero * 3;
        }

        int Qadriplicar(int numero)
        {
            return numero * 4;
        }
    }
}
