using System;
using System.Linq;

namespace AlgoritmaPratik
{
    class Program
    {
        static void Main(string[] args)
        {
            //HackerRankAlgorithms

            #region Matris kullanarak 3X3 sayıların belli  rakamlarını toplama
            //Random rnd = new Random();

            //int[,] matris = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        matris[i, j] = rnd.Next(1, 50);
            //        Console.Write(matris[i, j] + "-");

            //    }

            //    Console.WriteLine();

            //}

            //int sagdansola = 0;
            //int soldansaga = 0;
            //int sonuc = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    soldansaga += matris[i, i];
            //    sagdansola += matris[i, 2 - i];
            //    sonuc = (soldansaga - sagdansola);
            //}

            //Console.WriteLine(Math.Abs(sonuc));

            //}
            #endregion


            #region dizideki sayıların negatif pozitiflikerline göre dizi saysına bölümü
            //    int[] dizi = { -4, 3, -9, 0, 4, 1 };
            //    double negatif = 0;
            //    double pozitif = 0;
            //    double sıfır = 0;
            //    double bolen = dizi.Length;

            //    for (int i = 0; i < dizi.Length; i++)
            //    {
            //        if (dizi[i] == 0)
            //        {
            //            sıfır++;
            //        }
            //        if (dizi[i] > 0)
            //        {
            //            pozitif++;
            //        }
            //        if (dizi[i] < 0)
            //        {
            //            negatif++;
            //        }
            //    }
            //    Console.WriteLine($"{sıfır / bolen:F5} + {pozitif / bolen:F5} + {negatif / bolen:F5}");
            #endregion

            #region staircase
            //Console.WriteLine("Sayı Girin");
            //int sayi = int.Parse(Console.ReadLine());
            //string kare = "#";
            //string boş = " ";

            //for (int i = 0; i < sayi; i++)
            //{

            //    for (int j = 0; j < sayi - i; j++)
            //    {
            //        Console.Write(boş);
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write(kare);
            //    }

            //    Console.WriteLine();

            //}

            #endregion


            #region girilen rakamı üste yuvarlama

            //while (true)
            //{
            //    Console.WriteLine("rakam girin");
            //    int rakam = int.Parse(Console.ReadLine());
            //    if (rakam > 37 && (rakam % 5) >= 3)
            //    {
            //        rakam += (5 - (rakam % 5));
            //    }

            //    Console.WriteLine(rakam);
            //}
            #endregion


            #region Number Line Jumps


            //int hang1Hiz = 3;
            //int kang1Yer =1;
            //int kan2Hiz = 1;
            //int kang2Yer = 2;

            //while (true)
            //{
            //    kang1Yer += hang1Hiz;
            //    kang2Yer += kan2Hiz;

            //    if (kang1Yer==kang2Yer)
            //    {
            //        Console.WriteLine("True");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //        break;
            //    }

            //}



            #endregion


            #region Magic Square

            //    Random rnd = new Random();

            //    int[,] square = new int[3, 3];
            //    int ilkDikey = 0;
            //    int ikinciDikey = 0;
            //    int sonDikey = 0;
            //    int ilkYatay = 0;
            //    int ikinciYatay = 0;
            //    int sonYatay = 0;
            //    int diagonalTop = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            square[i, j] = rnd.Next(1, 9);
            //            Console.Write(square[i, j]);
            //        }

            //        Console.WriteLine();

            //    }

            //    for (int i = 0; i < 3; i++)
            //    {
            //        ilkDikey += square[i, 0];
            //        ikinciDikey += square[i, 1];
            //        sonDikey += square[i, 2];

            //        ilkYatay += square[0, i];
            //        ikinciYatay += square[1, i];
            //        sonYatay += square[2, i];
            //        diagonalTop += square[i, 2 - i];
            //    }
            //    int fark = 0;
            //    if (ilkDikey != 13 || ikinciDikey != 13 || sonDikey != 13 || ilkYatay != 13 || ikinciYatay != 13 || sonYatay != 13 || diagonalTop != 13)
            //    {
            //        fark += Math.Abs(13 - ilkDikey);
            //        ilkDikey += (13 - ilkDikey);
            //        fark += Math.Abs(13 - ikinciDikey);
            //        ikinciDikey += (13 - ikinciDikey);
            //        fark += Math.Abs(13 - sonDikey);//diğer satırlarada eklenebilir
            //        fark += Math.Abs(13 - ilkYatay);
            //        fark += Math.Abs(13 - ikinciYatay);
            //        fark += Math.Abs(13 - sonYatay);
            //        fark += Math.Abs(13 - diagonalTop);

            //    }

            //    Console.WriteLine("ilkDikey: " + ilkDikey);
            //    Console.WriteLine("ikinciDikey " + ikinciDikey);
            //    Console.WriteLine("sonDikey " + sonDikey);
            //    Console.WriteLine("ilkYatay " + ilkYatay);
            //    Console.WriteLine("ikinciYatay " + ikinciYatay);
            //    Console.WriteLine("sonYatay " + sonYatay);
            //    Console.WriteLine("diagonalTop " + diagonalTop);

            //    int toplamOrtalama = (ilkDikey + ikinciDikey + sonDikey + ilkYatay + ikinciYatay + sonYatay + diagonalTop) / 7;
            //    Console.WriteLine("toplamOrtalama " + toplamOrtalama);
            //    Console.WriteLine("fark " + fark);









            #endregion



            #region Climbing the Leaderboard

            //int[] ranked = { 100, 100, 50, 40, 40, 20, 10 };
            //int[] player = { 5, 25, 50, 120 };
            //int puan = 0;

            //for (int i = 0; i < player.Length; i++)
            //{

            //    Array.Resize(ref ranked, ranked.Length + 1);
            //    ranked[ranked.Length - 1] = player[i];
            //    Array.Sort(ranked);
            //    Array.Reverse(ranked);
            //    ranked = ranked.Distinct().ToArray();

            //    foreach (var item in ranked)
            //    {
            //        if (item == player[i])
            //        {
            //            puan = Array.IndexOf(ranked, item) + 1;
            //        }

            //    }
            //    Console.WriteLine(puan);
            //}

            #endregion

        }

    }
}

