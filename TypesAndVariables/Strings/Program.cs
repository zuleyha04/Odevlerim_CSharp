using System;
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Züleyha Akbaş";

            var result = sentence.Length;//uzunluğunu verir
            var result2 = sentence.Clone();//klonlar
            sentence = "My name is Aslı Akbaş";

            sentence.EndsWith("ğ");//-e ile bitiyor mu? bool cevap verir
            sentence.StartsWith("My name");//-e ile maşlıyor mu ?

            var result5 = sentence.IndexOf("namee");//bir string'de bir karakteri veya ifadeyi arar ,
                                                    //kaçıncı indexten başladığını söyler.Bulamadığında (-1) döndürür.

            var result6 = sentence.IndexOf(" ");//bulduğu ilk boşluğu yazar devam etmez
            var result7 = sentence.LastIndexOf(" ");//aramaya sondan başlar

            var result8 = sentence.Insert(0,"Hello ,");//cümlenin sıfırıncı kararkterinden sonra bu metni ekle

            var result9 = sentence.Substring(3,4);//cümlenin 3.karakterinden başla ve 4 karakter daha al

            var result10 = sentence.ToLower();//bütün karakterleri küçültür
            var result11 = sentence.ToUpper();//bütün kararkterleri büyütür

            var result12 = sentence.Replace(" ", "-");//karakter değişimi yapar.Burada boşluk yerine - koyar

            var result13 = sentence.Remove(2,5);//2. karakterden sonrasını at,sil(burada; 2 den sonra 5 karakter at)

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";


            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}