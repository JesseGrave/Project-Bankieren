using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Businesslayer;

namespace ProjectBankieren
{
    /// <summary>
    /// Interaction logic for BetaalRekeningxaml.xaml
    /// </summary>
    /// 
    
    public partial class BetaalRekeningxaml : Window
    {
        private Bankrekeninghouder bankrekeninghouder;

        //CONSTRUCTOR
        public BetaalRekeningxaml(Bankrekeninghouder _bankrekeninghouder)
        {
            InitializeComponent();
            this.bankrekeninghouder = _bankrekeninghouder;
            lblHuidigSaldo.Content = bankrekeninghouder.betaalRekening.bankSaldo;
        }

        /// <summary>
        /// Voor het terug navigeren naar de persoonsgegevens window
        /// </summary>
        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            Persoonsgegevens objPersoonsgegevens = new Persoonsgegevens(this.bankrekeninghouder);
            objPersoonsgegevens.Show();
            this.Close();
        }

        /// <summary>
        /// Voor het vullen van de combobox
        /// </summary>
        private void ComboBox(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Kies uit uw contacten:");
            foreach (var contact in DataProvider.Allebankrekeninghouders)
            {
                data.Add(contact.VolledigeNaam() + " (" + contact.betaalRekening.rekeningNr + ")");
                // Niet de huidige gebruiker tonen
            }
            data.Add("Spaarrekening");
            
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;
        }

        /// <summary>
        /// Voor het overboeken van het ingevulde bedrag
        /// </summary>
        private void btnOverboeken_Click(object sender, RoutedEventArgs e)
        {
            string cbItem = cbRekeningNrs.SelectedItem.ToString();
            bool gevonden = false;

            try
            {
                Bankrekeninghouder contact;

                foreach (var item in DataProvider.Allebankrekeninghouders)
                {
                    if (cbItem == item.VolledigeNaam() + " (" + item.betaalRekening.rekeningNr + ")")
                    {
                        if(Convert.ToDecimal(tbBedrag.Text) > 0)
                        {
                            contact = item;
                            bankrekeninghouder.betaalRekening.Afschrijven(Convert.ToDecimal(tbBedrag.Text));
                            contact.betaalRekening.Bijschrijven = Convert.ToDecimal(tbBedrag.Text);
                            gevonden = true;
                            break;
                        }
                        else
                        {
                            throw new Exception("U kunt geen negatief getal overboeken.");
                        }
                    }
                    else if (cbItem == "Spaarrekening")
                    {
                        if (Convert.ToDecimal(tbBedrag.Text) > 0)
                        {
                            bankrekeninghouder.betaalRekening.Afschrijven(Convert.ToDecimal(tbBedrag.Text));
                            bankrekeninghouder.spaarRekening.Bijschrijven = Convert.ToDecimal(tbBedrag.Text);
                            gevonden = true;
                            break;
                        }
                        else
                        {
                            throw new Exception("U kunt geen negatief getal overboeken.");
                        }
                    }
                    else
                    {
                        gevonden = false;
                    }
                }

                if (!gevonden)
                {
                    MessageBox.Show("Kies een contact");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblHuidigSaldo.Content = bankrekeninghouder.betaalRekening.bankSaldo;
        }
    }
}
