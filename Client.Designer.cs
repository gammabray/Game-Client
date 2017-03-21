namespace Client
{
    partial class Client
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
            this.l_gameTitle = new System.Windows.Forms.Label();
            this.b_highScores = new System.Windows.Forms.Button();
            this.b_loadGame = new System.Windows.Forms.Button();
            this.b_newGame = new System.Windows.Forms.Button();
            this.b_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_gameTitle
            // 
            this.l_gameTitle.AutoSize = true;
            this.l_gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.l_gameTitle.Location = new System.Drawing.Point(284, 9);
            this.l_gameTitle.Name = "l_gameTitle";
            this.l_gameTitle.Size = new System.Drawing.Size(58, 13);
            this.l_gameTitle.TabIndex = 0;
            this.l_gameTitle.Text = "Game Title";
            this.l_gameTitle.Click += new System.EventHandler(this.l_gameTitle_Click);
            // 
            // b_highScores
            // 
            this.b_highScores.Location = new System.Drawing.Point(228, 215);
            this.b_highScores.Name = "b_highScores";
            this.b_highScores.Size = new System.Drawing.Size(170, 62);
            this.b_highScores.TabIndex = 3;
            this.b_highScores.Text = "High Scores";
            this.b_highScores.UseVisualStyleBackColor = true;
            this.b_highScores.Click += new System.EventHandler(this.b_highscores_Click);
            // 
            // b_loadGame
            // 
            this.b_loadGame.Location = new System.Drawing.Point(228, 124);
            this.b_loadGame.Name = "b_loadGame";
            this.b_loadGame.Size = new System.Drawing.Size(170, 62);
            this.b_loadGame.TabIndex = 4;
            this.b_loadGame.Text = "Load Game";
            this.b_loadGame.UseVisualStyleBackColor = true;
            this.b_loadGame.Click += new System.EventHandler(this.b_loadGame_Click);
            // 
            // b_newGame
            // 
            this.b_newGame.Location = new System.Drawing.Point(228, 38);
            this.b_newGame.Name = "b_newGame";
            this.b_newGame.Size = new System.Drawing.Size(170, 62);
            this.b_newGame.TabIndex = 5;
            this.b_newGame.Text = "New Game";
            this.b_newGame.UseVisualStyleBackColor = true;
            this.b_newGame.Click += new System.EventHandler(this.b_newGame_Click);
            // 
            // b_Exit
            // 
            this.b_Exit.Location = new System.Drawing.Point(228, 311);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(170, 62);
            this.b_Exit.TabIndex = 6;
            this.b_Exit.Text = "Exit";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.b_Exit);
            this.Controls.Add(this.b_newGame);
            this.Controls.Add(this.b_loadGame);
            this.Controls.Add(this.b_highScores);
            this.Controls.Add(this.l_gameTitle);
            this.Name = "Client";
            this.Text = "Game Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_gameTitle;
        private System.Windows.Forms.Button b_highScores;
        private System.Windows.Forms.Button b_loadGame;
        private System.Windows.Forms.Button b_newGame;
        private System.Windows.Forms.Button b_Exit;
    }
}

