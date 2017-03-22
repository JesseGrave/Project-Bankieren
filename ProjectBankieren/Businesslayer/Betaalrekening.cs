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

        private decimal maximaalKrediet;

        // CONSTRUCTOR
        public Betaalrekening(string _rekeningnr, decimal _banksaldo, decimal _maximaalkrediet) : base(_rekeningnr, _banksaldo)
        {
            this.maximaalKrediet = _maximaalkrediet;
        }

        // METHODES
        public void Afschrijven(decimal bedrag)
        {
            try
            {
                bankSaldo = bankSaldo - bedrag;
                if (base.bankSaldo < maximaalKrediet)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("Uw transactie is mislukt \n Reden: Overschreiding maximaal krediet.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
