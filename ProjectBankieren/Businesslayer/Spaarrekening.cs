using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer 
{
    public class Spaarrekening /*: Rekening*/
    {
        private decimal rentePercentage;

        public decimal RentePercentage
        {
            get { return rentePercentage; }
            set { rentePercentage = value; }
        }

        //public decimal HuidigeRenteBerekenen
        //{
        //    set { bankSaldo * Convert.ToDecimal(0.01); }
        //}

    }
}
