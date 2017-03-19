using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Betaalrekening : Rekening
    {
        // PROPERTIES
        private string rekeningnr;
        private decimal maximaalKrediet;
        private decimal bankSaldo;

        // CONSTRUCTOR
        public Betaalrekening(string _rekeningnr, decimal _banksaldo, decimal _maximaalkrediet) : base(_rekeningnr, _banksaldo)
        {
            this.rekeningnr = _rekeningnr;
            this.maximaalKrediet = _maximaalkrediet;
            this.bankSaldo = _banksaldo;
        }

        // METHODES
        public void Afschrijven(decimal bedrag)
        {
            try
            {
                bedrag -= bankSaldo;
                if (base.bankSaldo <= maximaalKrediet)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("Uw transactie is mislukt /n Reden: Overschreiding maximaal krediet.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
