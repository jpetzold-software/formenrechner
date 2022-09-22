using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace Beleg
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow Hauptmenue = new MainWindow();

        public Window2()
        {
            InitializeComponent();
            btnXML.IsEnabled = false;

            /*Schablonen für alle möglichen/existierenden Formen bzw. Körper
             hinterlegen der zwingend erforderlichen Groeßen*/
            switch (Globals.item)
            {
                case 0:
                    cbxItemName.Content = "Rechteck";
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbBreite.IsEnabled = true;
                    tbBreite.Background = Brushes.LightPink;
                    tbDiagonale.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    break;

                case 1:
                    cbxItemName.Content = "Quadrat";
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbDiagonale.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    break;

                case 2:
                    cbxItemName.Content = "Trapez";
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbLaenge2.IsEnabled = true;
                    tbLaenge2.Background = Brushes.LightPink;
                    tbBreite.IsEnabled = true;
                    tbBreite.Background = Brushes.LightPink;
                    tbBreite2.IsEnabled = true;
                    tbBreite2.Background = Brushes.LightPink;
                    tbHoehe.IsEnabled = true;
                    tbHoehe.Background = Brushes.LightPink;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    break;

                case 3:
                    cbxItemName.Content = "Parallelogramm";
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbBreite.IsEnabled = true;
                    tbBreite.Background = Brushes.LightPink;
                    tbHoehe.IsEnabled = true;
                    tbHoehe.Background = Brushes.LightPink;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    break;

                case 4:
                    cbxItemName.Content = "Kreis";
                    tbRadius.IsEnabled = true;
                    tbRadius.Background = Brushes.LightPink;
                    tbDurchmesser.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    break;

                case 5:
                    cbxItemName.Content = "Dreieck";
                    tbKathete.IsEnabled = true;
                    tbKathete.Background = Brushes.LightPink;
                    tbAnkathete.IsEnabled = true;
                    tbAnkathete.Background = Brushes.LightPink;
                    tbHypotenuse.IsEnabled = true;
                    tbHypotenuse.Background = Brushes.LightPink;
                    tbHoehe.IsEnabled = true;
                    tbHoehe.Background = Brushes.LightPink;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    break;

                case 6:
                    cbxItemName.Content = "Würfel";
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    break;

                case 7:
                    cbxItemName.Content = "Kegel";
                    tbHoehe.IsEnabled = true;
                    tbHoehe.Background = Brushes.LightPink;
                    tbRadius.IsEnabled = true;
                    tbRadius.Background = Brushes.LightPink;
                    tbDurchmesser.IsEnabled = true;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    break;

                case 8:
                    cbxItemName.Content = "Pyramide";
                    tbHoehe.IsEnabled = true;
                    tbHoehe.Background = Brushes.LightPink;
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    break;

                case 9:
                    cbxItemName.Content = "Kugel";
                    tbDurchmesser.IsEnabled = true;
                    tbDurchmesser.Background = Brushes.LightPink;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    break;

                case 10:
                    cbxItemName.Content = "Quader";
                    tbLaenge.IsEnabled = true;
                    tbLaenge.Background = Brushes.LightPink;
                    tbBreite.IsEnabled = true;
                    tbBreite.Background = Brushes.LightPink;
                    tbHoehe.IsEnabled = true;
                    tbHoehe.Background = Brushes.LightPink;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    break;

                default:
                    break;
            }
        }

        //Getter und Setter
        public void setLaenge(double laenge)
        {
            tbLaenge.Text = Convert.ToString(laenge);
        }

        public double getLaenge()
        {
            if (tbLaenge.Text == "") { return 0; }
            else if (tbLaenge.Text == "Länge") { return -1; }
            else { return Convert.ToDouble(tbLaenge.Text); }
        }

        public void setBreite(double breite)
        {
            tbBreite.Text = Convert.ToString(breite);
        }

        public double getBreite()
        {
            if (tbBreite.Text == "") { return 0; }
            else if (tbBreite.Text == "Breite") { return -1; }
            else { return Convert.ToDouble(tbBreite.Text); }
        }

        public void setDiagonale(double diagonale)
        {
            tbDiagonale.Text = Convert.ToString(diagonale);
        }

        public double getDiagonale()
        {
            if (tbDiagonale.Text == "") { return 0; }
            else if (tbDiagonale.Text == "Diagonale") { return -1; }
            else { return Convert.ToDouble(tbDiagonale.Text); }
        }

        public void setFlaeche(double flaeche)
        {
            tbFlaeche.Text = Convert.ToString(flaeche);
        }

        public double getFlaeche()
        {
            if (tbFlaeche.Text == "") { return 0; }
            else if (tbFlaeche.Text == "Fläche") { return -1; }
            else { return Convert.ToDouble(tbFlaeche.Text); }
        }

        public void setUmfang(double umfang)
        {
            tbUmfang.Text = Convert.ToString(umfang);
        }

        public double getUmfang()
        {
            if (tbUmfang.Text == "") { return 0; }
            else if (tbUmfang.Text == "Umfang") { return -1; }
            else { return Convert.ToDouble(tbUmfang.Text); }
        }

        public void setHoehe(double hoehe)
        {
            tbHoehe.Text = Convert.ToString(hoehe);
        }

        public double getHoehe()
        {
            if (tbHoehe.Text == "") { return 0; }
            else if (tbHoehe.Text == "Höhe") { return -1; }
            else { return Convert.ToDouble(tbHoehe.Text); }
        }

        public void setRadius(double radius)
        {
            tbRadius.Text = Convert.ToString(radius);
        }

        public double getRadius()
        {
            if (tbRadius.Text == "") { return 0; }
            else if (tbRadius.Text == "Radius") { return -1; }
            else { return Convert.ToDouble(tbRadius.Text); }
        }

        public void setDurchmesser(double durchmesser)
        {
            tbDurchmesser.Text = Convert.ToString(durchmesser);
        }

        public double getDurchmesser()
        {
            if (tbDurchmesser.Text == "") { return 0; }
            else if (tbDurchmesser.Text == "Durchmesser") { return -1; }
            else { return Convert.ToDouble(tbDurchmesser.Text); }
        }

        public void setKathete(double kathete)
        {
            tbKathete.Text = Convert.ToString(kathete);
        }

        public double getKathete()
        {
            if (tbKathete.Text == "") { return 0; }
            else if (tbKathete.Text == "Kathete (a)") { return -1; }
            else { return Convert.ToDouble(tbKathete.Text); }
        }

        public void setAnkathete(double ankathete)
        {
            tbAnkathete.Text = Convert.ToString(ankathete);
        }

        public double getAnkathete()
        {
            if (tbAnkathete.Text == "") { return 0; }
            else if (tbAnkathete.Text == "Ankathete (b)") { return -1; }
            else { return Convert.ToDouble(tbAnkathete.Text); }
        }

        public void setHypotenuse(double hypotenuse)
        {
            tbHypotenuse.Text = Convert.ToString(hypotenuse);
        }

        public double getHypotenuse()
        {
            if (tbHypotenuse.Text == "") { return 0; }
            else if (tbHypotenuse.Text == "Hypotenuse (c)") { return -1; }
            else { return Convert.ToDouble(tbHypotenuse.Text); }
        }

        public void setOberflaeche(double oberflaeche)
        {
            tbOberflaeche.Text = Convert.ToString(oberflaeche);
        }

        public double getOberflaeche()
        {
            if (tbOberflaeche.Text == "") { return 0; }
            else if (tbOberflaeche.Text == "Oberfläche") { return -1; }
            else { return Convert.ToDouble(tbOberflaeche.Text); }
        }

        public void setVolumen(double volumen)
        {
            tbVolumen.Text = Convert.ToString(volumen);
        }

        public double getVolumen()
        {
            if (tbVolumen.Text == "") { return 0; }
            else if (tbVolumen.Text == "Volumen") { return -1; }
            else { return Convert.ToDouble(tbVolumen.Text); }
        }

        public void setLaenge2(double laenge2)
        {
            tbLaenge2.Text = Convert.ToString(laenge2);
        }

        public double getLaenge2()
        {
            if (tbLaenge2.Text == "") { return 0; }
            else if (tbLaenge2.Text == "Länge 2") { return -1; }
            else { return Convert.ToDouble(tbLaenge2.Text); }
        }

        public void setBreite2(double breite2)
        {
            tbBreite2.Text = Convert.ToString(breite2);
        }

        public double getBreite2()
        {
            if (tbBreite2.Text == "") { return 0; }
            else if (tbBreite2.Text == "Breite 2") { return -1; }
            else { return Convert.ToDouble(tbBreite2.Text); }
        }

        /*Klassen zur Serialisierung der Daten in XML Format*/
        [Serializable]
        public class Form
        {
            public double Breite { get; set; }
            public double Laenge { get; set; }
            public double Diagonale { get; set; }
            public double Flaeche { get; set; }
            public double Umfang { get; set; }
            public double Hoehe { get; set; }
            public double Radius { get; set; }
            public double Durchmesser { get; set; }
            public double Kathete { get; set; }
            public double Ankathete { get; set; }
            public double Hypotenuse { get; set; }
            public double Oberflaeche { get; set; }
            public double Volumen { get; set; }
            public double Laenge2 { get; set; }
            public double Breite2 { get; set; }


            /*Objekte*/
            public Form(double breite, double laenge, double diagonale, double flaeche, double umfang, double hoehe, double radius, double durchmesser, double kathete, double ankathete, double hypotenuse, double oberflaeche, double volumen, double laenge2, double breite2 )
            {
                Breite = breite;
                Laenge = laenge;
                Diagonale = diagonale;
                Flaeche = flaeche;
                Umfang = umfang;
                Hoehe = hoehe;
                Radius = radius;
                Durchmesser = durchmesser;
                Kathete = kathete;
                Ankathete = ankathete;
                Hypotenuse = hypotenuse;
                Oberflaeche = oberflaeche;
                Volumen = volumen;
                Laenge2 = laenge2;
                Breite2 = breite2;
            }

            public Form() { }

        }

        /*Berechnungen mit allen Formeln und pruefen ob existiert*/
        private int berechne(int form)
        {
            if (getLaenge() != -1 && getBreite() != -1 && getDiagonale() != -1 && getFlaeche() != -1 && getUmfang() != -1 && getRadius() != -1 && getDurchmesser() != -1 && getOberflaeche() != -1 && getVolumen() != -1 && getBreite2() != -1 && getLaenge2() != -1 && getHoehe() != -1 && getHypotenuse() != -1 && getKathete() != -1 && getAnkathete() != -1)
            {
                btnXML.IsEnabled = true;
            }

            switch (form)
            {
                case 0:
                    /*cbxItemName.Content = "Rechteck";
                    tbLaenge.IsEnabled = true;
                    tbBreite.IsEnabled = true;
                    tbDiagonale.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    */
                    if (getLaenge() != -1 && getBreite() != -1)
                    {
                        double d0 = Math.Sqrt(Math.Pow(getLaenge(), 2) + Math.Pow(getBreite(), 2));
                        tbFlaeche.Text = Convert.ToString(getBreite() * getLaenge());
                        tbUmfang.Text = Convert.ToString(getLaenge() * 2 + getBreite() * 2);
                        tbDiagonale.Text = Convert.ToString(Math.Round(d0, 3));
                    }

                    break;

                case 1:
                    /*cbxItemName.Content = "Quadrat";
                    tbLaenge.IsEnabled = true;
                    tbDiagonale.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    */

                    if (getLaenge() != -1)
                    {

                        double d1 = Math.Sqrt(Math.Pow(getLaenge(), 2) * 2);
                        tbLaenge.FontStyle = FontStyles.Italic;
                        tbLaenge.Text = Convert.ToString(getLaenge());
                        tbFlaeche.Text = Convert.ToString(Math.Pow(getLaenge(), 2));
                        tbUmfang.Text = Convert.ToString(getLaenge() * 4);
                        tbDiagonale.Text = Convert.ToString(Math.Round(d1, 3));
                    }

                    break;

                case 2:
                    /*cbxItemName.Content = "Trapez";
                    tbLaenge.IsEnabled = true;
                    tbBreite.IsEnabled = true;
                    tbHoehe.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    */
                    if (getLaenge() != -1 && getLaenge2() != -1 && getHoehe() != -1)
                    {
                        tbFlaeche.Text = Convert.ToString(0.5 * (getLaenge() + getLaenge2()) * getHoehe());
                        tbUmfang.Text = Convert.ToString(getLaenge() + getBreite() + getLaenge2() + getBreite2());
                    }

                    break;
                    


                case 3:
                    /*cbxItemName.Content = "Parallelogramm";
                    tbLaenge.IsEnabled = true;
                    tbBreite.IsEnabled = true;
                    tbHoehe.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    */

                    if (getLaenge() != -1 && getHoehe() != -1 && getBreite() != -1)
                    {
                        tbFlaeche.Text = Convert.ToString(getLaenge() * getHoehe());
                        tbUmfang.Text = Convert.ToString(getLaenge() * 2 + getBreite() * 2);
                    }

                    break;

                case 4:
                    /*cbxItemName.Content = "Kreis";
                    tbRadius.IsEnabled = true;
                    tbDurchmesser.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    */

                    if (getRadius() != -1)
                    {
                        tbDurchmesser.Text = Convert.ToString(getRadius() * 2);
                        tbFlaeche.Text = Convert.ToString(Math.PI * Math.Pow(getRadius(), 2));
                        tbUmfang.Text = Convert.ToString(2 * Math.PI * getRadius());
                    }

                    break;

                case 5:
                    /*cbxItemName.Content = "Dreieck";
                    tbKathete.IsEnabled = true;
                    tbAnkathete.IsEnabled = true;
                    tbHypotenuse.IsEnabled = true;
                    tbHoehe.IsEnabled = true;
                    tbFlaeche.IsEnabled = true;
                    tbUmfang.IsEnabled = true;
                    */


                    if (getHoehe() != -1 && getHypotenuse() != -1 && getKathete() != -1 && getAnkathete() != -1)
                    {
                        tbFlaeche.Text = Convert.ToString(0.5 * (getHoehe() * getHypotenuse()));
                        tbUmfang.Text = Convert.ToString(getKathete() + getAnkathete() + getHypotenuse());
                    }
                    break;

                case 6:
                    /*cbxItemName.Content = "Würfel";
                    tbLaenge.IsEnabled = true;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    */
                    if (getLaenge() != -1)
                    {
                        tbOberflaeche.Text = Convert.ToString(6 * Math.Pow(getLaenge(), 2));
                        tbVolumen.Text = Convert.ToString(Math.Pow(getLaenge(), 3));
                        tbBreite.Text = Convert.ToString(getLaenge());
                    }

                    break;

                case 7:
                    /*cbxItemName.Content = "Kegel";
                    tbHoehe.IsEnabled = true;
                    tbRadius.IsEnabled = true;
                    tbDurchmesser.IsEnabled = true;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    */

                    if (getRadius() != -1 && getHoehe() != -1)
                    {
                        double s = Math.Sqrt(Math.Pow(getRadius(), 2) + Math.Pow(getHoehe(), 2));
                        tbDurchmesser.Text = Convert.ToString(2 * getRadius());
                        tbOberflaeche.Text = Convert.ToString(Math.PI * getRadius() * (getRadius() * s));
                        tbVolumen.Text = Convert.ToString(Math.PI / 3 * Math.Pow(getRadius(), 2) * getHoehe());
                    }

                    break;

                case 8:
                    /*cbxItemName.Content = "Pyramide";
                    tbHoehe.IsEnabled = true;
                    tbLaenge.IsEnabled = true;
                    tbBreite.IsEnabled = true;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    */
                    if (getLaenge() != -1 && getHoehe() != -1)
                    {
                        tbBreite.Text = Convert.ToString(getLaenge());
                        tbOberflaeche.Text = Convert.ToString(getLaenge() * (getLaenge() + 2 * getHoehe()));
                        tbVolumen.Text = Convert.ToString(1 / 3 * (Math.Pow(getLaenge(), 2) * getHoehe()));
                    }

                    break;

                case 9:
                    /*cbxItemName.Content = "Kugel";
                    tbRadius.IsEnabled = true;
                    tbDurchmesser.IsEnabled = true;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    */
                    if (getDurchmesser() != -1)
                    {
                        tbRadius.Text = Convert.ToString(0.5 * getDurchmesser());
                        tbOberflaeche.Text = Convert.ToString(4 * Math.PI * Math.Pow(getRadius(), 2));
                        tbVolumen.Text = Convert.ToString(4 / 3 * Math.PI * Math.Pow(getRadius(), 3));
                    }

                    break;

                case 10:
                    /*cbxItemName.Content = "Quader";
                    tbLaenge.IsEnabled = true;
                    tbBreite.IsEnabled = true;
                    tbOberflaeche.IsEnabled = true;
                    tbVolumen.IsEnabled = true;
                    */
                    if (getLaenge() != -1 && getBreite() != -1 && getHoehe() != -1)
                    {
                        tbOberflaeche.Text = Convert.ToString(2 * (getLaenge() * getBreite() + getLaenge() * getHoehe() + getBreite() * getHoehe()));
                        tbVolumen.Text = Convert.ToString(getLaenge() * getBreite() * getHoehe());
                    }

                    break;

                default:
                    break;
            }
            return 0;      
        }

        /*Export*/
        private int exportiere(int form)
        {
            switch (form)
            {
                case 0:
                    /*Rechteck*/
                    Form rechteck = new Form(getBreite(), getLaenge(), getDiagonale(), getFlaeche(), getUmfang(), getBreite(), 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    /*Abfrage ob die Datei bereits existiert*/
                    if (File.Exists("C:/Users/julie/Desktop/rechteck.xml") == false)
                    {
                        XmlTextWriter xmlWriter0 = new XmlTextWriter("C:/Users/julie/Desktop/rechteck.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer0 = new XmlSerializer(typeof(Form));
                        xmlSerializer0.Serialize(xmlWriter0, rechteck);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/rechteck.xml");
                            XmlTextWriter xmlWriter0 = new XmlTextWriter("C:/Users/julie/Desktop/rechteck.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer0 = new XmlSerializer(typeof(Form));
                            xmlSerializer0.Serialize(xmlWriter0, rechteck);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 1:
                    //Quadrat
                    Form quadrat = new Form(getBreite(), getLaenge(), getDiagonale(), getFlaeche(), getUmfang(), getBreite(), 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/quadrat.xml") == false)
                    {
                        XmlTextWriter xmlWriter1 = new XmlTextWriter("C:/Users/julie/Desktop/rechteck.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(Form));
                        xmlSerializer1.Serialize(xmlWriter1, quadrat);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/quadrat.xml");
                            XmlTextWriter xmlWriter1 = new XmlTextWriter("C:/Users/julie/Desktop/quadrat.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(Form));
                            xmlSerializer1.Serialize(xmlWriter1, quadrat);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 2:
                    //Trapez
                    Form trapez = new Form(getBreite(), getLaenge(), 0, getFlaeche(), getUmfang(), 0, 0, 0, 0, 0, 0, 0, 0, getLaenge2(), getBreite2());

                    if (File.Exists("C:/Users/julie/Desktop/trapez.xml") == false)
                    {
                        XmlTextWriter xmlWriter2 = new XmlTextWriter("C:/Users/julie/Desktop/trapez.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Form));
                        xmlSerializer2.Serialize(xmlWriter2, trapez);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/trapez.xml");
                            XmlTextWriter xmlWriter2 = new XmlTextWriter("C:/Users/julie/Desktop/trapez.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(Form));
                            xmlSerializer2.Serialize(xmlWriter2, trapez);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 3:
                    //Parallelogramm
                    Form parallelogramm = new Form(getBreite(), getLaenge(), 0, getFlaeche(), getUmfang(), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/parallelogramm.xml") == false)
                    {
                        XmlTextWriter xmlWriter3 = new XmlTextWriter("C:/Users/julie/Desktop/parallelogramm.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer3 = new XmlSerializer(typeof(Form));
                        xmlSerializer3.Serialize(xmlWriter3, parallelogramm);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/parallelogramm.xml");
                            XmlTextWriter xmlWriter3 = new XmlTextWriter("C:/Users/julie/Desktop/parallelogramm.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer3 = new XmlSerializer(typeof(Form));
                            xmlSerializer3.Serialize(xmlWriter3, parallelogramm);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 4:
                    //Kreis
                    Form kreis = new Form(0, 0, 0, getFlaeche(), getUmfang(), 0, getRadius(), getDurchmesser(), 0, 0, 0, 0, 0, 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/kreis.xml") == false)
                    {
                        XmlTextWriter xmlWriter4 = new XmlTextWriter("C:/Users/julie/Desktop/kreis.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer4 = new XmlSerializer(typeof(Form));
                        xmlSerializer4.Serialize(xmlWriter4, kreis);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/kreis.xml");
                            XmlTextWriter xmlWriter4 = new XmlTextWriter("C:/Users/julie/Desktop/kreis.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer4 = new XmlSerializer(typeof(Form));
                            xmlSerializer4.Serialize(xmlWriter4, kreis);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 5:
                    //Dreieck
                    Form dreieck = new Form(0,0,0,getFlaeche(),getUmfang(),getHoehe(),0,0,getKathete(),getAnkathete(),getHypotenuse(),0,0,0,0);

                    if (File.Exists("C:/Users/julie/Desktop/dreieck.xml") == false)
                    {
                        XmlTextWriter xmlWriter5 = new XmlTextWriter("C:/Users/julie/Desktop/dreieck.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer5 = new XmlSerializer(typeof(Form));
                        xmlSerializer5.Serialize(xmlWriter5, dreieck);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/dreieck.xml");
                            XmlTextWriter xmlWriter5 = new XmlTextWriter("C:/Users/julie/Desktop/dreieck.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer5 = new XmlSerializer(typeof(Form));
                            xmlSerializer5.Serialize(xmlWriter5, dreieck);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 6:
                    //Würfel
                    Form wuerfel = new Form(getLaenge(), getLaenge(), 0, 0, 0, getLaenge(), 0, 0, 0, 0, 0, getOberflaeche(), getVolumen(), 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/wuerfel.xml") == false)
                    {
                        XmlTextWriter xmlWriter6 = new XmlTextWriter("C:/Users/julie/Desktop/wuerfel.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer6 = new XmlSerializer(typeof(Form));
                        xmlSerializer6.Serialize(xmlWriter6, wuerfel);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/wuerfel.xml");
                            XmlTextWriter xmlWriter6 = new XmlTextWriter("C:/Users/julie/Desktop/wuerfel.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer6 = new XmlSerializer(typeof(Form));
                            xmlSerializer6.Serialize(xmlWriter6, wuerfel);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 7:
                    //Kegel
                    Form kegel = new Form(0, 0, 0, 0, 0, getHoehe(), getRadius(), getDurchmesser(), 0, 0, 0, getOberflaeche(), getVolumen(), 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/kegel.xml") == false)
                    {
                        XmlTextWriter xmlWriter7 = new XmlTextWriter("C:/Users/julie/Desktop/kegel.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer7 = new XmlSerializer(typeof(Form));
                        xmlSerializer7.Serialize(xmlWriter7, kegel);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/kegel.xml");
                            XmlTextWriter xmlWriter7 = new XmlTextWriter("C:/Users/julie/Desktop/kegel.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer7 = new XmlSerializer(typeof(Form));
                            xmlSerializer7.Serialize(xmlWriter7, kegel);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 8:
                    //Pyramide
                    Form pyramide = new Form(getLaenge(), getLaenge(), 0, 0, 0, getHoehe(), 0, 0, 0, 0, 0, getOberflaeche(), getVolumen(), 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/pyramide.xml") == false)
                    {
                        XmlTextWriter xmlWriter8 = new XmlTextWriter("C:/Users/julie/Desktop/pyramide.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer8 = new XmlSerializer(typeof(Form));
                        xmlSerializer8.Serialize(xmlWriter8, pyramide);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/pyramide.xml");
                            XmlTextWriter xmlWriter8 = new XmlTextWriter("C:/Users/julie/Desktop/pyramide.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer8 = new XmlSerializer(typeof(Form));
                            xmlSerializer8.Serialize(xmlWriter8, pyramide);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 9:
                    //Kugel
                    Form kugel = new Form(0, 0, 0, 0, 0, 0, getRadius(), getDurchmesser(), 0, 0, 0, getOberflaeche(), getVolumen(), 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/kugel.xml") == false)
                    {
                        XmlTextWriter xmlWriter9 = new XmlTextWriter("C:/Users/julie/Desktop/kugel.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer9 = new XmlSerializer(typeof(Form));
                        xmlSerializer9.Serialize(xmlWriter9, kugel);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/kugel.xml");
                            XmlTextWriter xmlWriter9 = new XmlTextWriter("C:/Users/julie/Desktop/kugel.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer9 = new XmlSerializer(typeof(Form));
                            xmlSerializer9.Serialize(xmlWriter9, kugel);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                case 10:
                    //Quader
                    Form quader = new Form(getLaenge(), getBreite(), 0, 0, 0, getHoehe(), 0, 0, 0, 0, 0, getOberflaeche(), getVolumen(), 0, 0);

                    if (File.Exists("C:/Users/julie/Desktop/quader.xml") == false)
                    {
                        XmlTextWriter xmlWriter10 = new XmlTextWriter("C:/Users/julie/Desktop/quader.xml", Encoding.UTF8);
                        XmlSerializer xmlSerializer10 = new XmlSerializer(typeof(Form));
                        xmlSerializer10.Serialize(xmlWriter10, quader);
                    }

                    else
                    {
                        MessageBoxResult m = MessageBox.Show("Die Datei existiert bereits. Überschreiben?", "Warnung", MessageBoxButton.YesNo);
                        if (m == MessageBoxResult.Yes)
                        {
                            File.Delete("C:/Users/julie/Desktop/quader.xml");
                            XmlTextWriter xmlWriter10 = new XmlTextWriter("C:/Users/julie/Desktop/quader.xml", Encoding.UTF8);
                            XmlSerializer xmlSerializer10 = new XmlSerializer(typeof(Form));
                            xmlSerializer10.Serialize(xmlWriter10, quader);
                        }
                        else if (m == MessageBoxResult.No)
                        {
                            //blank
                        }
                    }

                    break;

                default:
                    break;

            }
            return 0;
        }
        
        




        /*Knopfhandler*/
        private void btnBerechne_Click(object sender, RoutedEventArgs e)
        {
            berechne(Globals.item);
        }

        private void btnZurueck_Click(object sender, RoutedEventArgs e)
        {
            Hauptmenue.Show();
            this.Close();
        }

        private void btnXML_Click(object sender, RoutedEventArgs e)
        {
            exportiere(Globals.item);
        }
        
    }
}
