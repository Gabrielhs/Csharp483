using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dApllicationReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassesObject MyClass = new ClassesObject();
            ClassesObject Myclass2 = new ClassesObject();
            ClassesObject MyClass3 = new ClassesObject(){Idade = 14, Nome = "Bla"};
            MyClass.Idade = 1;
            MyClass.Nome = "PowerGirl";

            Myclass2 = MyClass;

            Myclass2.Idade = 3;
            Console.WriteLine(Myclass2.Idade);
            Console.WriteLine(Myclass2.Nome);
            Console.WriteLine(MyClass.Idade);
            Console.WriteLine(MyClass.Nome);
            Console.WriteLine(MyClass3.Idade);
            Console.WriteLine(MyClass3.Nome);
            //Console.WriteLine(Myclass2.GetType().get);



            Console.Read();
        }
    }
}
