﻿using System;
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
        public SpaarRekening(Bankrekeninghouder _bankrekeninghouder)
        {
            InitializeComponent();
            this.bankrekeninghouder = _bankrekeninghouder;
            lblHuidigSaldo.Content = bankrekeninghouder.spaarRekening.bankSaldo;
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            Persoonsgegevens objPersoonsgegevens = new Persoonsgegevens(this.bankrekeninghouder);
            objPersoonsgegevens.Show();
            this.Close();
        }

        private void btnOverboeken_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bankrekeninghouder.spaarRekening.AfSchrijven(Convert.ToDecimal(tbBedrag.Text));
                bankrekeninghouder.betaalRekening.Bijschrijven = Convert.ToDecimal(tbBedrag.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblHuidigSaldo.Content = bankrekeninghouder.betaalRekening.bankSaldo;
        }
    }
}
