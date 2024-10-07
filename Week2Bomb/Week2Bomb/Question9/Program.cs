internal class Program
{
    private static void Main(string[] args)
    {
        //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

        int toplam = AddNumbers(4, 9);
        Console.WriteLine("Toplam: " + toplam);

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }


        Console.ReadKey();
    }
}