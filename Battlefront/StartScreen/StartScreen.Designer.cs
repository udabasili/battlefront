namespace StartScreen
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            btnStartGame = new Button();
            label1 = new Label();
            btnAddPlayer = new Button();
            lstPlayers = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.Location = new Point(129, 295);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(148, 74);
            btnStartGame.TabIndex = 7;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19F, FontStyle.Bold);
            label1.Location = new Point(288, 34);
            label1.Name = "label1";
            label1.Size = new Size(249, 40);
            label1.TabIndex = 6;
            label1.Text = "Start Screen";
            label1.Click += label1_Click;
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPlayer.Location = new Point(577, 295);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(148, 74);
            btnAddPlayer.TabIndex = 8;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // lstPlayers
            // 
            lstPlayers.FormattingEnabled = true;
            lstPlayers.Location = new Point(305, 143);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(232, 144);
            lstPlayers.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(377, 102);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 10;
            label2.Text = "Players";
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstPlayers);
            Controls.Add(btnAddPlayer);
            Controls.Add(btnStartGame);
            Controls.Add(label1);
            Name = "StartScreen";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartGame;
        private Label label1;
        private Button btnAddPlayer;
        private ListBox lstPlayers;
        private Label label2;
    }
}
