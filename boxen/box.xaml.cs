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

namespace boxen
{
    /// <summary>
    /// Interaction logic for box.xaml
    /// </summary>
    public partial class box : Window
    {
        List<hobby> hobbies = new List<hobby>();

        public box()
        {
            InitializeComponent();
        }

        private void Kies_Click(object sender, RoutedEventArgs e)
        {
            hobby hobber = (hobby)lbhobbies.SelectedItem;

            lbSelecties.Items.Add(hobber);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            hobbies.Add(new hobby("sport", "atletiek", new BitmapImage(new Uri(@"Images\voetbal.jpg", UriKind.Relative))));
            hobbies.Add(new hobby("sport", "basketbal", new BitmapImage(new Uri(@"Images\basketbal.jpg", UriKind.Relative))));
            hobbies.Add(new hobby("muziek", "drum", new BitmapImage(new Uri(@"Images\drum.jpg", UriKind.Relative))));
            hobbies.Add(new boxen.hobby("muziek", "gitaar", new BitmapImage(new Uri(@"Images\gitaar.jpg", UriKind.Relative))));
            hobbies.Add(new hobby("muziek", "piano", new BitmapImage(new Uri(@"Images\piano.jpg", UriKind.Relative))));
            hobbies.Add(new boxen.hobby("sport", "tennis", new BitmapImage(new Uri(@"Images\tennis.jpg", UriKind.Relative))));
            hobbies.Add(new hobby("muziek", "trompet", new BitmapImage(new Uri(@"Images\trompet.jpg", UriKind.Relative))));
            hobbies.Add(new boxen.hobby("sport", "turnen", new BitmapImage(new Uri(@"Images\turnen.jpg", UriKind.Relative))));
            hobbies.Add(new hobby("sport", "voetbal", new BitmapImage(new Uri(@"Images\voetbal.jpg", UriKind.Relative))));

            categorie.Items.Add("- alle categorien -");
            categorie.Items.Add("muziek");
            categorie.Items.Add("sport");

            categorie.SelectedIndex = 0;
        }

        private void categorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbhobbies.Items.Clear();
           // check.Text = "";
            foreach(hobby hob in hobbies)
            {
                //check.Text = check.Text + hob.Categorie;

                if ((hob.Categorie == categorie.SelectedItem.ToString()) || (categorie.SelectedIndex == 0) )
                {
                    lbhobbies.Items.Add(hob);
                }

            }

            lbhobbies.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Activiteit", System.ComponentModel.ListSortDirection.Ascending));
        }

        private void Verwijderen_Click(object sender, RoutedEventArgs e)
        {

            lbSelecties.Items.RemoveAt(lbSelecties.SelectedIndex);
      
        }

        private void Samenvatting_Click(object sender, RoutedEventArgs e)
        {
            string hobje="";
            if (MessageBox.Show("Wil je een samenvatting van je hobbies ? ","hobbies", MessageBoxButton.YesNo, MessageBoxImage.Question,MessageBoxResult.Yes )== MessageBoxResult.Yes)
                {
                foreach (var select in lbSelecties.Items )
                {
                    hobby select1 = (hobby)select;
                    hobje = hobje + ", " + select1.Activiteit.ToString(); }

                if (lbSelecties.Items.Count == 0)
                { MessageBox.Show("Geen hobbies", "Samenvatting", MessageBoxButton.OK); }
                else { MessageBox.Show(hobje, "Samenvatting",MessageBoxButton.OK); }
               
            };
        }
    }
}
