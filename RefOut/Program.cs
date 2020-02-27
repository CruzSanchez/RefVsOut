using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass by value//
            int myNumber = 100;
            Console.WriteLine($"Number before method: {myNumber}");
            AddToMyNumber(ref myNumber);
            Console.WriteLine($"Number after method: {myNumber}");

            Console.WriteLine("*************************************");

            //Same as above but for a string
            string myString = "";
            Console.WriteLine($"String before method: {myString}");
            AddToMyString(ref myString);
            Console.WriteLine($"String after method: {myString}");

            Console.WriteLine("*************************************");

            //Pass by reference//
            int[] myArray = new int[2] { 100, 200 };
            Console.WriteLine($"Number at index 1 before the method: {myArray[0]}");
            Console.WriteLine($"Number at index 2 before the method: {myArray[1]}");
            AddToMyArray(myArray);
            Console.WriteLine($"Number at index 1 after the method: {myArray[0]}");
            Console.WriteLine($"Number at index 2 after the method: {myArray[1]}");
        }

        private static void AddToMyNumber(ref int number)
        {
            number += 100;
            Console.WriteLine($"Number during method: {number}");
        }
        private static void AddToMyString(ref string input)
        {
            input += "Hello!";
            Console.WriteLine($"String during method: {input}");
        }
        private static void AddToMyArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 25;
                Console.WriteLine($"Number during method: {numbers[i]}");
            }
        }
    }
}
