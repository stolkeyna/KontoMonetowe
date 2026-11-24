using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace KontoMonetowe
{
    internal class Bankomat
    {
        private decimal _saldoBankomatu;
        public decimal SaldoBankomatu
        {
            get { return _saldoBankomatu;}
        }
        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };
        private List<decimal> _przyjęteMonety = new List<decimal>();
        public void ZaladujMonety(string Moneta)
        {
            string[] Monety = Moneta.Split(" ");
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
                        _saldoBankomatu += nominal;
                        _przyjęteMonety.Add(nominal);
                        Console.WriteLine($"Przyjęto monetę {WartoscMonety}. Wrzucono {WartoscMonety} zł.");
                        Nieprawidlowa = false;
                        //Console.WriteLine($"Saldo bankomatu: {_saldoBankomatu}");
                        break;
                    }
                }
                if (Nieprawidlowa)
                {
                    Console.WriteLine($"Moneta {WartoscMonety} nie jest w zakresie rozpoznanych nominałów monet");
                }
            }
        }
        public void Wyplac(KontoBankowe konto, decimal kwota, int Pin)
        {
            if (Pin == konto.Pin)
            {
                if(kwota > _saldoBankomatu || kwota < 0)
                {
                    Console.WriteLine("Błąd! Nie starczy monet w bankomacie żeby wypłacić.");
                    return;
                }
                konto.Wyplac(kwota);
                //zamiazt ... wypisuje którymi monetami było wydano wypłaconą kwotę
                Console.WriteLine($"Wypłacono {kwota:c2}. Otrzymałeś ...");
            }
        }
    }
}
