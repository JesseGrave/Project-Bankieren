﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public abstract class Rekening
    {
        //PROPERTIES
        public string rekeningNr;

        public decimal bankSaldo;

        public decimal Bijschrijven
        { 
            set { bankSaldo += value; }
        }

        //CONSTRUCTOR
        public Rekening(string _rekeningNr, decimal _bankSaldo)
        {
            this.rekeningNr = _rekeningNr;
            this.bankSaldo = _bankSaldo;
        }

        //METHODES
        public override string ToString()
        {
            return string.Format("RekeningNr: {0} \nBanksaldo: {1}", this.rekeningNr, this.bankSaldo);
        }
    }
}