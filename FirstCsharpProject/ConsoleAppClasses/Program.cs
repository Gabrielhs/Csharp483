using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            var animal1 = new Animal();
            object animal2 = new Animal();
            dynamic animal3 = new Animal();
            Animal gato = new Mamifero();
     
            animal1.Comer();


            Animal a = (Animal) animal2; // conversao explicita - cast

            Animal cuida = new Animal();
            Mamifero mamam = new Mamifero();
            Animal tosco = new Mamifero();

            animal.Comer();
            mamam.Comer();
            tosco.Comer();

            Console.ReadKey();
        }
    }
}
