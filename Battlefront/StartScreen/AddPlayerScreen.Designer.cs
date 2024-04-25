
namespace GameUI
{
    partial class AddPlayerScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayerScreen));
            btnSubmitPlayer = new Button();
            txtPlayerName = new TextBox();
            label3 = new Label();
            txtPlayerID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubmitPlayer
            // 
            btnSubmitPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitPlayer.Location = new Point(298, 328);
            btnSubmitPlayer.Name = "btnSubmitPlayer";
            btnSubmitPlayer.Size = new Size(148, 74);
            btnSubmitPlayer.TabIndex = 11;
            btnSubmitPlayer.Text = "Submit";
            btnSubmitPlayer.UseVisualStyleBackColor = true;
            btnSubmitPlayer.Click += btnSubmitPlayer_Click;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(210, 259);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(377, 27);
            txtPlayerName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(213, 218);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 9;
            label3.Text = "Player Name";
            // 
            // txtPlayerID
            // 
            txtPlayerID.Enabled = false;
            txtPlayerID.Location = new Point(213, 158);
            txtPlayerID.Name = "txtPlayerID";
            txtPlayerID.Size = new Size(377, 27);
            txtPlayerID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 117);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 7;
            label2.Text = "Player ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19F, FontStyle.Bold);
            label1.Location = new Point(227, 49);
            label1.Name = "label1";
            label1.Size = new Size(219, 40);
            label1.TabIndex = 6;
            label1.Text = "Add Player";
            // 
            // AddPlayerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmitPlayer);
            Controls.Add(txtPlayerName);
            Controls.Add(label3);
            Controls.Add(txtPlayerID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPlayerScreen";
            Text = "AddPlayerForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnSubmitPlayer;
        private TextBox txtPlayerName;
        private Label label3;
        private TextBox txtPlayerID;
        private Label label2;
        private Label label1;
    }
}