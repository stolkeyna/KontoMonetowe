using System.Runtime.CompilerServices;

namespace KontoMonetowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Niewypełnione wymagania:
            //-Automat poprawnie odczytuje monety zapisane z kropką(np. "0.5"), niezależnie od ustawień komputera. (nie przyjmuje 0,5 ???)
            //--zła moneta, gdy to liczba, ale automat nie przyjmuje takiego nominału(np. "3") (komunikat wyświetla się więzej razy niż trzeba, bo wypisuje go dla każdego elementu w liście przyjmowanych monet)
            //--Automat liczy osobno, ile monet każdego nominału przyjął.
            //--Automat ma metodę PokazMonety(), która wypisuje liczbę monet każdego nominału i łączną wartość wszystkich monet.

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
