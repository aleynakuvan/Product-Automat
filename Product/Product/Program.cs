using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********HOŞGELDİNİZ********");

            string[] urun = { "kola", "bisküvi", "çikolata" };
            int[] fiyat = { 7, 3, 2 };
            while (true)
            {
                Console.WriteLine("1-Kullanıcı Girişi\n2-Çıkış");
                Console.Write("İşleminiz:");
                int Aislem = Convert.ToInt32(Console.ReadLine());
                if (Aislem == 1)
                {

                    Console.WriteLine("Kullanıcı Adı:");
                    string username = Console.ReadLine().ToLower();
                    if (username == "admin")
                    {
                        while (true)
                        {
                            Console.WriteLine("********MENÜ***************");
                            Console.Write("1-Ürün Çıkarma\n2-Ürün Ekleme\n3-Fiyat Güncelleme\nİşleminiz:");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim == 1)
                            {
                                for (int i = 0; i < urun.Length; i++)
                                {
                                    Console.WriteLine($"{i}-" + urun[i]);

                                }
                                try
                                {
                                    Console.WriteLine("Çıkarmak istediğiniz ürünün numarasını yazın:");
                                    int cikar = Convert.ToInt32(Console.ReadLine());

                                    Array.Clear(urun, cikar, 1);

                                    Console.WriteLine("İşlem Başarılı...");
                                    Thread.Sleep(3000);

                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Hatalı İşlem Numarası...");

                                }

                            }

                            else if (secim == 2)
                            {
                                Console.WriteLine("Kaç ürün ekliceksiniz:");
                                int ekles = Convert.ToInt32(Console.ReadLine());

                                Array.Resize(ref urun, (3 + ekles));
                                Array.Resize(ref fiyat, (3 + ekles));
                                for (int i = 0; i < ekles; i++)
                                {
                                    Console.WriteLine("Ürün Adı:");
                                    string yurun = Console.ReadLine().ToLower();
                                    Console.WriteLine("Ürün Fiyatı:");
                                    int yfiyat = Convert.ToInt32(Console.ReadLine());
                                    fiyat[i + 3] = yfiyat;
                                    urun[i + 3] = yurun;

                                }

                                Console.WriteLine("İşlem Başarılı...");
                                Thread.Sleep(3000);

                            }

                            else if (secim == 3)
                            {
                                for (int i = 0; i < urun.Length; i++)
                                {
                                    Console.WriteLine($"{i}-" + urun[i]);

                                }



                                Console.WriteLine("Fiyatı güncellencek olan ürünün numarasını yazınız:");
                                int guncel = Convert.ToInt32(Console.ReadLine());


                                for (int i = 0; i < urun.Length; i++)
                                {

                                    if (guncel == i)
                                    {
                                        Console.Write("Fiyatı:" + fiyat[i] + "TL\n");

                                        Console.Write("Yeni Fiyatı:");
                                        int yfiyat = Convert.ToInt32(Console.ReadLine());
                                        fiyat[i] = yfiyat;
                                        Console.WriteLine("İşlem Başarılı...");
                                        Thread.Sleep(3000);

                                    }
                                    else if (guncel != i)
                                        Console.WriteLine("Hatalı ürün numarası..");
                                    break;



                                }


                            }

                            else
                            {
                                Console.WriteLine("Hatalı İşlem Girişi.Tekrar Deneyin...");

                            }
                            Console.Write("1-Anamenü\n2-Hesaptan Çıkış\nİşleminiz:");
                            int islem = Convert.ToInt32(Console.ReadLine());
                            if (islem == 1)
                            {

                            }
                            else if (islem == 2)
                            {

                                break;
                            }

                        }
                    }

                    else if (username == "member")
                    {
                        while (true)
                        {
                            Console.WriteLine("********Ürünlerimiz********");

                            for (int i = 0; i < urun.Length; i++)
                            {

                                Console.WriteLine($"{i}-" + urun[i]);

                            }
                            Console.WriteLine("**************************");
                            Console.WriteLine("İstediğiniz Ürünün Adını Yazınız.");
                            string secim = Console.ReadLine();

                            int a = Array.IndexOf(urun, secim);

                            if (a == -1)
                            {
                                Console.WriteLine("Hatalı ürün girişi....");
                            }
                            else

                            {
                                Console.WriteLine("Ürünün Fiyatı:" + fiyat[a] + "TL");
                                while (true)
                                {
                                    Console.Write("Ödemek İstediğiniz Tutar:");
                                    int para = Convert.ToInt32(Console.ReadLine());
                                    if (para >= fiyat[a])
                                    {
                                        int paraust;
                                        paraust = para - fiyat[a];
                                        Console.WriteLine("İşlem Başarılı...");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("Para Üstünüz:" + paraust + "TL");
                                        break;

                                    }
                                    else
                                    {
                                        int p;
                                        p = fiyat[a] - para;
                                        Console.WriteLine($"{p}TL eksik.Tekrar Deneyin...");


                                    }
                                }

                            }


                            Console.Write("1-Anamenü\n2-Hesaptan Çıkış\nİşleminiz:");
                            int islem = Convert.ToInt32(Console.ReadLine());
                            if (islem == 1)
                            {

                            }
                            else if (islem == 2)
                            {

                                break;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Hatalı kullanıcı adı.Daha sonra tekrar deneyin...");


                    }
                }

                else
                {
                    break;
                }
            }
            Console.ReadLine();
        
    }
    }
}
