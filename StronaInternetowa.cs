using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6
{

    class StronaInternetowa
    {
        static void OpiszDomene(Domena domena)
        {
            Console.Write("Nazwa Domeny: " + domena.Nazwa +
                       " Właściciel domeny: " + domena.Wlasciciel + " ");
        }
        static void OpiszSerwer(Serwer serwer)
        {
            Console.WriteLine("Łączę: " + serwer.Lacze + " MB/s " + "Szybkość procesora " + serwer.SzybkoscPrecosora + " Ghz" +
                        " Ilość pamięci " + serwer.RAM + " RAM " + " Technologia " + serwer.Technologia);
        }
        // Strona internetowa                   Dowolnie rozszerzaj klasy
        // Serwer                               hermetyzuj co sie da
        //  Lacze
        //  SzybkoscProcesora
        //  RAM
        //  Technologia
        // Domena
        //  Nazwa
        //  Waznosc : DateTime
        //  Wlasciciel
        //   Nazwa

        static void Main(string[] args)
        {
            Domena NowaDomena = new Domena("Ferrari.com", "Tomek");

            Serwer NowySerwer = new Serwer(100, 4.5, 16, "HTML");

            OpiszDomene(NowaDomena);
            DateTime waznosc = new DateTime(2018, 12, 12);
            Console.WriteLine("Ważność domeny: " + waznosc);
            OpiszSerwer(NowySerwer);
            Console.ReadKey();
            Console.WriteLine();


        }
    }
}
