using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_nangcao
{
    internal class Indexer
    {
        static public int size = 10;
        string[] name = new string[size];
        public Indexer()
        {
            for (int i = 0; i < size; i++)
            {
                name[i] = "NA";
            }
        }
        public string this[int index]
        {
            get
            {
                string x;
                if (index >= 0 && index < size)
                {
                    x= name[index] ;
                }
                else
                {
                    x = "";
                }
                return x;
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    name[index] = value;
                }
            }
        }

        public int this[string namee] {
            get
            {
                int index=0;
                while (index<size)
               {
                    if (name[index]==namee)
                    {
                        return index;
                    }
                    index++;
               }
                return index;
            }
            
        }
    }
}
