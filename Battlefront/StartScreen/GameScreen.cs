using GameLogic;
using Newtonsoft.Json;
using System.Diagnostics;
using static GameLogic.Game;

namespace GameUI
{
    public partial class GameScreen : Form
    {
        private Game game;
        private Panel currentPanel;
        private Card selectedCardPlayer1;
        private Card selectedCardPlayer2;
        private List<Panel> panels = new List<Panel>();
        private ProgressBar play1Life;
        private ProgressBar play2Life;
        private List<Player> players = new List<Player>();

        public GameScreen(Game game)
        {
            InitializeComponent();
            this.game = game;
            players = game.GetPlayers();
            this.SetUp();
            this.MakeDeck();
        }

        /// <summary>
        /// Display the selected card 
        /// </summary>
        /// <param name="card"></param>
        /// <param name="player"></param>
        private void ShowAttackCard(Card card, Player player)
        {
            Panel PanelBattleArea;

            Image resizedImage = Card.ResizeImage(card.ImageFile, 500, 500);

            if (player == players[0])
            {
                PanelBattleArea = this.PanelBattleArea1;
            }
            else
            {
                PanelBattleArea = PanelBattleArea2;
            }

            PanelBattleArea.Controls.Clear();

           
            PictureBox aPic = new PictureBox();
            {
                aPic.Image = resizedImage;
                aPic.Width = this.PanelBattleArea1.Width;
                aPic.Height = 600;
                aPic.Left = 0;
                aPic.Top = 0;

            }

            PanelBattleArea.Controls.Add(aPic);
        }

        /// <summary>
        /// Player selects the card to attack with
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="player"></param>
        /// <param name="panel"></param>
        public void DrawAttackCard(object sender, Player player, Panel panel)
        {
            PictureBox pictureBox = sender as PictureBox;
            Card card = pictureBox.Tag as Card;

            if (pictureBox != null)
            {
                {
                    if (selectedCardPlayer1 != null && card.Name == selectedCardPlayer1.Name)
                    {
                        return;
                    }
                    if (selectedCardPlayer2 != null && card.Name == selectedCardPlayer2.Name)
                    {
                        return;
                    }



                    if (player == game.GetPlayers()[0])
                    {
                        selectedCardPlayer1 = card;
                        ShowAttackCard(selectedCardPlayer1, player);
                    }
                    else if (player == game.GetPlayers()[1])
                    {
                        selectedCardPlayer2 = card;
                        ShowAttackCard(selectedCardPlayer2, player);
                    }
                }
            }

        }

       

        /// <summary>
        /// Make the deck of cards for each player
        /// </summary>
        private void MakeDeck()
        {
            List<Card> cards = game.GameCards ;
            List<Player> players = game.GetPlayers();
            int xPos = 0;

            Debug.WriteLine("Total cards: " + cards.Count());


            for (int i = 0; i < players.Count(); i++)
            {
                xPos = 0;

                Player player = players[i];
                player.Deck = cards.Take(5).ToList();
                cards.RemoveRange(0, 5);

                currentPanel = panels[i];

                foreach (Card card in player.Deck)
                {

                    PictureBox aPic = new PictureBox();
                    {
                        aPic.Image = card.ResizedImageFile;
                        aPic.Width = 200;
                        aPic.Height = 200;
                        aPic.Left = xPos;
                        aPic.Tag = card;
                        aPic.Click += (s, args) => DrawAttackCard(s, player, currentPanel);
                    }

                    xPos += 220;
                    currentPanel.Controls.Add(aPic);
                }
            }

        }


        /// <summary>
        ///  Loads the game setting the life bars and card decks
        /// </summary>
        private void SetUp()
        {
            List<Player> players = game.GetPlayers();
            lblPlayer1.Text = players[0].Name;
            lblPlayer2.Text = players[1].Name;

            play1Life = progressLifeBar1;
            play2Life = progressLifeBar2;

            play1Life.Minimum = 0;
            play2Life.Minimum = 0;

            play1Life.Step = 1;
            play2Life.Step = 1;

            play1Life.Maximum = players[0].Health;
            play2Life.Maximum = players[1].Health;

            play1Life.Value = players[0].Health;
            play2Life.Value = players[1].Health;

            lblPlayer1Value.Text = players[0].Health.ToString();
            lblPlayer2Value.Text = players[1].Health.ToString();

            panels.Add(PanelPlayer1);
            panels.Add(PanelPlayer2);


            try
            {
                game.ShuffleCard();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name, default, MessageBoxIcon.Error);

            }
        }

      


        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                List<Player> players = game.GetPlayers();
                Player player1 = players[0];
                Player player2 = players[1];

                if (selectedCardPlayer1 == null || selectedCardPlayer2 == null)
                {

                    throw new Exception("Please select a card for both players");
                }
                int player1TempHealth = selectedCardPlayer1.Defense - selectedCardPlayer2.Attack;
                int player2TempHealth = selectedCardPlayer2.Defense - selectedCardPlayer1.Attack;

                if (player1TempHealth <= 0)
                {

                    player1.Health = player1.Health - Math.Abs(player1TempHealth);

                    play1Life.Value = player1.Health;

                    PanelPlayer1.Controls.Remove(PanelPlayer1.Controls.OfType<PictureBox>().FirstOrDefault(x =>
                    {
                        return (x.Tag as Card).Name == selectedCardPlayer1.Name;
                    }));

                    PanelPlayer1.Update();
                    PanelBattleArea1.Controls.Clear();
                    player1.Deck.Remove(selectedCardPlayer1);

                    selectedCardPlayer1 = null;



                }
                else if (player1TempHealth > 0)
                {
                    selectedCardPlayer1.Defense = player1TempHealth;

                }

                if (player2TempHealth <= 0)
                {
                    player2.Health = player2.Health - Math.Abs(player2TempHealth);
                    play2Life.Value = player2.Health;

                    PanelPlayer2.Controls.Remove(PanelPlayer2.Controls.OfType<PictureBox>().FirstOrDefault(x =>
                    {
                        return (x.Tag as Card).Name == selectedCardPlayer2.Name;

                    }));

                    PanelPlayer2.Update();
                    PanelBattleArea2.Controls.Clear();
                    player2.Deck.Remove(selectedCardPlayer2);

                    selectedCardPlayer2 = null;


                }
                else if (player2TempHealth > 0)
                {
                    selectedCardPlayer2.Defense = player2TempHealth;

                }


                lblPlayer1Value.Text = player1.Health.ToString();
                lblPlayer2Value.Text = player2.Health.ToString();

                if (player1.Health <= 0 || player1.Deck.Count() == 0)
                {
                    MessageBox.Show($"{player2.Name} wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (player2.Health <= 0 || player2.Deck.Count() == 0)
                {
                    MessageBox.Show($"{player1.Name} wins", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().Name, default, MessageBoxIcon.Error);

            }
        }
    }
}
