using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace KontoMonetowe
{
    internal class KontoBankowe
    {
        Random rnd = new Random();
        private decimal _saldo;
        private string _wlasciciel;
        private int _pin;
        private string _numerKonta;

        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    Console.WriteLine("Błąd: Saldo nie może być ujemne");
                }
            }
        }
        public string Wlascicel
        {
            get
            {
                return _wlasciciel;
            }
            set
            {
                //walidacja
                if (value == string.Empty)
                {
                    throw new ArgumentException("Błąd: nazwa wlaściciela nie może być pusta!");
                }
                else
                {
                    _wlasciciel = value;
                }
            }
        }
        public int Pin
        {
            get
            {
                return _pin;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    _pin = value;
                }
                else
                {
                    _pin = 0000;
                    throw new ArgumentException("Błąd: Pin ma mieć dokładnie 4 cyfry.");
                }
            }
        }
        public string NumerKonta
        {
            get
            {
                return _numerKonta;
            }
            set { }

        }

        public KontoBankowe(string nowyWlasciciel, int ustawionyPin)
        {
            Wlascicel = nowyWlasciciel;
            Saldo = 0;
            Pin = ustawionyPin;
            Console.WriteLine($"Utworzone nowe konto dla {_wlasciciel}");
            for (int i = 0; i < 24; i++)
            {
                var nastepnaLiczbaNumeru = rnd.Next(0, 10);
                _numerKonta = _numerKonta += nastepnaLiczbaNumeru.ToString();
            }
        }

        //funkcje do objektu
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Właścicel: {Wlascicel}    |Saldo: {Saldo:C}    |Numer konta: {_numerKonta}");
        }
        public void Wplac(decimal nominal)
        {
            Saldo += nominal;
        }
    }
}
