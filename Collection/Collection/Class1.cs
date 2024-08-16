using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Preson
    {
        int age;
        string name;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Preson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString() {
            return "Name:" + name + "| Age:" + age;
        }
    }

    public class SortPreson : IComparer
    {
        public int Compare(object x,object y) { 
            Preson p1=x as Preson;
            Preson p2 = y as Preson;
            if (p1==null || p2==null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Age<p2.Age)
                {
                    return 1;
                }
                else if (p1.Age==p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

        }
    }
}
