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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Businesslayer;

namespace ProjectBankieren
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow( )
        {
            InitializeComponent();
        }

        /// <summary>
        /// Voor het controleren van de gegevens en dan door te sturen naar de persoonsgegevens window
        /// </summary>
        private void btnInloggen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Bankrekeninghouder hudigeGebruiker = DataProvider.Inloggen(tbGebruikersNaam.Text, tbWachtwoord.Password);

                Persoonsgegevens objPersoonsgegevens = new Persoonsgegevens(hudigeGebruiker);
                objPersoonsgegevens.Show();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
