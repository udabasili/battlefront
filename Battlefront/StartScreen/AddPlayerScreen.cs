using GameLogic;

namespace GameUI
{
    public partial class AddPlayerScreen : Form
    {
        Game game;
        public AddPlayerScreen( Game game)
        {
            InitializeComponent();
            txtPlayerID.Text = GeneratePlayerID();
            this.game = game;
        }

        static string GeneratePlayerID()
        {
            Guid randomGuid = Guid.NewGuid();
            string randomId = randomGuid.ToString();
            return randomId;
        }


        private void btnSubmitPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                string playerID = txtPlayerID.Text;
                string playerName = txtPlayerName.Text;

                if (playerName == "")
                {
                    txtPlayerName.Focus();
                    throw new ArgumentException("Player name can be empty ");
                }

                Player player = new Player(playerID, playerName);
                this.game.AddPlayer(player);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().Name, default, MessageBoxIcon.Error);
            }
        }
    }
}
