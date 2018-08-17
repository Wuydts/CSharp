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

namespace WPF___ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>();
            matches.Add(new Match() { Team1 = "SF Giants", Team2 = "MN Twins", Score1 = 3, Score2 = 2, Inning = 5 });
            matches.Add(new Match() { Team1 = "SF 49ers", Team2 = "MN Vikings", Score1 = 7, Score2 = 13, Inning = 3 });
            matches.Add(new Match() { Team1 = "SJ Sharks", Team2 = "Anaheim Ducks", Score1 = 2, Score2 = 2, Inning = 7 });
            lbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (lbMatches.SelectedItem as Match).Team1 + " " +
                      (lbMatches.SelectedItem as Match).Score1 + " " +
                      (lbMatches.SelectedItem as Match).Team2 + " " +
                      (lbMatches.SelectedItem as Match).Score2);
                    
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Inning { get; set; }

    }


}
