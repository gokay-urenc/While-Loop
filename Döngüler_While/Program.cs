using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool durum = true;
            while (durum) // while (durum == true) demektir.
            {
                Console.WriteLine("Hello World.");
                durum = false; // 1 kere yazdıktan sonra hemen false oluyor ve yazmıyor.
            }
            int sayac = 0;
            while (sayac < 3) // 3 kere Merhaba yazdıran program.
            {
                Console.WriteLine("Merhaba");
                sayac++;
            }
            // Kullanıcıdan alınan 3 sayının toplamını gösteren program.
            int sayac2 = 0, toplam = 0;
            while (sayac2 <= 2)
            {
                sayac2++;
                Console.Write("\nBir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            Console.Write("\nToplamları: " + toplam);
            Console.ReadKey();
        }
    }
}
/* While döngüsü, for döngüsünün parçalanmış halidir.
   while (<koşul>)
   {
       <koşullu kodlar>
   }
   Koşul sağlandığı sürece çalışır.
   For ile yapılabilen her şey while ile yapılabilir.
   For ile arasındaki tek fark, metodlardan gelen cevaplara göre işlem yapabilme özelliği vardır.
*/