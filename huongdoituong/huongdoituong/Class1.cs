using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    //tinh ke thua 
    // them sealed sau class neu khong muon ke thua
    public class lop
    {  
        string name;
        int age;
        int id;
        public int Age {  get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Id { get { return id; } set { id = value; } }
        public void tongdiem(double toan,double ly, double hoa)
        {
            Console.WriteLine(toan+ly+hoa);
        }
        public void l()
        {
            Console.WriteLine("lop 10");
        }
        
    }
  
    public class sinhvien:lop
    {
       public void ttsv()
        {
            Console.WriteLine("ID sv :" + Id);
            Console.WriteLine("Ten sv :"+Name);
            Console.WriteLine("Tuoi sv :" + Age);
            
            
        }
        
        public new void l() 
        {
            Console.WriteLine("lop 12");
         // goi dem ham lop cha khi ham trung ten
            base.l();
        }
    }

    // tinh da hinh

   abstract class Animal
    {
        
           /* public virtual void speak()
            {
                Console.WriteLine("Animal speaking");
            }*/
        
        public abstract void speak();
        
    }

    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Dog is speaking");
        }
    }

    class Cat:Animal
    {
        public override void speak()
        {
            Console.WriteLine("Cat is speaking");
        }
    }

    // interface
    interface IAnimal { 
        void speak1();
    }

    class pig:IAnimal
    {
       public void speak1()
        {
            Console.WriteLine("Pig is speak");
        }
    }
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int tinhtong()
        {
          return  X + Y;
        }
     
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            bool status = false;
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                status = true;
            }
            return status;
        }
        public static bool operator != (Vector v1, Vector v2)
        {
          
            return !(v1==v2);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
