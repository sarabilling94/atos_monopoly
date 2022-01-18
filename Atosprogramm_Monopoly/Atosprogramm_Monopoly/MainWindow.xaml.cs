using System;
using System.Collections.Generic;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        public bool gameStarted = false;
        public int playerTurn = 1;
        public int playerCount;
        public Spieler player1;
        public Spieler player2;
        public Spieler player3;
        public Spieler player4;

    private void button_dice_Click(object sender, RoutedEventArgs e)
        {
            int result = Wuerfel.Wuerfeln();
            result_dice.Text = result.ToString();

            player1.position.setPosition(player1.position.getPosition() + result);

        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            txt_playeramount.Visibility = Visibility.Visible;
            txtbox_playeramount.Visibility = Visibility.Visible;

            if (txtbox_playeramount.Text != "")
            {
                LinkedList<Spieler> playerList = new LinkedList<Spieler>();

                switch (Convert.ToInt32(txtbox_playeramount.Text))
                {
                    case 1:
                        player1 = new Spieler(1, new Figur("1"), 1000, new Position(0, 0, 5));
                        playerList.AddLast(player1);

                        txt_players.Text = $"{player1.figur.Bezeichnung}";
                        img_player1.Visibility = Visibility.Visible;
                        playerCount = 1;
                        break;
                    case 2:
                        player1 = new Spieler(1, new Figur("1"), 1000, new Position(0, 0, 5));
                        player2 = new Spieler(2, new Figur("2"), 1000, new Position(0, 0, 5));
                        playerList.AddLast(player1);
                        playerList.AddLast(player2);

                        txt_players.Text = $"{player1.figur.Bezeichnung}\n{player2.figur.Bezeichnung}";
                        playerCount = 2;
                        break;
                    case 3:
                        player1 = new Spieler(1, new Figur("1"), 1000, new Position(0, 0, 5));
                        player2 = new Spieler(2, new Figur("2"), 1000, new Position(0, 0, 5));
                        player3 = new Spieler(3, new Figur("3"), 1000, new Position(0, 0, 5));
                        playerList.AddLast(player1);
                        playerList.AddLast(player2);
                        playerList.AddLast(player3);

                        txt_players.Text = $"{player1.figur.Bezeichnung}\n{player2.figur.Bezeichnung}\n{player3.figur.Bezeichnung}";
                        playerCount = 3;
                        break;
                    case 4:
                        player1 = new Spieler(1, new Figur("1"), 1000, new Position(0, 0, 5));
                        player2 = new Spieler(2, new Figur("2"), 1000, new Position(0, 0, 5));
                        player3 = new Spieler(3, new Figur("3"), 1000, new Position(0, 0, 5));
                        player4 = new Spieler(4, new Figur("4"), 1000, new Position(0, 0, 5));
                        playerList.AddLast(player1);
                        playerList.AddLast(player2);
                        playerList.AddLast(player3);
                        playerList.AddLast(player4);

                        txt_players.Text = $"{player1.figur.Bezeichnung}\n{player2.figur.Bezeichnung}\n{player3.figur.Bezeichnung}\n{player4.figur.Bezeichnung}";
                        playerCount = 4;
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
