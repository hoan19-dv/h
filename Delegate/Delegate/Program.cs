using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegate
{
    delegate void NameInput(string name);

    internal class Program
    {
        public class Preson
        {
            public event NameInput Name;
            public void AddName(string name)
            {
                if (name!=null)
                {   
                    //kich hoat event
                    Name(name);
                }
            }
        }

      delegate void ShowMessage(string message);
        
      delegate int Mydelegate(int x,int y);

      static public int tong(int x, int y) {
            return x + y;     
        
        }
        static public int tich(int x, int y)
        {   
            return x * y;

        }
        
        static void ShowTong(Mydelegate mydelegate)
        {
            Console.Write("Nhap vao x:");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Nhap vao y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua x+y la:" + (x+y));
        }
        static void Main(string[] args)
        {
            Mydelegate mydelegate = new Mydelegate(tong);
            Mydelegate mydelegate2 = new Mydelegate(tich);
            Mydelegate multicast = mydelegate+mydelegate2;
            
            foreach (Mydelegate item in multicast.GetInvocationList())
            {
                Console.WriteLine(item(5, 6));
            }
            ShowTong(tong);

            // phuong thuc nac danh
            ShowMessage showMessage = delegate (string message) {  
                Console.WriteLine(message); 
            };
            showMessage("hello");

            // Event
            Preson preson = new Preson();
            Console.Write("Nhap vao ten:");
            string  x = Console.ReadLine();
                  //dang ky event vs 1 phuong thuc Name
            preson.Name += Name;
            preson.AddName(x);
             void Name (string name)
            {
                Console.WriteLine($"Ten {name}");
            }
            Console.ReadKey();

        }
    }
}
