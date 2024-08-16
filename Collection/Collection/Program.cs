using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("haha");
            arrayList.Add("hello");
            ArrayList arrayList2 = new ArrayList(arrayList);
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
           Console.WriteLine(arrayList.BinarySearch("hello"));
           arrayList.AddRange(arrayList2);
           ArrayList arrayList3 = new ArrayList();
            arrayList3.Add(new Preson("huy",20));
            arrayList3.Add(new Preson("duc", 12));
            arrayList3.Add(new Preson("ha", 25));
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }
            arrayList3.Sort(new SortPreson());
            Console.WriteLine("Sau khi xap xep");
            foreach (var item in arrayList3)
            {
                Console.WriteLine(item);
            }


            // hashtable
            Hashtable ht = new Hashtable();
            ht.Add(1, "a");
            ht.Add(23, "b");
            ht.Add(3, "c");
            ht.Add(4, "d");
            ht.Remove(23);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+" " + item.Value);               
            }

            //SortedList 
            SortedList sortedList = new SortedList(new SortPreson());
            sortedList.Add(new Preson("thanh",4), "t");
            sortedList.Add(new Preson("duc", 29), "d");
            
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key +" "+ item.Value);
            }

            //Stack  vao dau ra cuoi
            Stack stack = new Stack();
            stack.Push(3); //add
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("phan tu dau "+stack.Peek());
            stack.Pop(); //lay ra va xoa phan tu cuoi
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Queue  vao dau ra dau
            Queue queue = new Queue();
            queue.Enqueue(7);//add
            queue.Enqueue(8);
            queue.Enqueue(9);
            Console.WriteLine("phan tu dau " + queue.Peek());
            queue.Dequeue();//lay ra va xoa phan tu dau
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //BitArray
            bool[] bools = new bool[] { true, false, false, false, true };
            bool[] bools2 = new bool[] { false, false, true, false, true };
            int[] ints = new int[] { 1, 2, 3, 4, 5 };
            BitArray bitArray=new BitArray(bools);
            BitArray bitArray2 = new BitArray(bools);
            bitArray.And(bitArray2);
            bitArray.Or(bitArray2);
            bitArray.Xor(bitArray2);
            bitArray.Not();
            bitArray.Set(1, true);
            foreach (var item in bitArray)
            {
                Console.Write(item.GetHashCode());  
            }  

            //Generic 

            void swap<T>(T x, T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }

            swap<int>(5, 7);
            swap<double>(1.9, 1.1);
            Console.ReadKey();
        }
    }
}
