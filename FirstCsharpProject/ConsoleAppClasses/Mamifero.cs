using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClasses
{
    class Mamifero : Animal
    {
        public  void Mamar() // new pode ser usado antes do void para indicar que é o mesmo nome do metodo, mas é outro comportamento.
        // pode ser aplicado o override do, mas no metodo do pai deves er colocado o  virtual no metodo do pai.
        {
            Console.WriteLine("Mamifero mamando");
        }

        public override void Comer()
        {
            Console.WriteLine("Mamifero comendo");
        }
    }

}
