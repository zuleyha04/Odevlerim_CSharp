﻿using System;
namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            double number5 = 10.4;
            decimal number6 = 10.4M;//int için double ne ise double için decimal odur. 
            char character = 'A';
            bool condition = false;
            byte number4 = 255;//0-255 arası
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            var number7 = 10;
            number7 = 'A';
            //number7 = "A";

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Character is {0}", (int)character);

            Console.ReadLine();

        }
    }
    //enum klasın dışına yazılır
    //enum değerleride sıfırdan başlar fakat ilk atama yaparak bunu değiştirebilirsin!
    enum Days
    {
        Monday=10,Tuesday,Wednesday=30,Thursday,Friday,Saturday,Sunday
    }

}