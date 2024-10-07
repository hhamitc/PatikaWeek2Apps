internal class Program
{
    private static void Main(string[] args)
    {
        // 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

        Console.Write("1.Kişinin Yaşını Giriniz: ");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.Kişinin Yaşını Giriniz: ");
        int age2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("3.Kişinin Yaşını Giriniz: ");
        int age3 = Convert.ToInt32(Console.ReadLine());

        int oldest = FindOldest(age1, age2, age3);
        Console.WriteLine("En yaşlı: " + oldest + " yaşında.");

        static int FindOldest(int age1, int age2, int age3)
        {
            int oldest = age1;

            if (oldest < age2)
            {
                oldest = age2;
            }
            if (oldest < age3)
            {
                oldest = age3;
            }
            return oldest;
        }





        Console.ReadKey();
    }
}