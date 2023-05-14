using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004.ketszamosszege
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            int osszeg = szam1 + szam2;
            Console.WriteLine("A két szám összege: " + osszeg + "." + "\n");

            Console.ReadKey();
        }
    }
}

/*Ez a kód egy egyszerű program, amely két számot kér a felhasználótól, majd kiszámolja azok összegét és kiírja azt a konzolra. Soronként a következők történnek:

1. A System névtér beimportálása.
2. Egy namespace definiálása _004.ketszamosszege névvel.
3. Egy class definiálása Program névvel.
4. Az Main függvény definiálása, amely a program belépési pontja.
5. A "Kérek egy számot!" üzenet kiírása a konzolra.
6. Az első szám bekérése a felhasználótól, majd a kapott érték eltárolása a szam1 változóban. A bekért szám string formátumú változó így át kell konvertálni a ConvertToInt32 metódussal integer (int) egész számos változóra, hogy matematikai műveleteket tudjunk vele végezni.
7. A "Kérek még egy számot!" üzenet kiírása a konzolra.
8. A második szám bekérése a felhasználótól, majd a kapott érték eltárolása a szam2 változóban.
9. Az osszeg változó létrehozása, amely a két szám összegét tartalmazza.
10. Az "A két szám összege: " és az osszeg változó értékének kiírása a konzolra a Console.WriteLine() függvénnyel.
11. Az utolsó sorban egy ReadKey() függvény hívása található, amely megakadályozza a program futásának azonnali befejezését, amíg a felhasználó nem nyom egy billentyűt a konzolon.*/
