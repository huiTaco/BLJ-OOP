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

namespace OOP_testi1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_finish_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
       
        private void btn_Berechne_Click(object sender, RoutedEventArgs e)
        {
           
           
            int breite = Convert.ToInt32(berechnung_a.Text);
            int höhe = Convert.ToInt32(berechnung_b.Text);

            int ergebnis = breite * höhe;
            //Show.textbox_resultat(ergebnis);
            textbox_resultat.Text = ergebnis.ToString();
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            berechnung_a.Clear();
            berechnung_b.Clear();
            textbox_resultat.Clear();
        }
    }
    

}
