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
    /// Interaction logic for Persoonsgegevens.xaml
    /// </summary>
    public partial class Persoonsgegevens : Window
    {
        private Bankrekeninghouder bankrekeninghouder;

        //CONSTRUCTOR
        public Persoonsgegevens(Bankrekeninghouder _bankrekeninghouder)
        {
            InitializeComponent();

            this.bankrekeninghouder = _bankrekeninghouder;

            lblNaam.Content = bankrekeninghouder.VolledigeNaam();
            lblBSN.Content = bankrekeninghouder.rekeningHouder.BSN;
            lblBetaalRekeningInput.Content = bankrekeninghouder.BankRekeningInzien();
            lblSpaarRekeningInput.Content = bankrekeninghouder.SpaarRekeningInzien();
        }
        
        /// <summary>
        /// Voor het door sturen naar de betaalrekening window
        /// </summary>
        private void btnBetaalRekening_Click(object sender, RoutedEventArgs e)
        {
            BetaalRekeningxaml objBetaalrekening = new BetaalRekeningxaml(this.bankrekeninghouder);
            objBetaalrekening.Show();
            this.Hide();
        }

        /// <summary>
        /// Voor het door sturen naar de spaarrekening window
        /// </summary>
        private void btnSpaarrekening_Click(object sender, RoutedEventArgs e)
        {
            SpaarRekening objSpaarRekening = new SpaarRekening(this.bankrekeninghouder);
            objSpaarRekening.Show();
            this.Hide();
        }

        /// <summary>
        /// Voor het uitloggen
        /// </summary>
        private void btnUitloggen_Click(object sender, RoutedEventArgs e)
        {
            bankrekeninghouder = null;

            MainWindow objInloggen = new MainWindow();
            objInloggen.Show();
            this.Hide();
        }
    }
}
