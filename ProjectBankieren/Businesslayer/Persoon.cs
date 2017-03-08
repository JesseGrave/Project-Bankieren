using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Persoon
    {
        // PROPERTIES
        private string gebruikersnaam;

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
            set { gebruikersnaam = value; }
        }

        private string wachtwoord;

        public string Wachtwoord
        {
            get { return wachtwoord; }
            set { wachtwoord = value; }
        }

        private string voornaam;

        public string Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; }
        }

        private string achternaam;

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        private int bsn;

        public int BSN
        {
            get { return bsn; }
            set { bsn = value; }
        }

        // CONSTRUCTOR

        public Persoon(string _gebruikersnaam, string _wachtwoord, string _voornaam, string _achternaam, int _bsn)
        {
            this.gebruikersnaam = _gebruikersnaam;
            this.wachtwoord = _wachtwoord;
            this.voornaam = _voornaam;
            this.achternaam = _achternaam;
            this.bsn = _bsn;
        }

        // METHODES
    }
}
