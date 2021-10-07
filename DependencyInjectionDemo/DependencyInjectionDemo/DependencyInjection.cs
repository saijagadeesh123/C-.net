using System;

namespace DependencyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientservice c = new Clientservice(new studentservice());
            c.clientservice(new teacherservice());
            studentservice s = new studentservice();
            c.s2 = s;
        }
    }
    //client class
    public class Clientservice
    {
        private service s;
        //constructor injection
        public Clientservice(service s1)
        {
            this.s = s1;
            this.s.getfirstname();
            this.s.getlastname();
        }
        //method injection
        public  void clientservice(service s)
        {
            this.s = s;
            this.s.getlastname();
            this.s.getfirstname();
        }
        //property injection
        public service s2
        {
            set { s2= value; }
        }
    }
    public interface service
    {
       void getfirstname();
        void getlastname();
    }
    //service class
    public class studentservice : service
    {
        public void getfirstname()
        {
            Console.WriteLine("student first name");
        }

        public void getlastname()
        {
            Console.WriteLine("student last name");
        }
    }
    //service class
    public class teacherservice : service
    {
        public void getfirstname()
        {
            Console.WriteLine("enter techer first name");
        }

        public void getlastname()
        {
            Console.WriteLine("enter teacher last name");
        }
    }


    /* public class student
      {
          studentservice s = new studentservice();
          public void get()
          {
              s.service()
          }
      }
      public class studentservice    //tightly coupled code if any changes are to be done in service then the student class will also get affected,in order to overcome this dependency injection is used
      {
          public void service()
          {

          }
      } */
}
