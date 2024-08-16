#define WINDOWS
#define LINUX
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace huongdoituong
{
    internal class Program
    {   
       
           
        
        static void Main(string[] args)
        {
            // ke thua
            sinhvien class1 = new sinhvien();
            class1.Name = "Hoan";
            class1.Id = 19;
            class1.Age = 20;
            class1.tongdiem(5,6,7);
            class1.ttsv();
            class1.l();
            // da hinh
            Animal dog=new Dog();
            Animal cat=new Cat();
            IAnimal pig=new pig();
            pig.speak1();
            dog.speak();
            cat.speak();
            //nap chong
           Vector v1=new Vector(1,2);
            Vector v2=new Vector(2,3);
            Vector v3 = v1 + v2;
            Vector v4 = v1 - v2;
            Console.WriteLine(v1!=v2);
            Console.WriteLine(v3.tinhtong());
            if (v1==v2)
            {
                Console.WriteLine("v1=v2"); 
            }
            else
            {
                Console.WriteLine("v1!=v2");
            }

            //CHI THI TIEN XU LY
            #if (WINDOWS)
            Console.WriteLine("Chay tren nen tang windows");
#else
            C
#endif
            // regular expression
            string str = "30 may tinh va 40 cai ban";
            Regex regex = new Regex(@"\d+");
            MatchCollection matchCollection = regex.Matches(str);
            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }
                  //Groups
            Regex regex1 = new Regex(@"(?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)");
            foreach (Match item in regex1.Matches("12/8/2024 9:08:19"))
            {
                Console.WriteLine("hours :"+item.Groups["hours"]);
                Console.WriteLine("minutes :" + item.Groups["minutes"]);
                Console.WriteLine("seconds :" + item.Groups["seconds"]);
            }
                  //Captures
            Regex regex2 = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
            foreach (Match item in regex2.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine("time :" + item.Groups["times"]);
                Console.WriteLine("ip :" + item.Groups["ip"]);
                foreach (Capture i in item.Groups["company"].Captures)
                {
                    Console.WriteLine(i);
                }
            }
            // File IO
            DirectoryInfo directoryInfo = new DirectoryInfo(".");
            Console.WriteLine(directoryInfo.FullName);
            DirectoryInfo duongdan = new DirectoryInfo("D:\\GITHUB\\project");
            Console.WriteLine(duongdan.FullName);
            Console.WriteLine(duongdan.Name);
            Console.WriteLine(duongdan.CreationTime);
                  // lay ra thu muc cha
            Console.WriteLine(duongdan.Parent);
                  // lay thuoc tinh
            Console.WriteLine(duongdan.Attributes);
                  // tao thu muc
            DirectoryInfo tm1 = new DirectoryInfo("C:\\new folder");
            tm1.Create();
            tm1.Delete(); 
                  // kt thu muc
            if (Directory.Exists("C:\\new folder"))
            {
                Console.WriteLine("Thu muc da ton tai");
            }
            else
            {
                Console.WriteLine("Thu muc khong ton tai");    
            } 
                 //lay file ben trong 1 thu muc
            string path = "D:\\tailieu";
            string[] ds= Directory.GetFiles(path);
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();  
        }
    }
}
