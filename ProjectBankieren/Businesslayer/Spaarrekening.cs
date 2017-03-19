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
        public void AfSchrijven(decimal bedrag)
        {
            try
            {
                bankSaldo -= bedrag;
                if (base.bankSaldo <= 0)
                {
                    Bijschrijven = bedrag;
                    throw new ArgumentException("Uw transactie is mislukt /n Reden: Uw banksaldo kan niet in het negatief komen te staan.");
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
                string.Format("RentePercentage: {0}\nHuidig Opgebouwede Rente: {1}", Rentepercentage, HuidigeRenteBerekenen);
        }
    }
}
