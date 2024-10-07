internal class Program
{
    private static void Main(string[] args)
    {
        //15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

        Console.Write("Hız bilgisini giriniz: ");
        int speed = Convert.ToInt32(Console.ReadLine());
        Console.Write("Zaman bilgisini giriniz: ");
        int time = Convert.ToInt32(Console.ReadLine());

        int distance = calculateDistance(speed, time);
        Console.WriteLine("Mesafe: " + distance + " km/h'dir");

        static int calculateDistance(int speed, int time)
        {
            return speed * time;
        }



        Console.ReadKey();
    }
}