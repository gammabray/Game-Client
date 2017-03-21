namespace Client
{
    partial class High_Scores
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
            this.b_loadHighScores = new System.Windows.Forms.Button();
            this.highScoresTable = new System.Windows.Forms.DataGridView();
            this.t_SearchUser = new System.Windows.Forms.TextBox();
            this.l_Search = new System.Windows.Forms.Label();
            this.b_MainMenu = new System.Windows.Forms.Button();
            this.b_Find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.highScoresTable)).BeginInit();
            this.SuspendLayout();
            // 
            // b_loadHighScores
            // 
            this.b_loadHighScores.Location = new System.Drawing.Point(39, 274);
            this.b_loadHighScores.Name = "b_loadHighScores";
            this.b_loadHighScores.Size = new System.Drawing.Size(135, 35);
            this.b_loadHighScores.TabIndex = 0;
            this.b_loadHighScores.Text = "Load All High Scores";
            this.b_loadHighScores.UseVisualStyleBackColor = true;
            this.b_loadHighScores.Click += new System.EventHandler(this.b_loadHighScores_Click);
            // 
            // highScoresTable
            // 
            this.highScoresTable.AllowUserToAddRows = false;
            this.highScoresTable.AllowUserToDeleteRows = false;
            this.highScoresTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.highScoresTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.highScoresTable.Location = new System.Drawing.Point(53, 35);
            this.highScoresTable.Name = "highScoresTable";
            this.highScoresTable.ReadOnly = true;
            this.highScoresTable.Size = new System.Drawing.Size(507, 233);
            this.highScoresTable.TabIndex = 1;
            // 
            // t_SearchUser
            // 
            this.t_SearchUser.Location = new System.Drawing.Point(460, 12);
            this.t_SearchUser.Name = "t_SearchUser";
            this.t_SearchUser.Size = new System.Drawing.Size(100, 20);
            this.t_SearchUser.TabIndex = 2;
            // 
            // l_Search
            // 
            this.l_Search.AutoSize = true;
            this.l_Search.Location = new System.Drawing.Point(410, 15);
            this.l_Search.Name = "l_Search";
            this.l_Search.Size = new System.Drawing.Size(44, 13);
            this.l_Search.TabIndex = 3;
            this.l_Search.Text = "Search:";
            // 
            // b_MainMenu
            // 
            this.b_MainMenu.Location = new System.Drawing.Point(425, 274);
            this.b_MainMenu.Name = "b_MainMenu";
            this.b_MainMenu.Size = new System.Drawing.Size(135, 35);
            this.b_MainMenu.TabIndex = 4;
            this.b_MainMenu.Text = "Back to Main Menu";
            this.b_MainMenu.UseVisualStyleBackColor = true;
            // 
            // b_Find
            // 
            this.b_Find.Location = new System.Drawing.Point(566, 12);
            this.b_Find.Name = "b_Find";
            this.b_Find.Size = new System.Drawing.Size(48, 20);
            this.b_Find.TabIndex = 5;
            this.b_Find.Text = "Find";
            this.b_Find.UseVisualStyleBackColor = true;
            this.b_Find.Click += new System.EventHandler(this.b_Find_Click);
            // 
            // High_Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 321);
            this.Controls.Add(this.b_Find);
            this.Controls.Add(this.b_MainMenu);
            this.Controls.Add(this.l_Search);
            this.Controls.Add(this.t_SearchUser);
            this.Controls.Add(this.highScoresTable);
            this.Controls.Add(this.b_loadHighScores);
            this.Name = "High_Scores";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.High_Scores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.highScoresTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_loadHighScores;
        private System.Windows.Forms.DataGridView highScoresTable;
        private System.Windows.Forms.TextBox t_SearchUser;
        private System.Windows.Forms.Label l_Search;
        private System.Windows.Forms.Button b_MainMenu;
        private System.Windows.Forms.Button b_Find;
    }
}