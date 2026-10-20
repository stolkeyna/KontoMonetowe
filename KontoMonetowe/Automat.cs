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
        private readonly decimal[] _przyjmowaneMonety = new decimal[] {5, 2, 1, 0.5m, 0.2m, 0.1m};

        public void WrzucMonete(KontoBankowe konto, double RodzajMonety, int Pin)
        {
            if(Pin == konto.Pin)
            {
                if (RodzajMonety == 5.0 || RodzajMonety == 2.0 || RodzajMonety == 1.0 || RodzajMonety == 0.50 || RodzajMonety == 0.20 || RodzajMonety == 0.10)
                {
                    switch (RodzajMonety)
                    {
                        case 5.0:
                            konto.Saldo += 5;
                            Console.WriteLine("Wrzucono 5zł.");
                            break;
                        case 2.0:
                            konto.Saldo += 2.0;
                            Console.WriteLine("Wrzucono 2zł.");
                            break;
                        case 1.0:
                            konto.Saldo += 1.0;
                            Console.WriteLine("Wrzucono 1zł.");
                            break;
                        case 0.50:
                            konto.Saldo += 0.50;
                            Console.WriteLine("Wrzucono 50gr.");
                            break;
                        case 0.20:
                            konto.Saldo += 0.20;
                            Console.WriteLine("Wrzucono 20gr.");
                            break;
                        case 0.10:
                            konto.Saldo += 0.10;
                            Console.WriteLine("Wrzucono 10gr.");
                            break;
                    }
                }else
                {
                    Console.WriteLine("Nierozpoznany typ monety!");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy pin.");
            }
        }
    }
}
