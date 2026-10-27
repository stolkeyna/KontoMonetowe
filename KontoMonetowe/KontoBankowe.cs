using System;
using System.Collections.Generic;
using System.Text;

namespace KontoMonetowe
{
    internal class KontoBankowe
    {
        private decimal _saldo;
        private string _wlasciciel;
        private int _pin;
        //private string _numer;

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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _wlasciciel = value;
                }
                else
                {
                    Console.WriteLine("Błąd: nazwa wlaściciela nie może być pusta!");
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

            }
        }
        //public string Numer
        //{
        //    get
        //    {
        //        return _numer;
        //    }
        //}

        public KontoBankowe(string nowyWlasciciel, int ustawionyPin)
        {
            _wlasciciel = nowyWlasciciel;
            _saldo = 0;
            if (ustawionyPin.ToString().Length < 4 && ustawionyPin.ToString().Length > 4)
            {
                _pin = 0000;
                Console.WriteLine("Pin nie może mieć tylko 4 cyfry. Pin był ustawiony na 0000.");
            }
            else
            {
                _pin = ustawionyPin;
            }
            //_numer += 1;
            Console.WriteLine($"Utworzone nowe konto dla {_wlasciciel}");
        }

        //funkcje do objektu
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Właścicel: {_wlasciciel}    |Saldo: {_saldo:C}");
        }
        public void Wplac(decimal nominal)
        {
            Saldo += nominal;
        }
    }
}
