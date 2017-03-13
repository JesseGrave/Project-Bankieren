using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    static class DataProvider
    {
        public static List<Bankrekeninghouder> Allebankrekeninghouders()
        {
            List<Bankrekeninghouder> Allebankrekeninghouders = new List<Bankrekeninghouder>();

            Allebankrekeninghouders.Add(new Bankrekeninghouder
                (
                Voornaam: "Menno",
                Achternaam: "de Lange",
                BSN: "147258369",
                Gebruikersnaam: "mdeLange",
                Wachtwoord: "MennoBank",
                RekeningNrSparen: "1593572",
                spaarSaldo: 1000,
                Renteprecentage: 1,
                RekeningNrBetalen: "183272",
                BetaalSaldo: "100",
                maxKrediet: "1500"
                ));
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