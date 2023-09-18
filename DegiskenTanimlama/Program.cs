using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTanimlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YORUM SATIRI
            //Değişken türü, Değiken adı,Atama operatörü,Başlangıç değerei,Satır Atama

            //TAM SAYI OPERATÖRLERİ
            //Byte 8 bitlik yer kaplar 0 ile 255 arasında değer alabilir
            //Byte negatif sayı alamaz
            //ÖDEV neden byte türü maximum 255 alabilir, açıklayınız.

            Byte sayi1 = 45;
            Console.WriteLine(sayi1);

            //16 byte'lik yer kullanan
            short shrt = 300;
            Console.WriteLine(shrt);

            //32 byte'lik yer kullanan
            int tamsayi = 654454;
            Console.WriteLine(tamsayi);

            //64 Byte'lik yer kaplayan
            long lng = 65651;
            Console.WriteLine(lng);

            //ONDALIK DEĞİŞKENLER
            //float'a atılan  değerin sonuna mutlaka f eklenmelidir
            //float 32 byte'lik yer kaplar
            float bilimsel = 45.2f;
            Console.WriteLine(bilimsel);

            //double 64 byte'lik yer kaplar
            double ondalik = 45.3d;
            Console.WriteLine(ondalik);

            //128 bytle'lik yer kaplar
            decimal parasal = 45.4m;
            Console.WriteLine(parasal);

            //Metinsel değişkenler 
            //Sadece bir karakter alabilir
            char karakter = 'A';
            Console.WriteLine(karakter);

            //Karakterlerin sayısal değerini alma
            int sayisal = Convert.ToInt32(karakter);
            Console.WriteLine(sayisal);

            //Sayısal değer aralıkları**
            //A-Z 65-90
            //a-z 97-122

            string metin = "metin";

        }
    }
}
