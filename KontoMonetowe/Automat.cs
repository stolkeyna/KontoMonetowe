using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KontoMonetowe
{
    internal class Automat
    {
        private int _iloscPrzMonet;
        public int IloscPrzMonet
        {
            get { return _iloscPrzMonet; }
        }
        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };
        private decimal[] _przyjęteMonety = new decimal[] { };
        public void WrzucMonete(KontoBankowe konto, string Moneta, int Pin)
        {
            string[] Monety = Moneta.Split(" ");
            //string MonetaUjednoliczonyZapis = Moneta.Replace(",", ".");
            if (Pin == konto.Pin)
            {
                foreach (string jednaMoneta in Monety)
                {
                    //Sprawdzamy czy monete w ogóle sparsować na jakiś decimal
                    bool CzyUdanyParse = decimal.TryParse(jednaMoneta, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal WartoscMonety);
                    if (!CzyUdanyParse)
                    {
                        Console.WriteLine("Nieudany odczyt monety.");
                        return;
                    }
                    //Sprawdz czy wrzucona moneta jest z zakresu _przyjmowaneMonety
                    bool Nieprawidlowa = true;
                    foreach (decimal nominal in _przyjmowaneMonety)
                    {
                        if (WartoscMonety == nominal)
                        {
                            //konto.Saldo += nominal;
                            konto.Wplac(nominal);
                            _iloscPrzMonet++;
                            _przyjęteMonety = new decimal[] {WartoscMonety};
                            Console.WriteLine($"Przyjęto monetę {WartoscMonety}. Wrzucono {WartoscMonety} zł.");
                            Nieprawidlowa = false;
                            break;
                        }
                    }
                    if (Nieprawidlowa)
                    {
                        Console.WriteLine($"Moneta {WartoscMonety} nie jest w zakresie rozpoznanych nominałów monet");
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
