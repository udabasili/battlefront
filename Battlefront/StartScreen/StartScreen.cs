

using GameLogic;
using GameUI;

namespace StartScreen
{
    public partial class StartScreen : Form


    {
        private AddPlayerScreen addPlayerScreen;
        private GameScreen gameScreen;
        Game game = new Game();

        public StartScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Go to the AddPlayerScreen form(screen) only if the player count is less than 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            addPlayerScreen = new AddPlayerScreen(this.game);
            this.Hide();
            if (game.GetPlayers().Count == 2)
            {
                this.Show();
                throw new ArgumentException("You can only add two players");
            }
            else
            {
                if (addPlayerScreen.ShowDialog() == DialogResult.OK)
                {
                    UpdateListComboBox(sender, e);
                }
               
            }
            this.Show();


        }

        /// <summary>
        /// Update the list of players in the combobox on the start screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UpdateListComboBox(object sender, EventArgs e)
        {
            try
            {
                List<Player> players = game.GetPlayers();
                lstPlayers.Items.Clear();
                if (players.Count > 0)
                {
                    foreach (Player player in players)
                    {
                        lstPlayers.Items.Add(player.Name);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().Name, default, MessageBoxIcon.Error);

            }


        }

        /// <summary>
        /// Navigate to the GameScreen form(screen) only if there are two players added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (game.players.Count == 2)
                {

                    gameScreen = new GameScreen(game);
                    this.Hide();

                    gameScreen.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new ArgumentException("You need two players to start the game");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().Name, default, MessageBoxIcon.Error);

            }

           
        }

    
    }
}
