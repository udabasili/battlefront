
namespace GameUI
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPlayer2 = new Label();
            lblPlayer1 = new Label();
            PanelPlayer1 = new Panel();
            PanelPlayer2 = new Panel();
            btnStartGame = new Button();
            progressLifeBar1 = new ProgressBar();
            progressLifeBar2 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            lblPlayer1Value = new Label();
            lblPlayer2Value = new Label();
            label3 = new Label();
            PanelBattleArea1 = new Panel();
            PanelBattleArea2 = new Panel();
            SuspendLayout();
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPlayer2.Location = new Point(66, 598);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(122, 41);
            lblPlayer2.TabIndex = 0;
            lblPlayer2.Text = "Player2";
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer1.Location = new Point(66, 3);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(130, 41);
            lblPlayer1.TabIndex = 1;
            lblPlayer1.Text = "Player 1";
            // 
            // PanelPlayer1
            // 
            PanelPlayer1.Location = new Point(67, 52);
            PanelPlayer1.Name = "PanelPlayer1";
            PanelPlayer1.Size = new Size(1152, 244);
            PanelPlayer1.TabIndex = 2;
            // 
            // PanelPlayer2
            // 
            PanelPlayer2.Location = new Point(66, 663);
            PanelPlayer2.Name = "PanelPlayer2";
            PanelPlayer2.Size = new Size(1138, 251);
            PanelPlayer2.TabIndex = 3;
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.Location = new Point(580, 455);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(150, 60);
            btnStartGame.TabIndex = 5;
            btnStartGame.Text = "ATTACK";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // progressLifeBar1
            // 
            progressLifeBar1.BackColor = Color.Black;
            progressLifeBar1.ForeColor = Color.Red;
            progressLifeBar1.Location = new Point(73, 352);
            progressLifeBar1.Name = "progressLifeBar1";
            progressLifeBar1.Size = new Size(1119, 29);
            progressLifeBar1.TabIndex = 6;
            // 
            // progressLifeBar2
            // 
            progressLifeBar2.BackColor = Color.Black;
            progressLifeBar2.Location = new Point(80, 534);
            progressLifeBar2.Name = "progressLifeBar2";
            progressLifeBar2.Size = new Size(1126, 29);
            progressLifeBar2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 503);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 9;
            label1.Text = "HP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 321);
            label2.Name = "label2";
            label2.Size = new Size(50, 28);
            label2.TabIndex = 10;
            label2.Text = "HP: ";
            // 
            // lblPlayer1Value
            // 
            lblPlayer1Value.AutoSize = true;
            lblPlayer1Value.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer1Value.Location = new Point(127, 321);
            lblPlayer1Value.Name = "lblPlayer1Value";
            lblPlayer1Value.Size = new Size(63, 28);
            lblPlayer1Value.TabIndex = 11;
            lblPlayer1Value.Text = "Value";
            // 
            // lblPlayer2Value
            // 
            lblPlayer2Value.AutoSize = true;
            lblPlayer2Value.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer2Value.Location = new Point(135, 503);
            lblPlayer2Value.Name = "lblPlayer2Value";
            lblPlayer2Value.Size = new Size(63, 28);
            lblPlayer2Value.TabIndex = 12;
            lblPlayer2Value.Text = "Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(414, 399);
            label3.Name = "label3";
            label3.Size = new Size(419, 28);
            label3.TabIndex = 13;
            label3.Text = "Select Card per Player Then and Press Attack";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelBattleArea1
            // 
            PanelBattleArea1.Location = new Point(1237, 3);
            PanelBattleArea1.Name = "PanelBattleArea1";
            PanelBattleArea1.Size = new Size(675, 490);
            PanelBattleArea1.TabIndex = 15;
            // 
            // PanelBattleArea2
            // 
            PanelBattleArea2.Location = new Point(1237, 499);
            PanelBattleArea2.Name = "PanelBattleArea2";
            PanelBattleArea2.Size = new Size(675, 528);
            PanelBattleArea2.TabIndex = 16;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(PanelBattleArea2);
            Controls.Add(PanelBattleArea1);
            Controls.Add(label3);
            Controls.Add(lblPlayer2Value);
            Controls.Add(lblPlayer1Value);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressLifeBar2);
            Controls.Add(progressLifeBar1);
            Controls.Add(btnStartGame);
            Controls.Add(PanelPlayer2);
            Controls.Add(PanelPlayer1);
            Controls.Add(lblPlayer1);
            Controls.Add(lblPlayer2);
            Name = "GameScreen";
            Text = " Game Screen";
            Load += GameScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayer2;
        private Label lblPlayer1;
        private Panel PanelPlayer1;
        private Panel PanelPlayer2;
        private Button btnStartGame;
        private ProgressBar progressLifeBar1;
        private ProgressBar progressLifeBar2;
        private Label label1;
        private Label label2;
        private Label lblPlayer1Value;
        private Label lblPlayer2Value;
        private Label label3;
        private Panel PanelBattleArea1;
        private Panel panel1;
        private Panel PanelBattleArea2;
    }
}