using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(6, 58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";



            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            //string[] ogrenciler = new string[4];
            //ogrenciler[3] = "İlker";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Züleyha";
            person1.LastName = "Akbaş";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";


            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList
            List<string> yenisehirler1 = new List<string> { "Anlara 1", "İstanbul 1", "İzmir 1" };
            yenisehirler1.Add(item: "Adana 1");

            foreach(string sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();

        }
        //resharper
        static void SelamVer(string isim = "isimsiz")//default parametre verdik
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 =5 , int sayi2=10) 
            //default parametreler yazılacaksa en sona yazılır
            //birinciye yazıp ikinciyi boş bırakamazsın
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc.ToString());
            //normalde stringle int i toplamak için toString ekledik(tür dönüşümü)
            return sonuc;
        }
        

    }



}