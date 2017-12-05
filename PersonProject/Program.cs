using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary.Person person = new ClassLibrary.Person(0, "Бенджамин", "Франклин", 84);
            Console.WriteLine(ClassLibrary.StaticClass.StaticMetod(person));
            Console.ReadLine();
            Console.WriteLine(ConstClass.STR + ConstClass.VARIABLE);
            Console.ReadLine();

        }
    }
}
