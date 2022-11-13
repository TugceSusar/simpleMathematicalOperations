using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_soru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool durum = true;
            while (durum)
            {
            devam:
                Console.WriteLine("Basit Matematik İşlemler [1]");
                Console.WriteLine("Basit Geometri İşlemler [2]");
                Console.WriteLine("Bir Seçim Yapınız");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t");
                Console.Clear();
                if (secim == 1)
                {
                    Console.WriteLine("Toplama İşlemi [1]");
                    Console.WriteLine("Çıkarma İşlemi [2]");
                    Console.WriteLine("Çarpma İşlemi [3]");
                    Console.WriteLine("Bölme İşlemi [4]");
                    Console.WriteLine("Bir Seçim Yapınız");
                    int secim1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\t");
                    Console.Clear();
                    switch (secim1)
                    {
                        case 1:
                            {
                                Console.WriteLine("sayı 1 giriniz");
                                double sayi1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("sayı 2 giriniz");
                                double sayi2 = Convert.ToInt32(Console.ReadLine());
                                HesapMakinesi.toplam(sayi1, sayi2);
                                break;
                            }
                        case 2:
                            {

                                Console.WriteLine("sayı 1 giriniz");
                                double sayi1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("sayı 2 giriniz");
                                double sayi2 = Convert.ToInt32(Console.ReadLine());
                                HesapMakinesi.cıkarma(sayi1, sayi2);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("sayı 1 giriniz");
                                double sayi1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("sayı 2 giriniz");
                                double sayi2 = Convert.ToInt32(Console.ReadLine());
                                HesapMakinesi.carpma(sayi1, sayi2);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("sayı 1 giriniz");
                                double sayi1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("sayı 2 giriniz");
                                double sayi2 = Convert.ToInt32(Console.ReadLine());
                                HesapMakinesi.bolme(sayi1, sayi2);
                                break;
                                Console.Clear();
                                
                            }
                            goto bitir;

                    }
                }
               
                if (secim == 2)
                {
                    Console.WriteLine("Dikdörtgen Çevre Hesaplama [1]");
                    Console.WriteLine("Dikdörtgen Alan Hesaplama [2]");
                    Console.WriteLine("Dairenin Çevresini Hesaplama [3]");
                    Console.WriteLine("Dairenin Alanını Hesaplama[4]");
                    Console.WriteLine("Bir Seçim Yapınız");
                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (secim2)
                    {
                        case 1:
                            {
                                Console.WriteLine("uzun kenar değeri giriniz");
                                int ukenar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("kısa kenar değeri giriniz");
                                int kkenar = Convert.ToInt32(Console.ReadLine());
                                Hesaplar.Dikdörtgencevre(ukenar, kkenar);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("uzun kenar değeri giriniz");
                                int ukenar = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("kısa kenar değeri giriniz");
                                int kkenar = Convert.ToInt32(Console.ReadLine());
                                Hesaplar.Dikdörtgenalan(ukenar, kkenar);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("pi sayısını giriniz. / (pi=3)");
                                int pi = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("yarıcap sayısını giriniz");
                                int yaricap = Convert.ToInt32(Console.ReadLine());
                                Hesaplar.Dairecevre(pi, yaricap);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("pi sayısını giriniz. / (pi=3)");
                                int pi = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("yarıcap sayısını giriniz");
                                int yaricap = Convert.ToInt32(Console.ReadLine());
                                Hesaplar.Dairealan(pi, yaricap);
                                break;
                            }
                            Console.Clear();
                            goto bitir;
                    }
                }
                Console.WriteLine("Teşekkürler...");
                bitir:
                Console.ReadLine();
            }
        }
        static public class HesapMakinesi
        {
            static public void toplam(double sayi1, double sayi2)
            {

                double sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplam= " + sonuc);
            }
            static public void cıkarma(double sayi1, double sayi2)
            {
                double cıksonuc = sayi1 - sayi2;
                Console.WriteLine("Cıkarma= " + cıksonuc);
            }
            static public void carpma(double sayi1, double sayi2)
            {

                double carpsonuc = sayi1 * sayi2;
                Console.WriteLine("Çarpma = " + carpsonuc);
            }
            static public void bolme(double sayi1, double sayi2)
            {

                double bolsonuc = sayi1 / sayi2;
                Console.WriteLine("Bölme= " + bolsonuc);
            }
        }



        static public class Hesaplar
        {


            static public int Dikdörtgencevre(int ukenar, int kkenar)
            {
                int dikcevre = 2 * (ukenar + kkenar);
                Console.WriteLine("Dikdörtgen Çevre = " + dikcevre);
                return dikcevre;
            }

            static public int Dikdörtgenalan(int ukenar, int kkenar)
            {
                int dikalan = ukenar * kkenar;
                Console.WriteLine("Dikdörtgen Alan = " + dikalan);
                return dikalan;
            }

            static public int Dairecevre(int pi, int yaricap)
            {

                int dairecevre = 2 * pi * yaricap;
                Console.WriteLine("Daire Çevre = " + dairecevre);
                return dairecevre;

            }
            static public int Dairealan(int pi, int yaricap)
            {
                Console.WriteLine("pi sayısını giriniz");
                pi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("yarıcap sayısını giriniz");
                yaricap = Convert.ToInt32(Console.ReadLine());
                int dairealan = pi * yaricap * yaricap;
                Console.WriteLine("Daire Alan = " + dairealan);
                return dairealan;

            }
        }

    }
}
