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

            Console.WriteLine("0.5");
            automat1.WrzucMonete(KontoA, "0.5", 1234);
            KontoA.WyswietlInformacje();

            Console.WriteLine("0,5");
            automat1.WrzucMonete(KontoA, "0,5", 1234);
            KontoA.WyswietlInformacje();

            Console.WriteLine("5");
            automat1.WrzucMonete(KontoA, "5", 1234);
            KontoA.WyswietlInformacje();

            Console.WriteLine("6");
            automat1.WrzucMonete(KontoA, "6", 1234);

            Console.WriteLine("abc");
            automat1.WrzucMonete(KontoA, "abc", 1234);
            automat1.WrzucMonete(KontoA, "5", 1235);
        }
    }
}
