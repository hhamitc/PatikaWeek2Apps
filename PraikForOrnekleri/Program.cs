internal class Program
{
    private static void Main(string[] args)
    {
        #region Örnek 1
        //1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        Console.WriteLine("Örnek 1");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i}-Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------");

        #endregion

        #region Örnek 2
        //2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        Console.WriteLine("Örnek 2");
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("Sayı: "+i);
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------");

        #endregion

        #region Örnek 3
        //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
        //İki farklı şekilde yaptım.
        Console.WriteLine("Örnek 3");
        //1
        for (int i = 2; i <= 20; i+=2)
        {
            Console.WriteLine($"Sayı: {i}");
        }
        //2
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine("Sayı:"+i);
            }
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------");
        #endregion

        #region Örnek 4
        //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        Console.WriteLine("Örnek 4");
        //Hangi aralığın istendiğinden emin olamadığım için 2 şekilde yaptım.
        //1
        int toplam = 0;
        for (int i = 50; i <=150; i++)
        {
            toplam = toplam + i;
        }
        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("---");
        //2
        int toplam2 = 0;
        for (int i = 51; i < 150; i++)
        {
            toplam2 = toplam2 + i;
        }
        Console.WriteLine("Toplam2: " + toplam2);
        Console.WriteLine();
        Console.WriteLine("----------------------------");

        #endregion

        #region Örnek 5 
        //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        Console.WriteLine("Örnek 5");
        int tekToplam = 0;
        int ciftToplam = 0;

        for (int i = 1; i <=120; i++)
        {
            if (i % 2 == 0)
            {
                ciftToplam = ciftToplam + i;
            }
            else
            {
                tekToplam += i;
            }            
        }
        Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
        Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);

        #endregion

        Console.Read();
    }
}