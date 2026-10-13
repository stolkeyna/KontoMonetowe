using System;
using System.Collections.Generic;
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

        public void WrzucMonete(KontoBankowe konto, double RodzajMonety)
        {
            if (RodzajMonety == 5.0 && RodzajMonety == 2.0 && RodzajMonety == 1.0 && RodzajMonety == 0.50 && RodzajMonety == 0.20 && RodzajMonety == 0.10)
            {
                switch (RodzajMonety)
                {
                    case 5.0:
                        konto.Saldo += 5;
                        break;
                    case 2.0:
                        konto.Saldo += 2.0;
                        break;
                    case 1.0:
                        konto.Saldo = +1.0;
                        break;
                    case 0.50:
                        konto.Saldo = +0.50;
                        break;
                    case 0.20:
                        konto.Saldo += 0.20;
                        break;
                    case 0.10:
                        konto.Saldo += 0.10;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nierozpoznany typ monety!");
            }
        }
    }
}
