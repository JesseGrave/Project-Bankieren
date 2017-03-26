using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer 
{
    public class Spaarrekening : Rekening
    {
        // PROPERTIES

        private decimal Rentepercentage;

        public decimal HuidigeRenteBerekenen
        {
            get { return (bankSaldo * (Rentepercentage / 100)); }
        }
        
        // CONSTRUCTOR
        public Spaarrekening(string _rekeningnr, decimal _banksaldo, decimal _rente) : base(_rekeningnr, _banksaldo)
        {
            this.Rentepercentage = _rente;
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
                bankSaldo -= bedrag;
                if (base.bankSaldo < 0)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("Uw transactie is mislukt \nReden: Uw banksaldo kan niet in het negatief komen te staan.");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                string.Format("\nRentePercentage: {0}\nHuidig Opgebouwde Rente: {1}", Rentepercentage, HuidigeRenteBerekenen);
        }
    }
}
