using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Projekt
{
    /// <summary>
    /// Interaktionslogik für Mitarbeiter_erstellen.xaml
    /// </summary>
    public partial class Mitarbeiter_erstellen : Window
    {
        ObservableCollection<Mitarbeiter> mb = new ObservableCollection<Mitarbeiter>();

        bool saved = false; 


        public Mitarbeiter_erstellen()
        {
            InitializeComponent();
        }
        internal Mitarbeiter_erstellen(ObservableCollection<Mitarbeiter> m):this()
        {
            InitializeComponent();
            if (m != null)
            {
                vornametextfeld.Text = m[0].Vorname;
                nachnametextfeld.Text = m[0].Nachname;
                anredecombo.SelectedValue = m[0].Anrede;
                telefonnummertext.Text = m[0].Telefonnummer;
                orttextfeld.Text = m[0].Ort;
                geburtsdatumpicker.SelectedDate = m[0].Geburtsdatum;
                abteiltextfeld.Text = m[0].Abteilung;
                adressetextfeld.Text = m[0].Adresse;
                adrresszusatztextfeld.Text = m[0].Adresszusatz;
                SZtextfeld.Text = Convert.ToString(m[0].SZ);
                IBANtextfeld.Text = m[0].IBAN;
            }
        }

        private void MB_Click(object sender, RoutedEventArgs e)
        {
            MitarbeiterListen m = new MitarbeiterListen(mb);
            m.Show();
            MessageBox.Show("User wurde erstellt"); 
            this.Close();
        }

        private void Mitarbeitererstellen_Click(object sender, RoutedEventArgs e)
        {
            mb.Add(new Mitarbeiter(vornametextfeld.Text, nachnametextfeld.Text, anredecombo.Text, telefonnummertext.Text, orttextfeld.Text, (DateTime)geburtsdatumpicker.SelectedDate, abteiltextfeld.Text, adressetextfeld.Text, adrresszusatztextfeld.Text, Convert.ToDouble(SZtextfeld.Text), IBANtextfeld.Text));
            SerelizeDataToJson(mb);

        }

        private static void SerelizeDataToJson(ObservableCollection<Mitarbeiter> m)
        {
            string json = JsonConvert.SerializeObject(m, Formatting.Indented);
            File.WriteAllText("Daten.json",json);
        }

        /*private void Window_Closed(object sender, EventArgs e)
        {
            if (saved == false)
            {
                string MessageBoxText = "Wenn Sie verlassen, sind alle ungespeicherten Änderungen weg ! Wollen Sie fortfahren?";
                string caption = "Seite verlasse";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Warning;
                MessageBoxResult result = MessageBox.Show(MessageBoxText, caption, button, icon);

                if (result == MessageBoxResult.Yes)
                {

                }
            }
        }
        */
    }
}
