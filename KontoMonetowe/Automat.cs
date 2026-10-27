using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KontoMonetowe
{
    internal class Automat
    {
        //Przyjmyje tylko monety
        //Dodaje monety na konto
        //Przyjmuje monety 5, 2, 1, 0.50, 0.20, 0.10
        //Liczy ilość wrzuconych monet

        private int _iloscMonet;
        public int IloscMonet
        {
            get { return _iloscMonet; }
        }
        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };

        public void WrzucMonete(KontoBankowe konto, string Moneta, int Pin)
        {
            string MonetaUjednoliczonyZapis = Moneta.Replace(",", ".");
            if (Pin == konto.Pin)
            {
                //Sprawdzamy czy monete w ogóle sparsować na jakiś decimal
                bool CzyUdanyParse = decimal.TryParse(Moneta, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal WartoscMonety);
                if (!CzyUdanyParse)
                {
                    Console.WriteLine("Nieudany odczyt monety.");
                    return;
                }
                //Sprawdz czy wrzucona moneta jest z zakresu _przyjmowaneMonety
                foreach (decimal nominal in _przyjmowaneMonety)
                {
                    if(WartoscMonety == nominal)
                    {
                        //konto.Saldo += nominal;
                        konto.Wplac(nominal);
                        _iloscMonet++;
                        Console.WriteLine($"Przyjęto monetę {WartoscMonety}. Wrzucono {MonetaUjednoliczonyZapis} zł.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy pin.");
            }
        }
    }
}
