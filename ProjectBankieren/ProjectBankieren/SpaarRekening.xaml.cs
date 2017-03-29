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
    /// Interaction logic for SpaarRekening.xaml
    /// </summary>
    public partial class SpaarRekening : Window
    {
        private Bankrekeninghouder bankrekeninghouder;

        //CONSTRUCTOR
        public SpaarRekening(Bankrekeninghouder _bankrekeninghouder)
        {
            InitializeComponent();
            this.bankrekeninghouder = _bankrekeninghouder;
            lblHuidigSaldo.Content = bankrekeninghouder.spaarRekening.BankSaldo;
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
        /// Voor het overboeken naar de betaalrekening
        /// </summary>
        private void btnOverboeken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(Convert.ToDecimal(tbBedrag.Text) > 0)
                {
                    bankrekeninghouder.NaarBetaalrekening(Convert.ToDecimal(tbBedrag.Text));
                }
                else
                {
                    throw new Exception("U kunt geen negatief getal overboeken.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lblHuidigSaldo.Content = bankrekeninghouder.spaarRekening.BankSaldo;
        }
    }
}
