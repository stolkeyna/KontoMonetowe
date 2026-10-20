namespace KontoMonetowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tworzenie konta
            KontoBankowe KontoA = new KontoBankowe("A", 1234);

            //Tworzenie automatu
            Automat automat1 = new Automat();

            KontoA.WyswietlInformacje();
            automat1.WrzucMonete(KontoA, 0.50, 1234);
            KontoA.WyswietlInformacje();
            automat1.WrzucMonete(KontoA, 5.0, 1234);
            KontoA.WyswietlInformacje();
            automat1.WrzucMonete(KontoA, 6.0, 1234);
            automat1.WrzucMonete(KontoA, 5.0, 1235);
        }
    }
}
