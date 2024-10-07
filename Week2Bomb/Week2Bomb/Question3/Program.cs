internal class Program
{
    private static void Main(string[] args)
    {
        //3 - Rastgele bir sayı üretip , ekrana yazdırınız.

        Random random = new Random();

        Console.WriteLine("Rastgele üretilmiş sayı: " + random.Next(1, 500));

        Console.ReadKey();
    }
}
