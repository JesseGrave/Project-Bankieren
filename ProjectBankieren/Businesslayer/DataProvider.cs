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
                        rekeningnrSparen: "NL14 ABNA 0659 56 894",
                        spaarSaldo: 1000,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL27 ABNA 0459 85 235",
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
                        rekeningnrSparen: "NL10 RABO 0397 53 459",
                        spaarSaldo: 1000,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL30 RABO 0785 36 785",
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
                        rekeningnrSparen: "NL10 RABO 0596 53 764",
                        spaarSaldo: 10000,
                        rentepercentage: 1,
                        rekeningnrBetalen: "NL30 RABO 0168 45 965",
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
            bool gebruikersnaam = true;
            bool wachtwoord = true;

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
                        wachtwoord = false;
                        gebruikersnaam = true;
                        break;
                    }
                }
                else
                {
                    gebruikersnaam = false;
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
    }
}