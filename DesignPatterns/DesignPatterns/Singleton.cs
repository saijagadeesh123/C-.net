using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //singleton pattern with no thread safe
   public sealed class Singleton    //We created the Singleton class as sealed which ensures that the class cannot be inherited and object instantiation is restricted in the derived class.
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton() //The class is created with a private constructor which will ensure that the class is not going to be instantiated from outside the class.
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    //thread-safe singleton design patternss 
    public sealed class Singleton1
    {
        private static int counter = 0;
        private static Singleton1 instance = null;
        public static Singleton1 GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton1();
                return instance;
            }
        }
        private Singleton1()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    //acheiving multi-threading using locks
    public sealed class Singleton2
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private Singleton2()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static Singleton2 instance = null;

        public static Singleton2 GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    //lazy initilization
    public sealed class Singleton3
    {
        private static int counter = 0;
        private Singleton3()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Lazy<Singleton3> Instancelock =
                    new Lazy<Singleton3>(() => new Singleton3());
        public static Singleton3 GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
