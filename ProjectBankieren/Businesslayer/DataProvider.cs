using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public static class DataProvider
    {
        public static List<Bankrekeninghouder> Allebankrekeninghouders;

        //CONSTRUCTOR

        /// <summary>
        /// Voor het vullen van de lijst met alle bankrekeninghouders
        /// </summary>
        public static void VulLijst()
        {
            if (Allebankrekeninghouders == null)
            {
                try
                {
                    Allebankrekeninghouders = new List<Bankrekeninghouder>();

                    Allebankrekeninghouders.Add(new Bankrekeninghouder
                        (
                        voornaam: "Menno",
                        achternaam: "de Lange",
                        bsn: "924613440",
                        gebruikersnaam: "mdeLange",
                        wachtwoord: "MennoBank",
                        rekeningnrSparen: "NL14 ABNA 0659 5689 64",
                        spaarSaldo: 1000,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL27 ABNA 0459 8523 85",
                        BetaalSaldo: 100,
                        maxkrediet: -1500
                        ));

                    Allebankrekeninghouders.Add(new Bankrekeninghouder
                        (
                        voornaam: "Jesse",
                        achternaam: "Grave",
                        bsn: "552499183",
                        gebruikersnaam: "jgrave",
                        wachtwoord: "jessebank",
                        rekeningnrSparen: "NL10 RABO 0397 5345 79",
                        spaarSaldo: 1000,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL30 RABO 0785 3678 25",
                        BetaalSaldo: 250,
                        maxkrediet: -1000
                        ));

                    Allebankrekeninghouders.Add(new Bankrekeninghouder
                        (
                        voornaam: "Peter",
                        achternaam: "Appel",
                        bsn: "294567471",
                        gebruikersnaam: "pappel",
                        wachtwoord: "peterbank",
                        rekeningnrSparen: "NL16 RABO 0596 5376 84",
                        spaarSaldo: 10000,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL90 RABO 0168 4596 25",
                        BetaalSaldo: 200,
                        maxkrediet: -1000
                        ));
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        //METHODES

        /// <summary>
        /// Voor het inloggen van een gebruiker
        /// </summary>
        /// <param name="_gebruikersnaam">De gebruikersnaam</param>
        /// <param name="_wachtwoord">Het wachtwoord</param>
        /// <returns></returns>
        public static Bankrekeninghouder Inloggen(string _gebruikersnaam, string _wachtwoord)
        {
            VulLijst();
            var list = Allebankrekeninghouders;

            foreach (var item in list)
            {
                if (_gebruikersnaam == item.Gebruikersnaam() && _wachtwoord == item.Wachtwoord())
                {
                    return item;
                }
            }
            throw new UnauthorizedAccessException("Uw gebruikersnaam of wachtwoord is onjuist");
        }

        /// <summary>
        /// De elfproef voor het controleren of het een geldig bsn nummer is
        /// </summary>
        /// <param name="_bsn">Het bsn nummer</param>
        /// <returns></returns>
        public static bool ElfProef(string _bsn)
        {
            if (_bsn.Length != 9)
            {
                return false;
            } 

            int i = 9;
            int total = 0;
            for (int j = 0; j < 8; j++)
            {
                char t = _bsn[j];
                total += int.Parse(t.ToString()) * i; i--;
            }
            int rest = int.Parse(_bsn[8].ToString());
            if ((total % 11) == rest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Bankrekeninghouder RekeningnrGebruiker(string _rekeningnr)
         {
             VulLijst();
             var list = Allebankrekeninghouders;
 
             foreach (var item in list)
             {
                 if (_rekeningnr == item.betaalRekening.RekeningNr)
                 {
                     return item;
                 }
 
             }
             throw new ArgumentException("Het bankrekeningnummer bestaat niet");

         }
    }
}