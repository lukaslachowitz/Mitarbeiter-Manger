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
    /// Interaktionslogik für MitarbeiterListen.xaml
    /// </summary>
    public partial class MitarbeiterListen : Window
    {
        ObservableCollection<Mitarbeiter> mitarbeitergelistet;
        internal MitarbeiterListen(ObservableCollection<Mitarbeiter> mb)
        {
            InitializeComponent();
            mitarbeitergelistet = DeserelizeDataToJson(mb);
            mitarblisten.ItemsSource = mitarbeitergelistet;
        }

        private static ObservableCollection<Mitarbeiter> DeserelizeDataToJson(ObservableCollection<Mitarbeiter> m)
        {
            string json = File.ReadAllText("Daten.json");
            m = JsonConvert.DeserializeObject<ObservableCollection<Mitarbeiter>>(json);
            return m;
        }

        private void mitarblisten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mitarbeiter_erstellen m = new Mitarbeiter_erstellen(mitarbeitergelistet);
            m.Show();
            this.Close();
        }
    }
}
