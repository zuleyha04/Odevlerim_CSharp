using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //tek boyutlu dizi tanımlama
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";


            string[] students2 = { "Engin", "Derin", "Salih" };



            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //2 boyutlu diziler
            string[,] regions = new string[5, 3]
            {
                { "istanbul","izmit","balıkesir"},
                { "ankara","konya","kırıkkale"},
                { "antalya","adana","mersin"},
                { "rize","trabzon", "samsun"},
                { "izmir","muğla","manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("********");
            }

            Console.Read();
        }
    }
}