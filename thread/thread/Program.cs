using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace thread
{
   


    internal class Program
    {
        static Thread method1(String tenluong)
        {
            Thread luong = new Thread(() => {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("i cua {0} la {1}", tenluong, i);
                    Console.ResetColor();
                }
            });
            luong.Start();
            return luong;
        }

        // tạo phương thức asynchronous với async/await

        static async Task method(String tenluong,ConsoleColor color)
        {
            Task luong = new Task( () => {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(500);
                    lock (Console.Out)
                    {
                        Console.ForegroundColor = color;                       
                        Console.WriteLine("i cua {0} la {1}", tenluong, i);
                        Console.ResetColor();
                    }
                 
                }
            });
            luong.Start();
              //luong.Wait();
            await luong;
           
            Console.WriteLine("hoan thanh 1");
            //return luong;
        }

        static void array()
        {    
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList1 = new ArrayList(arrayList);
            arrayList1.Add("item1");
            arrayList.Add("item1");
            arrayList.Add("item2");
            arrayList.Remove("item1");
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            //mang 1 chieu
            int[] array = new int[10] ;
            int[] array1 = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }

            foreach (var item in array)
            {
                int i = 0;
                Console.WriteLine("Cac phan tu trong mang la: " +item );
                
            }
            // mang 2 chieu
            int[,] array2 = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    
                    Console.WriteLine(array2[i, j]);
                }
            }

        }

        static void dictionary()
        {   
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");

            string value = (string)hashtable[1];
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("user1", "123");
            dic.Add("user2", "456");
            dic.Add("user3", "789");
            dic.Add("user4", "333");
            



            Console.Write("Nhap username:");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Nhap password:");
            string y = Console.ReadLine();
            
            if (dic.ContainsKey(x)==false)
            {
                Console.WriteLine("Tai khoan khong ton  tai");
            }
            else
            {
                if (dic[x]==y)
                {
                    Console.WriteLine("Dang nhap thanh cong"); 
                }
                else
                {
                    Console.WriteLine("Mat khau sai");
                }
            }
        }

        static void list() {
            List<int> list = new List<int>();
            Console.Write("Nhap vao so phan tu cua ds:");
            int x = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < x; i++)
            {

                Console.Write("Them item vao list:");
                int y = int.Parse(Console.ReadLine());
                list.Add(y);
                if (list[i] < 5)
                {
                    dem++;
                    Console.WriteLine(list.IndexOf(list[i]));
                }


            }
            Console.WriteLine("Co {0} so nho hon 5", dem);
        }
        static void trycatch()
        {
            try
            {
                Console.Write("Nhap vao ngay thang nam sinh:");
                String day = Console.ReadLine();
                DateTime dateTime = DateTime.Parse(day);
                Console.WriteLine("Ngay sinh :" + dateTime.ToString("dd/MM/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cam on da su dung chuong trinh");
            }

        }







        static  void  Main(string[] args)
        {  
            ArrayList arrayList = new ArrayList();
            arrayList.Add("123");
            arrayList.Add(1);
            arrayList.Add(1.2);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            while (true)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Chuong trinh tim kiem");
                Console.WriteLine("1.Asynchronous");
                Console.WriteLine("2.array");
                Console.WriteLine("3.dictionary");
                Console.WriteLine("4.list");
                Console.WriteLine("-------------------------------");
                Console.Write("Bam phim de lua chon:");
                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Asynchronous");
                        method("luong1", ConsoleColor.Blue);
                        method("luong2", ConsoleColor.Red);

                        break;
                    case 2:
                        Console.WriteLine("array");
                        array();
                        break;
                    case 3:
                        Console.WriteLine("dictionary");
                        dictionary();
                        break;
                    case 4:
                        Console.WriteLine("list");
                        break;
                    default:
                        Console.WriteLine("phim bam khong hop le");
                        break;
                }
            }
            }

        }
    }

