internal class Program
{
    private static void Main(string[] args)
    {
        /*1 - Aşağıdaki çıktıyı yazan bir program.

            Merhaba
            Nasılsın ?
            İyiyim
            Sen nasılsın ?
        */


        chitChat();//Metotu çağırma


        static void chitChat() // Metotu oluşturma.

        {
            Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?\r\n\r\n");
        }






        Console.Read();
    }
}