internal class Program
{
    private static void Main(string[] args)
    {
        string multiLine = new string('-', 33);

        #region Değer döndürmeyen metotla Şarkı Sözü
        {
            // Şebnem Ferah okyanus şarkısından bir bölüm.
            //Değer döndürmeyen bir metot oluşturulup çağırıldı.

            okyanusLyric();// Çağırma Kodu.

            static void okyanusLyric() //Metod oluşturma kodu.
            {
                Console.WriteLine("----Okyanus Şarkı Sözü----");
                Console.WriteLine("Bak diyorum koca dünyaya");
                Console.WriteLine("Burdan derhal çıkmak gerek");
                Console.WriteLine("Bari çekme bileğimden");
                Console.WriteLine("Benim her şeyi görüp öğrenmem gerek");
            }
            Console.WriteLine(multiLine);
        }
        #endregion

        #region Rastgele Sayı Oluşturup Modunu Alan Değer Döndüren Metot
        {
            //Rastgele bir sayı oluşturan ve bu sayının 2 ye bölümünden kalanı değer olarak döndüren bir metod 

            //Çağırma
            int result = GenerateRandomNumber();
            Console.WriteLine($"Sayının 2 ye bölümünden kalan: {result}");

            //Metod oluşturma
            static int GenerateRandomNumber(int min = 1, int max = 100)
            {
                Random random = new Random();
                int randomNumber = random.Next(min, max);
                Console.WriteLine("\nRastgele Üretilen Sayı: " + randomNumber);

                return randomNumber % 2;

            }
            Console.WriteLine(multiLine);
        }
        #endregion

        #region Parametre Alan ve Geriye Değer Döndüren Bir Metot
        {
            //Parametre olarak aldığı iki sayının çarpımını geriye döndürüyor.
            // Parametreleri önceden 4 ve 5 olarak verdim. Kullanıcıdan istemedim.

            //Çağırma
            int result = carpim(4, 5);
            Console.WriteLine("\nÇarpım: " + result);

            //Metod oluşturma
            static int carpim(int a, int b)
            {
                return (a * b);
            }
            Console.WriteLine(multiLine);

        }
        #endregion

        #region Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        {
            //Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
            //Giriş talep edip çıktı veren metodu çağıran bölüm
            Console.WriteLine();
            Console.Write("Lütfen isminizi giriniz: ");
            string ad = Console.ReadLine().ToUpper();
            Console.Write("Lütfen soyadınızı giriniz: ");
            string soyad = Console.ReadLine().ToUpper();

            //Metot
            karsilama(ad, soyad);

            static void karsilama(string ad, string soyad)
            {
                Console.WriteLine($"\nHoş geldiniz, {ad} {soyad}.");
            }
            Console.WriteLine(multiLine);
        }
        #endregion


    }
}