using System;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class SingletonDesignPattern
    {
        static void Main(string[] args)
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Parallel.Invoke(
                () => PrintTeacherDetails1(),
                () => PrintStudentdetails1()
                );
            Parallel.Invoke(
                () => PrintTeacherDetails2(),
                () => PrintStudentdetails2()
                );
        }
        private static void PrintTeacherDetails()
        {
            Singleton1 fromTeacher = Singleton1.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            Singleton1 fromStudent = Singleton1.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
        private static void PrintTeacherDetails1()
        {
            Singleton2 fromTeacher = Singleton2.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails1()
        {
            Singleton2 fromStudent = Singleton2.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
        private static void PrintTeacherDetails2()
        {
            Singleton3 fromTeacher = Singleton3.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails2()
        {
            Singleton3 fromStudent = Singleton3.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
