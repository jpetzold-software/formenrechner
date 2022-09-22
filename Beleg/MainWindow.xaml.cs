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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Beleg
{
    public class Globals
    {
        public static int item;
    }
        

    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            cbxAuswahl.Items.Add("Rechteck");
            cbxAuswahl.Items.Add("Quadrat");
            cbxAuswahl.Items.Add("Trapez");
            cbxAuswahl.Items.Add("Parallelogramm");
            cbxAuswahl.Items.Add("Kreis");
            cbxAuswahl.Items.Add("Dreieck");
            cbxAuswahl.Items.Add("Würfel");
            cbxAuswahl.Items.Add("Kegel");
            cbxAuswahl.Items.Add("Pyramide");
            cbxAuswahl.Items.Add("Kugel");
            cbxAuswahl.Items.Add("Quader");
        }

        private void btnAnleitung_Click(object sender, RoutedEventArgs e)
        {
            Window1 dialog = new Window1();
            dialog.ShowDialog();
        }

        private void btnZurBerechnung_Click(object sender, RoutedEventArgs e)
        {
            if (cbxAuswahl.SelectedIndex != -1)
            {
                Globals.item = cbxAuswahl.SelectedIndex;
                Window2 eingabe = new Window2();
                eingabe.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Keine gültige Eingabe", "Warnung", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
