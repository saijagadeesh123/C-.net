using System;

namespace accessmodifiers
{
    class privatdemo
    {
        private int age=20; //in order to access private members we need to create public methods for those,creating an inner class,by using properties
       /* class Innerclass //accessing private members using inner class
        {
            static void Main()
            {
                privatdemo s = new privatdemo();
                Console.Write(s.age);
            }
        } */
        public void display()//by creating public method
        {
            Console.WriteLine(age);
        }
    }
    class protecteddemo
    {
        protected int age1 = 20; //protected members cannot be accessed directlt in order to access them the other class must be a derived class
    }
    class internaldemo
    {
        internal int age=20; //internal access modifier which can be accessed in it's containing class
    }
    class protectedinternaldemo
    {
        protected internal int age4=21; //in this in other class if it is inherited from this class then these members can be accessed
    }
    sealed class sealeddemo
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b); 
        }
    }

    class Program : protecteddemo
    {
        static void Main(string[] args)
        {
            privatdemo s = new privatdemo();
         //   s.age = 10; this cannot be done because private members cannot be accessed in another class
            s.display();
            protecteddemo s1 = new protecteddemo();
            // s1.age1 = 20;-cannot be accessed but we can access by creating a object for derived class
            Program s3 = new Program();
            Console.WriteLine(s3.age1);
            internaldemo i2 = new internaldemo();
            Console.WriteLine(i2.age);
            sealeddemo s2 = new sealeddemo();
            s2.Add(4, 5);

            

        }
    }
}
