using System.Runtime.CompilerServices;

namespace KontoMonetowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Niewypełnione wymagania:
            //--Automat liczy osobno, ile monet każdego nominału przyjął.
            //--Automat ma metodę PokazMonety(), która wypisuje liczbę monet każdego nominału i łączną wartość wszystkich monet.
            //--na koniec automat podaje, ile monet przyjął, a ile zwrócił.
            //--Automat ma ograniczoną pojemność: mieści określoną liczbę monet każdego nominału. Gdy dla danego nominału nie ma już miejsca, automat zwraca monetę i wypisuje komunikat. Taka moneta nie zmienia stanu konta i liczy się jako zwrócona.
            //--Konto pamięta historię wpłat i umie wypisać, ile ich było i na jakie kwoty.
            //--Pokaż, że automat zwraca monetę, gdy nie ma na nią miejsca.
            //--Na końcu wyświetl historię wpłat i monety w automacie.

            //Tworzenie konta
            KontoBankowe KontoA = new KontoBankowe("A", 1234);

            //Tworzenie automatu
            Automat automat1 = new Automat();

            KontoA.WyswietlInformacje();

            automat1.WrzucMonete(KontoA, "0.5 0.5 0.5 0.5 0.5 2 1 0.2 3 asd 5", 1234);
            KontoA.WyswietlInformacje();

            KontoBankowe KontoB = new KontoBankowe("B", 1235);
            KontoB.WyswietlInformacje();
        }
    }
}
