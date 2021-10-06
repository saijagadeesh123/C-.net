using System;
using System.Collections.Generic;

namespace genericcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>(); //creation of a list
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            for (int i = 0; i < primeNumbers.Count; i++)
                Console.WriteLine(primeNumbers[i]);
            primeNumbers.Remove(1);  //removing an element in an list
            for (int i = 0; i < primeNumbers.Count; i++)
                Console.WriteLine(primeNumbers[i]);
            primeNumbers.Insert(1,9); //inserting an elemnt in a list at a certain index
            for (int i = 0; i < primeNumbers.Count; i++)
                Console.WriteLine(primeNumbers[i]);
            Dictionary<int,string> prime = new Dictionary<int,string>();
            prime.Add(1, "One"); //adding a key/value using the Add() method
            prime.Add(2, "Two");
            prime.Add(3, "Three");
            for (int i = 1; i<=prime.Count; i++)
                Console.WriteLine(prime[i]);
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };
            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");
            for (int i=1;i<numberNames.Count;i++)
                Console.WriteLine(numberNames[i]);


        }
    }
}
