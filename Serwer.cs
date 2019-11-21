using System;
using System.Collections.Generic;
using System.Text;

namespace LAB6
{
    class Serwer
    {
        private int _lacze;
        private double _szybkoscProcesora;
        private int _RAM;
        public Serwer(int lacze, double szybkoscPrecosora, int _RAM, string technologia)
        {
            Lacze = lacze;
            SzybkoscPrecosora = szybkoscPrecosora;
            RAM = _RAM;
            Technologia = technologia;
        }

        public int Lacze
        {
            get
            {
                return _lacze;
            }

            set
            {
                _lacze = value;
                if (_lacze <= 0)
                {
                    _lacze = 0;
                }
            }
        }
        public double SzybkoscPrecosora
        {
            get
            {
                return _szybkoscProcesora;
            }
            set
            {

                _szybkoscProcesora = value;
                if (_szybkoscProcesora <= 0)
                {
                    _szybkoscProcesora = 0;
                }
            }
        }
        public int RAM
        {
            get
            {
                return _RAM;
            }
            set
            {
                _RAM = value;
                if (_RAM <= 0)
                {
                    _RAM = 0;
                }
            }
        }
        public string Technologia { get; set; }
    }
}
