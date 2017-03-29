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

        /// <summary>
        /// Voor het afschrijven van geld
        /// </summary>
        /// <param name="bedrag">Het af te schrijven bedrag</param>
        public void Afschrijven(decimal bedrag)
        {
            try
            {
                BankSaldo = BankSaldo - bedrag;
                if (base.BankSaldo < maximaalKrediet)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("Uw transactie is mislukt \nReden: Overschreiding maximaal krediet.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
