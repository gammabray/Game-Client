namespace Client
{
    partial class LoadGame
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
            this.l_Score = new System.Windows.Forms.Label();
            this.l_Time = new System.Windows.Forms.Label();
            this.pb_levelPreview = new System.Windows.Forms.PictureBox();
            this.l_CompletedValue = new System.Windows.Forms.Label();
            this.b_loadLevel = new System.Windows.Forms.Button();
            this.cb_selectLevel = new System.Windows.Forms.ComboBox();
            this.l_levelSelect = new System.Windows.Forms.Label();
            this.gb_Image = new System.Windows.Forms.GroupBox();
            this.l_bestScoreValue = new System.Windows.Forms.Label();
            this.l_bestTime = new System.Windows.Forms.Label();
            this.l_bestTimeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_levelPreview)).BeginInit();
            this.gb_Image.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_Score
            // 
            this.l_Score.AutoSize = true;
            this.l_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.l_Score.Location = new System.Drawing.Point(453, 388);
            this.l_Score.Name = "l_Score";
            this.l_Score.Size = new System.Drawing.Size(106, 24);
            this.l_Score.TabIndex = 9;
            this.l_Score.Text = "Best Score:";
            // 
            // l_Time
            // 
            this.l_Time.AutoSize = true;
            this.l_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Time.Location = new System.Drawing.Point(857, 388);
            this.l_Time.Name = "l_Time";
            this.l_Time.Size = new System.Drawing.Size(99, 24);
            this.l_Time.TabIndex = 10;
            this.l_Time.Text = "Best Time:";
            // 
            // pb_levelPreview
            // 
            this.pb_levelPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_levelPreview.Location = new System.Drawing.Point(10, 18);
            this.pb_levelPreview.Name = "pb_levelPreview";
            this.pb_levelPreview.Size = new System.Drawing.Size(800, 277);
            this.pb_levelPreview.TabIndex = 12;
            this.pb_levelPreview.TabStop = false;
            // 
            // l_CompletedValue
            // 
            this.l_CompletedValue.AutoSize = true;
            this.l_CompletedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_CompletedValue.Location = new System.Drawing.Point(144, 317);
            this.l_CompletedValue.Name = "l_CompletedValue";
            this.l_CompletedValue.Size = new System.Drawing.Size(0, 20);
            this.l_CompletedValue.TabIndex = 13;
            // 
            // b_loadLevel
            // 
            this.b_loadLevel.Location = new System.Drawing.Point(467, 429);
            this.b_loadLevel.Name = "b_loadLevel";
            this.b_loadLevel.Size = new System.Drawing.Size(75, 23);
            this.b_loadLevel.TabIndex = 16;
            this.b_loadLevel.Text = "Load Level";
            this.b_loadLevel.UseVisualStyleBackColor = true;
            this.b_loadLevel.Click += new System.EventHandler(this.b_loadLevel_Click);
            // 
            // cb_selectLevel
            // 
            this.cb_selectLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_selectLevel.FormattingEnabled = true;
            this.cb_selectLevel.Location = new System.Drawing.Point(242, 57);
            this.cb_selectLevel.Name = "cb_selectLevel";
            this.cb_selectLevel.Size = new System.Drawing.Size(160, 21);
            this.cb_selectLevel.TabIndex = 17;
            this.cb_selectLevel.SelectedIndexChanged += new System.EventHandler(this.cb_selectLevel_SelectedIndexChanged);
            // 
            // l_levelSelect
            // 
            this.l_levelSelect.AutoSize = true;
            this.l_levelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.l_levelSelect.Location = new System.Drawing.Point(62, 54);
            this.l_levelSelect.Name = "l_levelSelect";
            this.l_levelSelect.Size = new System.Drawing.Size(179, 24);
            this.l_levelSelect.TabIndex = 18;
            this.l_levelSelect.Text = "Please Select Level:";
            // 
            // gb_Image
            // 
            this.gb_Image.Controls.Add(this.pb_levelPreview);
            this.gb_Image.Location = new System.Drawing.Point(10, 84);
            this.gb_Image.Name = "gb_Image";
            this.gb_Image.Size = new System.Drawing.Size(821, 301);
            this.gb_Image.TabIndex = 19;
            this.gb_Image.TabStop = false;
            this.gb_Image.Text = "Level Preview";
            // 
            // l_bestScoreValue
            // 
            this.l_bestScoreValue.AutoSize = true;
            this.l_bestScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.l_bestScoreValue.Location = new System.Drawing.Point(565, 388);
            this.l_bestScoreValue.Name = "l_bestScoreValue";
            this.l_bestScoreValue.Size = new System.Drawing.Size(0, 24);
            this.l_bestScoreValue.TabIndex = 20;
            this.l_bestScoreValue.Click += new System.EventHandler(this.l_bestScoreValue_Click);
            // 
            // l_bestTime
            // 
            this.l_bestTime.AutoSize = true;
            this.l_bestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.l_bestTime.Location = new System.Drawing.Point(16, 388);
            this.l_bestTime.Name = "l_bestTime";
            this.l_bestTime.Size = new System.Drawing.Size(99, 24);
            this.l_bestTime.TabIndex = 21;
            this.l_bestTime.Text = "Best Time:";
            // 
            // l_bestTimeValue
            // 
            this.l_bestTimeValue.AutoSize = true;
            this.l_bestTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.l_bestTimeValue.Location = new System.Drawing.Point(121, 388);
            this.l_bestTimeValue.Name = "l_bestTimeValue";
            this.l_bestTimeValue.Size = new System.Drawing.Size(0, 24);
            this.l_bestTimeValue.TabIndex = 22;
            this.l_bestTimeValue.Click += new System.EventHandler(this.l_bestTimeValue_Click);
            // 
            // LoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 464);
            this.Controls.Add(this.l_bestTimeValue);
            this.Controls.Add(this.l_bestTime);
            this.Controls.Add(this.l_bestScoreValue);
            this.Controls.Add(this.gb_Image);
            this.Controls.Add(this.l_levelSelect);
            this.Controls.Add(this.cb_selectLevel);
            this.Controls.Add(this.b_loadLevel);
            this.Controls.Add(this.l_CompletedValue);
            this.Controls.Add(this.l_Time);
            this.Controls.Add(this.l_Score);
            this.Name = "LoadGame";
            this.Text = "Load Game";
            this.Load += new System.EventHandler(this.LoadGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_levelPreview)).EndInit();
            this.gb_Image.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_Score;
        private System.Windows.Forms.Label l_Time;
        private System.Windows.Forms.PictureBox pb_levelPreview;
        private System.Windows.Forms.Label l_CompletedValue;
        private System.Windows.Forms.Button b_loadLevel;
        private System.Windows.Forms.ComboBox cb_selectLevel;
        private System.Windows.Forms.Label l_levelSelect;
        private System.Windows.Forms.GroupBox gb_Image;
        private System.Windows.Forms.Label l_bestScoreValue;
        private System.Windows.Forms.Label l_bestTime;
        private System.Windows.Forms.Label l_bestTimeValue;
    }
}