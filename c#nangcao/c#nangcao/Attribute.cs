#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace c_nangcao
{
    internal class Conditional
    {
        [Conditional("DEBUG")]
        public static void msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class,AllowMultiple =true)]   
    public class MyAttribute : Attribute
    {
        public string Description { get; }

        public MyAttribute(string description)
        {
            Description = description;
        }
    }

    [MyAttribute("test voi class")]
    public class Testclass
    {
        [MyAttribute("test voi method")]

        public void TestMethod() {
            Console.WriteLine("thuc thi method");
        }
    }
}
