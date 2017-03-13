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
                rekeningnrSparen: "1593572",
                spaarSaldo: 1000,
                rentepercentage: 1,
                rekeningnrBetalen: "183272",
                BetaalSaldo: 100,
                maxkrediet: 1500
                ));

            return Allebankrekeninghouders;
        }

        public static Bankrekeninghouder Inloggen(string _gebruikersnaam, string _wachtwoord)
        {
            var list = Allebankrekeninghouders();

            foreach (var item in list)
            {
                if (_gebruikersnaam == item.Gebruikersnaam())
                {
                    if (_wachtwoord == item.Wachtwoord())
                    {
                        return item;
                    }
                    else
                    {
                        throw new ArgumentException("Uw wachtwoord is onjuist");
                        return null;
                    }
                }
                else
                {
                    throw new ArgumentException("Uw gebruikersnaam is onjuist");
                    return null;
                }
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