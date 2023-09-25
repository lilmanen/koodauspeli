using System;

namespace Koodaripeli
{
    class Program
    {
        static void Main()
        {
            bool jatkaPelia = true;

            do
            {
                int koodarinPisteet = 0;
                Console.WriteLine("Selvitetään onko sinusta koodariksi!");
                Console.WriteLine(" ");
                Console.Write("Oletko valmis loputtomalle oppimismatkalle? (K/E): ");

                char valinta = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (valinta == 'E' || valinta == 'e')
                {
                     jatkaPelia = false;
                     Console.WriteLine("Koodaaminen ei taida olla sinun juttusi");
                     Console.ReadLine();
                }
                else if (valinta == 'K' || valinta == 'k')
                {
                    koodarinPisteet += 1;
                    Console.WriteLine(" ");
                    Console.WriteLine("Löydät mielenkiintoisen koodariakatemian, jota ystäväsi suosittelee");
                    Console.Write("Laitatko hakemuksen menemään? (K/E): ");
                    Console.WriteLine(" ");

                    valinta = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (valinta == 'E' || valinta == 'e')
                    {
                        koodarinPisteet += 0;
                        Console.WriteLine("Menetit huippumahdollisuuden ja on parempia etsiä motivaatiota muualta.");
                        Console.ReadLine();
                    }
                    else
                    {
                        koodarinPisteet += 1;
                        Console.WriteLine("Laitoit hakemuksen, mutta se vaatii jotain lisäksi.");
                        Console.Write("Oletko valmis opiskelemaan itsenäisesti? (K/E): ");
                        Console.WriteLine(" ");

                        valinta = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        if (valinta == 'K' || valinta == 'k')
                        {
                            koodarinPisteet += 1;
                            Console.WriteLine("Lataa Visual Studio ja ala opettelemaan.");
                            Console.WriteLine("Sait myös samalla kutsun haastatteluun.");
                        }
                        else
                        {
                            koodarinPisteet -= 1;
                            Console.WriteLine("Toivo, että hakemuksesi on maailman vakuuttavin ja pelastaa sinut.");
                        }

                        Console.Write("Latasit GitHubin, laitetaanko sinne projektejasi? (K/E): ");
                        Console.WriteLine(" ");
                        valinta = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        if (valinta == 'K' || valinta == 'k')
                        {
                            koodarinPisteet += 1;
                            Console.WriteLine("Hienoa, nyt olet tehnyt parhaasi akatemiaan pääsyn eteen!");
                            Console.WriteLine("Toivotaan, että motivaatiosi ja intosi välittyi.");
                        }
                        else
                        {
                            koodarinPisteet -= 0;
                            Console.WriteLine("Voit vain toivoa, että käy tuuri.");
                            Console.WriteLine("Projektityöt olisivat olleet suuri lisä osaamisen näyttämiseksi.");
                        }

                        TulostaArvosana(koodarinPisteet);

                        Console.Write("Haluatko pelata uudelleen? (K/E): ");
                        char uusiPeliValinta = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        jatkaPelia = (uusiPeliValinta == 'K' || uusiPeliValinta == 'k');
                        Console.Clear();
                    }
                }
                else
                {
                    jatkaPelia = false;
                    Console.WriteLine("Koodaaminen ei taida olla sinun juttusi");
                }

            } while (jatkaPelia);
        }

        static void TulostaArvosana(int pisteet)
        {
            if (pisteet >= 3)
            {
                Console.WriteLine("Tulit valituksi");
            }
            else
            {
                Console.WriteLine("Et saanut paikkaa tällä kertaa");
            }
        }
    }
}
