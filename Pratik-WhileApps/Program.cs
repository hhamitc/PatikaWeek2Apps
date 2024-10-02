internal class Program
{
    private static void Main(string[] args)
    {
        #region Örnek 1
        // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        Console.WriteLine("Örnek 1");
        int notSayac = 1;

        while (notSayac <= 10) 
        {
            Console.WriteLine($"{notSayac}-Kendime inanıyorum, ben bu yazılım işini hallederim!");
            notSayac++;
        }
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        #endregion

        #region Örnek 2
        //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
        Console.WriteLine("Örnek 2");
        Console.WriteLine();
        int sayi = 1;
        while (sayi <= 20)
        {
            Console.WriteLine("Sayi: "+sayi);
            sayi++;
        }
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");



        #endregion

        #region Örnek 3
        //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
        Console.WriteLine("Örnek 3");
        int cift = 1;
        while (cift <= 20)
        {
            if (cift % 2==0)
            {
                Console.WriteLine("Sayi: " + cift);
            }          

            cift ++;
        }
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        #endregion

        #region Örnek 4
        //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        Console.WriteLine("Örnek 4");
        int toplam = 0;
        int sayi_=50;

        while (sayi_ <= 150)
        {
            toplam += sayi_;
            sayi_++;
        }
        Console.WriteLine("Toplam: "+toplam);

        Console.WriteLine("");
        Console.WriteLine("------------------------------------");

        #endregion

        #region Örnek 5
        //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        Console.WriteLine("Örnek 5");
        Console.WriteLine();
        int sayi_2=1;
        int tekToplam = 0;
        int ciftToplam = 0;
        

        while (sayi_2 <=120)
        {
            if (sayi_2 % 2 == 0) { ciftToplam += sayi_2; }
            else { tekToplam += sayi_2; }
            sayi_2++;
        }
        Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
        Console.WriteLine("Çift Sayıların Toplamı: " + ciftToplam);


        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
        #endregion





        Console.Read();
    }
}