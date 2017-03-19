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

namespace ProjectBankieren
{
    /// <summary>
    /// Interaction logic for SpaarRekening.xaml
    /// </summary>
    public partial class SpaarRekening : Window
    {
        public SpaarRekening()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            // In persoons gegevens moet nog de huidige gebruiker

            //Persoonsgegevens objPersoonsgegevens = new Persoonsgegevens();
            //objPersoonsgegevens.Show();
            //this.Close();
        }
    }
}
