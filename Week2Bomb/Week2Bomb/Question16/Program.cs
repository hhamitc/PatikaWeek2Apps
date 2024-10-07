internal class Program
{
    private static void Main(string[] args)
    {
        //16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

        Console.WriteLine("Yarıçap bilgisi giriniz: ");
        double yariCap = Convert.ToDouble(Console.ReadLine());

        double alan = areaCalculation(yariCap);

        Console.WriteLine("Dairenizin alanı: " + alan + " .");


        static double areaCalculation(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }



        Console.ReadKey();
    }
}