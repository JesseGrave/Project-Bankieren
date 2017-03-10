using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public abstract class Rekening
    {
        protected string rekeningNr;

        protected decimal bankSaldo;

        public decimal Bijschrijven
        {
            set { value += bankSaldo; }
        }

        public Rekening(string _rekeningNr, decimal _bankSaldo)
        {
            this.rekeningNr = _rekeningNr;
            this.bankSaldo = _bankSaldo;
        }

        public override string ToString()
        {
            return string.Format("RekeningNr: {0} \n Banksaldo: {1}", this.rekeningNr, this.bankSaldo);
        }
    }
}