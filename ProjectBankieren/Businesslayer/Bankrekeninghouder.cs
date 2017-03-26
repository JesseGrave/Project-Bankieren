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

            /// <summary>
            /// De constructor van een bankrekeninghouder
            /// </summary>
            /// <param name="voornaam">De voornaam van de gebruiker</param>
            /// <param name="achternaam">De achternaam van de gebruiker</param>
            /// <param name="bsn"> Het burger service nummer van de gebruiker</param>
            /// <param name="gebruikersnaam">De gebruikersnaam</param>
            /// <param name="wachtwoord">Het wachtwoord</param>
            /// <param name="rekeningnrSparen">Het rekeningnr van de spaarrekening</param>
            /// <param name="spaarSaldo">Het saldo van de spaarrekening</param>
            /// <param name="rentepercentage">Het rentepercentage van de spaarrekening</param>
            /// <param name="rekeningnrBetalen">Het rekeningnr van de betaalrekening</param>
            /// <param name="BetaalSaldo">Het saldo van de bankrekening</param>
            /// <param name="maxkrediet">Het maximale krediet</param>
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


                public bool Betalen(string rekeningnr, decimal bedrag)
                {
                    try
                    {
                        Bankrekeninghouder gebruiker = DataProvider.RekeningnrGebruiker(rekeningnr);
                        this.betaalRekening.Afschrijven(bedrag);
                        gebruiker.betaalRekening.Bijschrijven = bedrag;
                        return true;
                    }
                    catch (Exception exception)
                    {
                        throw exception;
                    }

                }


                public bool NaarSpaarRekening(decimal bedrag)
                {
                    try
                    {
                        betaalRekening.Afschrijven(bedrag);
                        spaarRekening.Bijschrijven = bedrag;
                        return true;
                    }

                    catch (Exception exception)
                    {
                        throw exception;
                    }
                }


                public bool NaarBetaalrekening(decimal bedrag)
                {
                    try
                    {
                        spaarRekening.Afschrijven(bedrag);
                        betaalRekening.Bijschrijven = bedrag;
                        return true;
                    }

                    catch (Exception exception)
                    {
                        throw exception;
                    }

                }

        }
 }
