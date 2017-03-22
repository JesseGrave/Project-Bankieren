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

        public BetaalRekeningxaml(Bankrekeninghouder _bankrekeninghouder)
        {
            InitializeComponent();
            this.bankrekeninghouder = _bankrekeninghouder;
            lblHuidigSaldo.Content = bankrekeninghouder.betaalrekening.bankSaldo;
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            Persoonsgegevens objPersoonsgegevens = new Persoonsgegevens(this.bankrekeninghouder);
            objPersoonsgegevens.Show();
            this.Close();
        }

        private void ComboBox(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Kies uit uw contacten:");
            foreach (var contact in DataProvider.Allebankrekeninghouders())
            {
                data.Add(contact.rekeninghouder.Voornaam);
            }
            data.Add("Spaarrekening");
            
            var combo = sender as ComboBox;
            combo.ItemsSource = data;
            combo.SelectedIndex = 0;
        }

        private void btnOverboeken_Click(object sender, RoutedEventArgs e)
        {
            string cbItem = cbRekeningNrs.SelectedItem.ToString();
            bool gevonden = false;
            Bankrekeninghouder contact;

            foreach (var item in DataProvider.Allebankrekeninghouders())
            {
                if (cbItem == item.rekeninghouder.Voornaam)
                {
                    contact = item;
                    gevonden = true;
                    break;
                } else if(cbItem == "Spaarrekening")
                {
                    
                } else
                {
                    gevonden = false;
                }
            }

            if (!gevonden)
            {
                MessageBox.Show("Kies een contact");
            }

        }
    }
}
