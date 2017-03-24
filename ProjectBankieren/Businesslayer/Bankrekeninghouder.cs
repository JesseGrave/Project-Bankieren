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
            private Persoon rekeninghouder;

            public Persoon rekeningHouder
            {
                get { return rekeninghouder; }
            }

            private Betaalrekening betaalrekening;

            public Betaalrekening betaalRekening
            {
                get { return betaalrekening; }
            }

            private Spaarrekening spaarrekening;

            public Spaarrekening spaarRekening
            {
                get { return spaarrekening; }
            }

        //CONSTRUCTOR
        public Bankrekeninghouder(string voornaam, string achternaam, string bsn, string gebruikersnaam, string wachtwoord,
                string rekeningnrSparen, decimal spaarSaldo, decimal rentepercentage, string rekeningnrBetalen, decimal BetaalSaldo, decimal maxkrediet)
            {
                rekeninghouder = new Persoon(gebruikersnaam, wachtwoord, voornaam, achternaam, bsn);
                spaarrekening = new Spaarrekening(rekeningnrSparen, spaarSaldo, rentepercentage);
                betaalrekening = new Betaalrekening(rekeningnrBetalen, BetaalSaldo, maxkrediet);
            }
            
            //METHODES

            //Voor het makkelijker ophalen van informatie van de rekeninghouder
            public string VolledigeNaam()
            {
                return rekeninghouder.Voornaam + " " + rekeninghouder.Achternaam;
            }
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
