internal class Program
{
    private static void Main(string[] args)
    {
        //12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        Console.Write("Kaç adet sayı gireceksiniz? ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = new int[limit];

        for (int i = 0; i < limit; i++)
        {
            Console.Write($"{i + 1}. Sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        int enBuyukSayi = FindBiggest(sayilar);
        Console.WriteLine("En büyük sayi: " + enBuyukSayi);



        //En büyük sayıyı bulan metot
        static int FindBiggest(int[] sayilar)
        {
            int enBuyukSayi = sayilar[0];

            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enBuyukSayi)
                {
                    enBuyukSayi = sayilar[i];
                }
            }
            return enBuyukSayi;
        }



        Console.Read();

    }
}