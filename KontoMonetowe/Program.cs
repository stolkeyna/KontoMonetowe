using System.Runtime.CompilerServices;

namespace KontoMonetowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Niewypełnione wymagania:
            //-------Etap 2
            //--na koniec automat podaje, ile monet przyjął, a ile zwrócił.
            //--Automat ma ograniczoną pojemność: mieści określoną liczbę monet każdego nominału. Gdy dla danego nominału nie ma już miejsca, automat zwraca monetę i wypisuje komunikat. Taka moneta nie zmienia stanu konta i liczy się jako zwrócona.
            //--Pokaż, że automat zwraca monetę, gdy nie ma na nią miejsca.
            //-------Etap 3
            //--..Monety dobiera od największego nominału, biorąc tylko te, które ma w pojemniku
            //--Bankomat umie wypisać, ile monet każdego nominału ma w pojemniku i ile to razem złotych.

            //Tworzenie konta
            KontoBankowe KontoA = new KontoBankowe("A", 1234);

            //Tworzenie automatu
            Automat automat1 = new Automat();

            //Tworzenie bankomatu
            Bankomat bankomat1 = new Bankomat();
            Console.WriteLine("___________________________________");
            KontoA.WyswietlInformacje();

            automat1.WrzucMonete(KontoA, "0.5 0.5 0.5 0.5 0.5 2 1 0.2 3 asd 5", 1234);
            KontoA.WyswietlInformacje();
            Console.WriteLine("___________________________________");
            KontoBankowe KontoB = new KontoBankowe("B", 1235);
            KontoB.WyswietlInformacje();
            Console.WriteLine("___________________________________");
            automat1.PokazMonety();
            Console.WriteLine("___________________________________");
            bankomat1.ZaladujMonety("0.5 2 1 0.2 3 asd 5");
            bankomat1.Wyplac(KontoA, 1, 1234);
            KontoA.WyswietlInformacje();
            Console.WriteLine("___________________________________");
            bankomat1.Wyplac(KontoA, 130, 1234);
            bankomat1.Wyplac(KontoA, -1, 1234);
        }
    }
}
