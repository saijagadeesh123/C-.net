using System;
using System.Collections.Generic;
namespace delegates
{
    class employee
    {
        public string name;
        public int salary;
        public int experience;
       /* public static void promote(List<employee> employees)
        {
            foreach(employee e1 in employees)
            {
                if(e1.experience>=2)
                {
                    Console.WriteLine("promote");
                }
            }
        } */ //hard coded cannot reuse so we can use delegate 
 public static void promote(List<employee> employees,ispromote eligible) //this can be used again and again 
{
    foreach(employee e1 in employees)
    {
        if(eligible(e1))
        {
            Console.WriteLine("promote");
        }
    }
}
}
 delegate bool ispromote(employee e1); //delegate creation
 delegate void multicastedelegate();
class delegatesdemo
{
static void Main(string[] args)
{
    List<employee> e = new List<employee>();
    e.Add(new employee() { name = "sai", salary = 3600, experience = 2 });
    e.Add(new employee() { name = "sai", salary = 3600, experience = 3 });
    e.Add(new employee() { name = "sai", salary = 3600, experience = 4 });
    employee.promote(e,e=>e.experience>=2);
            multicastedelegate d1, d2, d3;
            d1 = new multicastedelegate(method1);
            d2 = new multicastedelegate(method2);
            d3 = d1 + d2;  //here d3 is the multicast delegate which points to d1 and d2
            d3();
}
        public static void method1()
        {
            Console.WriteLine("method 1 is invoked");
        }
        public static void method2()
        {
            Console.WriteLine("method 2 is invoked");
        }
    }
}
