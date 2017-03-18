using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
        public class Bankrekeninghouder
        {

            //PROPERTIES
            public Persoon rekeninghouder;

            public Betaalrekening betaalrekening;

            public Spaarrekening spaarrekening;


            //CONSTRUCTOR
            public Bankrekeninghouder(string voornaam, string achternaam, long bsn, string gebruikersnaam, string wachtwoord,
                string rekeningnrSparen, decimal spaarSaldo, decimal rentepercentage, string rekeningnrBetalen, decimal BetaalSaldo, decimal maxkrediet)
            {
                rekeninghouder = new Persoon(gebruikersnaam, wachtwoord, voornaam, achternaam, bsn);
                spaarrekening = new Spaarrekening(rekeningnrSparen, spaarSaldo, rentepercentage);
                betaalrekening = new Betaalrekening(rekeningnrBetalen, BetaalSaldo, maxkrediet);
            }
            
            //METHODES
            public string Gebruikersnaam()
            {
                return rekeninghouder.Gebruikersnaam;
            }
            public string Wachtwoord()
            {
                return rekeninghouder.Wachtwoord;
            }
            public string SpaarRekeningInzien()
            {
                return spaarrekening.ToString();
            }

            public string BankRekeningInzien()
            {
                return betaalrekening.ToString();
            }

           }
 }
