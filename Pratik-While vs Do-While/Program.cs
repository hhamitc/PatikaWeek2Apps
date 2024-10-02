internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

        Console.WriteLine("Lütfen yazdırma tekrarı için bir limit belirleyiniz: ");
        int limit = int.Parse(Console.ReadLine());
        int sayac = 0;
        int sayac2 = 0;

        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("Lütfen yazdırma tekrarı için bir limit belirleyiniz: ");
        limit = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac2++;
        }
        while (sayac2 <= limit);

        // While koşulu program çalışmadan kontrol eder. Ve ilk adımda koşul sağlanmıyorsa döngüye girmez.
        // Do-While önce Do kısmında belirtilen işlemi yapar sonra koşulu kontrol eder, koşul sağlanıyorsa devam eder.
        // Koşul sağlanmıyorsa devam etmez ancak en az bir kez döngüdeki işlem yapılmış olur.


        Console.Read();
    }
}