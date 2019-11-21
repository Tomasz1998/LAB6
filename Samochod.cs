using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6
{
    class Samochod

    {

        public static int IloscModeli { get; set; } = 0;
        public readonly string Model;
        public int VIN { get; private set; }
        private int _przebieg;
        public int Przebieg { get; set; }
        public void ZwiekszPrzebieg(int dystans)
        {
            if (dystans < 0)
            {
                throw new ArgumentException("dystans nie moze byc ujemy");
            }
            Przebieg += dystans;
        }
        //public int Przebieg
        //{
        //    get
        //    {
        //        return _przebieg;
        //    }
        //    set
        //    {
        //        if (value > Przebieg)
        //        {
        //            _przebieg = value;
        //        }
        //    }
        //}
        public int IloscDrzwi { get; set; }
        private int _waga;

        public Samochod(string model, int przebieg, int iloscDrzwi, int _waga) : this()
        {
            Model = model;
            Przebieg = przebieg;
            IloscDrzwi = iloscDrzwi;
            Waga = _waga;


        }
        public Samochod(int id)
        {

            // var dane = Baza.GetById(id)
            // Przebieg = dane.Przebieg;
        }
        private Samochod()
        {
            VIN = IloscModeli++;
        }
        public Samochod(int iloscDrzwi, int waga) : this("Multipla", 0, iloscDrzwi, waga)
        {
            Model = "Mupltipla";
            Przebieg = 0;
            IloscDrzwi = iloscDrzwi;
            Waga = waga;
            VIN = IloscModeli;
        }
        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;
                if (_waga < 0)
                {
                    _waga = 0;
                }
            }
        }


    }
}
