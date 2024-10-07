internal class Program
{
    private static void Main(string[] args)
    {
        //14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        bool tekMi = isOdd(sayi);

        if (tekMi) { Console.WriteLine("Sayınız tek sayıdır."); }
        else { Console.WriteLine("Sayınız çift sayıdır."); }


        static bool isOdd(int sayi)
        {
            return sayi % 2 != 0;
        }

        Console.ReadKey();
    }
}