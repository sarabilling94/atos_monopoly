using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Atosprogramm_Monopoly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Spieler player1;
        public Spieler player2;
        public Spieler player3;
        public Spieler player4;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    private void button_dice_Click(object sender, RoutedEventArgs e)
        {
            result_dice.Text = Wuerfel.Wuerfeln().ToString();

            //Image testImage = new Image();
            //testImage.Source = new BitmapImage(new Uri("Media/Field_Prison.png", UriKind.Relative));

        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            txt_playeramount.Visibility = Visibility.Visible;
            txtbox_playeramount.Visibility = Visibility.Visible;

            if (txtbox_playeramount.Text != "")
            {
                switch (Convert.ToInt32(txtbox_playeramount.Text))
                {
                    case 1:
                        player1 = new Spieler(new Figur("1"), 1000, 0);
                        txt_players.Text = $"{player1.figur.Bezeichnung}";
                        break;
                    case 2:
                        player1 = new Spieler(new Figur("1"), 1000, 0);
                        player2 = new Spieler(new Figur("2"), 1000, 0);
                        txt_players.Text = $"{player1.figur.Bezeichnung}\n{player2.figur.Bezeichnung}";
                        break;
                    case 3:
                        player1 = new Spieler(new Figur("1"), 1000, 0);
                        player2 = new Spieler(new Figur("2"), 1000, 0);
                        player3 = new Spieler(new Figur("3"), 1000, 0);
                        txt_players.Text = $"{player1.figur.Bezeichnung}\n{player2.figur.Bezeichnung}\n{player3.figur.Bezeichnung}";
                        break;
                    case 4:
                        player1 = new Spieler(new Figur("1"), 1000, 0);
                        player2 = new Spieler(new Figur("2"), 1000, 0);
                        player3 = new Spieler(new Figur("3"), 1000, 0);
                        player4 = new Spieler(new Figur("4"), 1000, 0);
                        txt_players.Text = $"{player1.figur.Bezeichnung}\n{player2.figur.Bezeichnung}\n{player3.figur.Bezeichnung}\n{player4.figur.Bezeichnung}";
                        break;
                    default:
                        return;
                }

                button_dice.IsEnabled = true;
                button_start.IsEnabled = false;

                txt_playeramount.Visibility = Visibility.Hidden;
                txtbox_playeramount.Visibility = Visibility.Hidden;
            }
        }
    }
}
