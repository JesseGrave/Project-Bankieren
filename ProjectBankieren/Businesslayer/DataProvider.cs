using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public static class DataProvider
    {
        public static List<Bankrekeninghouder> Allebankrekeninghouders()
        {
            List<Bankrekeninghouder> Allebankrekeninghouders = new List<Bankrekeninghouder>();

            Allebankrekeninghouders.Add(new Bankrekeninghouder
                (
                voornaam: "Menno",
                achternaam: "de Lange",
                bsn: 147258369,
                gebruikersnaam: "mdeLange",
                wachtwoord: "MennoBank",
                rekeningnrSparen: "NL14 ABNA 0659 56 894",
                spaarSaldo: 1000,
                rentepercentage: 1,
                rekeningnrBetalen: "NL27 ABNA 0459 85 235",
                BetaalSaldo: 100,
                maxkrediet: 1500


                ));

            Allebankrekeninghouders.Add(new Bankrekeninghouder
                (
                voornaam: "Jesse",
                achternaam: "Grave",
                bsn: 135642897,
                gebruikersnaam: "jgrave",
                wachtwoord: "jessebank",
                rekeningnrSparen: "NL10 RABO 0397 53 459",
                spaarSaldo: 1000,
                rentepercentage: 1,
                rekeningnrBetalen: "NL30 RABO 0785 36 785",
                BetaalSaldo: 250,
                maxkrediet: 1000


                ));

            Allebankrekeninghouders.Add(new Bankrekeninghouder
                (
                voornaam: "Peter",
                achternaam: "Appel",
                bsn: 569874123,
                gebruikersnaam: "pappel",
                wachtwoord: "peterbank",
                rekeningnrSparen: "NL10 RABO 0596 53 764",
                spaarSaldo: 10000,
                rentepercentage: 1,
                rekeningnrBetalen: "NL30 RABO 0168 45 965",
                BetaalSaldo: 200,
                maxkrediet: 1000


                ));

            return Allebankrekeninghouders;
        }

        public static Bankrekeninghouder Inloggen(string _gebruikersnaam, string _wachtwoord)
        {
            var list = Allebankrekeninghouders();
            bool gebruikersnaam = true;
            bool wachtwoord = true;

            foreach (var item in list)
            {
                if (_gebruikersnaam == item.Gebruikersnaam())
                {
                    if (_wachtwoord == item.Wachtwoord())
                    {
                        return item;
                        gebruikersnaam = true;
                        wachtwoord = true;
                    }
                    else
                    {
                        wachtwoord = false;
                        //throw new ArgumentException("Uw wachtwoord is onjuist");
                    }
                }
                else
                {
                    gebruikersnaam = false;
                    //throw new ArgumentException("Uw gebruikersnaam is onjuist");
                }

            }

            if (!gebruikersnaam)
            {
                throw new ArgumentException("Uw gebruikersnaam is onjuist");
            }

            if (!wachtwoord)
            {
                throw new ArgumentException("Uw wachtwoord is onjuist");
            }

            return null;
        }
    }
}

                //Voornaam: "",
                //Achternaam: "",
                //BSN: "",
                //Gebruikersnaam: "",
                //Wachtwoord: "",
                //RekeningNrSparen: "",
                //spaarSaldo: ,
                //Renteprecentage: ,
                //RekeningNrBetalen: "",
                //BetaalSaldo: "",
                //maxKrediet: ""
                //));