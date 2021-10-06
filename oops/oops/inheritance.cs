using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class add3 //encapsulation
    {
        public int a { get; set; }
        public int b { get; set; }
        public void add5()
        {
            add4();
        } 
        private void add4()
        {
            if (a > 0 && b > 0)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine( "enter positive ");
            }
        }
    }
    class add2   //polymorphism
    {
        public void add(int a)
        {
            Console.WriteLine(a);
        }
        public void add(double a)
        {
            Console.WriteLine(a);
        }
    }
    public class add1 //inheritance-base class
    {
        public void addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

    public class subtraction : add1 //inheritance-child class
    {
        public void sub(int a, int b)
        {
        Console.WriteLine(a - b);
        }
    }
class inheritance
{
    public static void Main(String[] args)
    {
        subtraction s = new subtraction();
            Console.WriteLine("enter the two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
        s.addition(a,b);
        s.sub(a,b);
            add2 s1 = new add2();
            s1.add(1.1);
            add3 s2 = new add3();
            s2.a = -1;
            s2.b = 1;
            s2.add5();

        }
}
}
