using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_nangcao
{
    internal class Program
    {

        static void function()
        {
            Conditional.msg("Function");
            function2();
        }
        static void function2()
        {
            Conditional.msg("Function2");
        }

        [Obsolete("Cach 1 da loi thoi nen su dung cach 2", true)]
        static void cach1()
        {
            Console.WriteLine("Cach 1"); 
        }
        static void cach2()
        {
            Console.WriteLine("Cach 2");
        }

        
        static void Main(string[] args)
        {
             
            
            //Attributes
            function();
            // cach1();
            cach2 ();
            var classAttributes = typeof(Testclass).GetCustomAttributes(typeof(MyAttribute),false);
            foreach (MyAttribute attr in classAttributes)
            {
                Console.WriteLine($"Class Attribute: {attr.Description}");
            }
            var methodAttributes = typeof(Testclass).GetMethod("TestMethod").GetCustomAttributes(typeof(MyAttribute), false);
            foreach (MyAttribute attr in methodAttributes)
            {
                Console.WriteLine($"Method Attribute: {attr.Description}");
            }

            Date date = new Date();
            date.Month= 1;
            date.date();

            Indexer name = new Indexer();
            name[0] = "huy";
            name[1] = "hoang";
            name[2] = "duc";
            Console.WriteLine(name["duc"]);
            for (int i = 0; i < Indexer.size; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.ReadKey();
        }
    }
}
