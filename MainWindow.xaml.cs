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

namespace Match_Scouting_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string data = TeamNumber.Text.ToString() + "," + MatchNumber.Text.ToString() + "," + CargoPoints.Value.ToString() + "," + HatchPoints.Value.ToString() + "," + ClimbLevel.Value.ToString() + "," + DefenseRating.Value.ToString() + "," + Comments.Text.ToString();
            TeamNumber.Text = "";
            MatchNumber.Text = "";
            Comments.Text = "";
            CargoPoints.Value = 0;
            HatchPoints.Value = 0;
            ClimbLevel.Value = 0;
            DefenseRating.Value = 0;

            try
            {
                System.IO.StreamWriter sw =
                    new System.IO.StreamWriter("C: /Users/jakob/Desktop/Scouting Data.txt", true);
                sw.WriteLine(data);
                sw.Flush();
                sw.Close();
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch

            //MessageBox.Show(TeamNumber.Text.ToString() + "," + MatchNumber.Text.ToString() + "," + CargoPoints.Value.ToString() + "," + HatchPoints.Value.ToString() + "," + ClimbLevel.Value.ToString() + "," + DefenseRating.Value.ToString() + "," + Comments.Text.ToString());
            //MessageBox.Show(data);


        }
    }
}
