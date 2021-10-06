using System;

namespace generics
{
    class GenericsDemo
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            Console.WriteLine(num);
            return num;
        }
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            genericsdemo<int> integerGenericClass = new genericsdemo<int>(a, b);
            int val = integerGenericClass.genericMethod(a, b);
            adding<int> s = new adding<int>(AddNum);
            s(20);

        }
        delegate T adding<T>(T n); //generic delegate creation
        class genericsdemo<T>
        {

            //Generic variable
            //The data type is generic
            private T genericMemberVariable, genericMemberVariable1;
            //Generic Constructor
            public genericsdemo(T value, T value1)
            {
                genericMemberVariable = value;
                genericMemberVariable1 = value1;
            }
            //Generic Method
            public T genericMethod(T genericParameter, T genericparameter1)
            {
                dynamic d1 = genericParameter;
                dynamic d2 = genericparameter1;
                dynamic d3 = d1 + d2;
                Console.WriteLine(d3);
                return d3;
            }
            //Generic Property
            //The data type is generic
            public T genericProperty { get; set; }
        }
    }
}
