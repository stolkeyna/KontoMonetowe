using System;
using System.Collections.Generic;
using System.Text;

namespace KontoMonetowe
{
    internal class KontoBankowe
    {
        private double _saldo;
        //private string _nrKonta;
        private string _wlasciciel;

        public double Saldo
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
        //public string NrKonta
        //{
        //    get
        //    {
        //        return _nrKonta;
        //    }
        //}

        public KontoBankowe(string nowyWlasciciel, int ustawionyPin)
        {
            _wlasciciel = nowyWlasciciel;
            _saldo = 0;
            //_nrKonta += 1;
            Console.WriteLine($"Utworzone nowe konto dla {_wlasciciel}");
        }

        //funkcje do objektu
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Właścicel: {_wlasciciel}    |Saldo: {_saldo}");
        }
    }
}
