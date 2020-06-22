namespace EA2_Milestone4
{
    partial class Form1
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
            this.lb_modes = new System.Windows.Forms.Label();
            this.radb_Easy = new System.Windows.Forms.RadioButton();
            this.radb_Medium = new System.Windows.Forms.RadioButton();
            this.tb_Tiles = new System.Windows.Forms.TextBox();
            this.radb_Hard = new System.Windows.Forms.RadioButton();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_Highscores = new System.Windows.Forms.Label();
            this.lb_Rank = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Points = new System.Windows.Forms.Label();
            this.pn_ScoreList = new System.Windows.Forms.Panel();
            this.lb_Difficulty = new System.Windows.Forms.Label();
            this.pn_Hints = new System.Windows.Forms.Panel();
            this.lb_HintGameSize = new System.Windows.Forms.Label();
            this.lb_HintTime = new System.Windows.Forms.Label();
            this.lb_HintPoints = new System.Windows.Forms.Label();
            this.lb_HintDifficulty = new System.Windows.Forms.Label();
            this.lb_HintName = new System.Windows.Forms.Label();
            this.pn_Menu.SuspendLayout();
            this.pn_Hints.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_modes
            // 
            this.lb_modes.AutoSize = true;
            this.lb_modes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_modes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modes.Location = new System.Drawing.Point(3, 1);
            this.lb_modes.Name = "lb_modes";
            this.lb_modes.Size = new System.Drawing.Size(176, 26);
            this.lb_modes.TabIndex = 0;
            this.lb_modes.Text = "Select a difficulty";
            // 
            // radb_Easy
            // 
            this.radb_Easy.AutoSize = true;
            this.radb_Easy.FlatAppearance.BorderSize = 0;
            this.radb_Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Easy.Location = new System.Drawing.Point(7, 27);
            this.radb_Easy.Name = "radb_Easy";
            this.radb_Easy.Size = new System.Drawing.Size(67, 24);
            this.radb_Easy.TabIndex = 1;
            this.radb_Easy.TabStop = true;
            this.radb_Easy.Text = "Easy";
            this.radb_Easy.UseVisualStyleBackColor = true;
            // 
            // radb_Medium
            // 
            this.radb_Medium.AutoSize = true;
            this.radb_Medium.FlatAppearance.BorderSize = 0;
            this.radb_Medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Medium.Location = new System.Drawing.Point(7, 54);
            this.radb_Medium.Name = "radb_Medium";
            this.radb_Medium.Size = new System.Drawing.Size(89, 24);
            this.radb_Medium.TabIndex = 2;
            this.radb_Medium.TabStop = true;
            this.radb_Medium.Text = "Medium";
            this.radb_Medium.UseVisualStyleBackColor = true;
            // 
            // tb_Tiles
            // 
            this.tb_Tiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_Tiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Tiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tiles.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Tiles.Location = new System.Drawing.Point(0, 108);
            this.tb_Tiles.Name = "tb_Tiles";
            this.tb_Tiles.Size = new System.Drawing.Size(286, 19);
            this.tb_Tiles.TabIndex = 0;
            this.tb_Tiles.Text = "Tile size: Default. Enter for custom";
            this.tb_Tiles.Enter += new System.EventHandler(this.TileAmount_Enter);
            this.tb_Tiles.Leave += new System.EventHandler(this.TileAmount_Leave);
            // 
            // radb_Hard
            // 
            this.radb_Hard.AutoSize = true;
            this.radb_Hard.FlatAppearance.BorderSize = 0;
            this.radb_Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Hard.Location = new System.Drawing.Point(7, 81);
            this.radb_Hard.Name = "radb_Hard";
            this.radb_Hard.Size = new System.Drawing.Size(67, 24);
            this.radb_Hard.TabIndex = 4;
            this.radb_Hard.TabStop = true;
            this.radb_Hard.Text = "Hard";
            this.radb_Hard.UseVisualStyleBackColor = true;
            // 
            // pn_Menu
            // 
            this.pn_Menu.Controls.Add(this.btn_Start);
            this.pn_Menu.Controls.Add(this.lb_modes);
            this.pn_Menu.Controls.Add(this.tb_Tiles);
            this.pn_Menu.Controls.Add(this.radb_Easy);
            this.pn_Menu.Controls.Add(this.radb_Hard);
            this.pn_Menu.Controls.Add(this.radb_Medium);
            this.pn_Menu.Location = new System.Drawing.Point(12, 12);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(289, 183);
            this.pn_Menu.TabIndex = 5;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Location = new System.Drawing.Point(0, 140);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(286, 40);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // lb_Highscores
            // 
            this.lb_Highscores.AutoSize = true;
            this.lb_Highscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Highscores.Location = new System.Drawing.Point(310, 12);
            this.lb_Highscores.Name = "lb_Highscores";
            this.lb_Highscores.Size = new System.Drawing.Size(119, 25);
            this.lb_Highscores.TabIndex = 7;
            this.lb_Highscores.Text = "High Scores";
            // 
            // lb_Rank
            // 
            this.lb_Rank.AutoSize = true;
            this.lb_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rank.Location = new System.Drawing.Point(307, 43);
            this.lb_Rank.Name = "lb_Rank";
            this.lb_Rank.Size = new System.Drawing.Size(47, 20);
            this.lb_Rank.TabIndex = 8;
            this.lb_Rank.Text = "Rank";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(376, 43);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(53, 20);
            this.lb_Name.TabIndex = 9;
            this.lb_Name.Text = "Name";
            // 
            // lb_Points
            // 
            this.lb_Points.AutoSize = true;
            this.lb_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Points.Location = new System.Drawing.Point(578, 43);
            this.lb_Points.Name = "lb_Points";
            this.lb_Points.Size = new System.Drawing.Size(56, 20);
            this.lb_Points.TabIndex = 10;
            this.lb_Points.Text = "Points";
            // 
            // pn_ScoreList
            // 
            this.pn_ScoreList.Location = new System.Drawing.Point(307, 66);
            this.pn_ScoreList.Name = "pn_ScoreList";
            this.pn_ScoreList.Size = new System.Drawing.Size(345, 129);
            this.pn_ScoreList.TabIndex = 11;
            // 
            // lb_Difficulty
            // 
            this.lb_Difficulty.AutoSize = true;
            this.lb_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Difficulty.Location = new System.Drawing.Point(465, 43);
            this.lb_Difficulty.Name = "lb_Difficulty";
            this.lb_Difficulty.Size = new System.Drawing.Size(75, 20);
            this.lb_Difficulty.TabIndex = 12;
            this.lb_Difficulty.Text = "Difficulty";
            // 
            // pn_Hints
            // 
            this.pn_Hints.Controls.Add(this.lb_HintGameSize);
            this.pn_Hints.Controls.Add(this.lb_HintTime);
            this.pn_Hints.Controls.Add(this.lb_HintPoints);
            this.pn_Hints.Controls.Add(this.lb_HintDifficulty);
            this.pn_Hints.Controls.Add(this.lb_HintName);
            this.pn_Hints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Hints.Location = new System.Drawing.Point(658, 66);
            this.pn_Hints.Name = "pn_Hints";
            this.pn_Hints.Size = new System.Drawing.Size(200, 129);
            this.pn_Hints.TabIndex = 13;
            this.pn_Hints.Visible = false;
            // 
            // lb_HintGameSize
            // 
            this.lb_HintGameSize.AutoSize = true;
            this.lb_HintGameSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HintGameSize.Location = new System.Drawing.Point(3, 106);
            this.lb_HintGameSize.Name = "lb_HintGameSize";
            this.lb_HintGameSize.Size = new System.Drawing.Size(77, 17);
            this.lb_HintGameSize.TabIndex = 16;
            this.lb_HintGameSize.Text = "Game Size";
            // 
            // lb_HintTime
            // 
            this.lb_HintTime.AutoSize = true;
            this.lb_HintTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HintTime.Location = new System.Drawing.Point(3, 82);
            this.lb_HintTime.Name = "lb_HintTime";
            this.lb_HintTime.Size = new System.Drawing.Size(39, 17);
            this.lb_HintTime.TabIndex = 15;
            this.lb_HintTime.Text = "Time";
            // 
            // lb_HintPoints
            // 
            this.lb_HintPoints.AutoSize = true;
            this.lb_HintPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HintPoints.Location = new System.Drawing.Point(3, 56);
            this.lb_HintPoints.Name = "lb_HintPoints";
            this.lb_HintPoints.Size = new System.Drawing.Size(47, 17);
            this.lb_HintPoints.TabIndex = 14;
            this.lb_HintPoints.Text = "Points";
            // 
            // lb_HintDifficulty
            // 
            this.lb_HintDifficulty.AutoSize = true;
            this.lb_HintDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HintDifficulty.Location = new System.Drawing.Point(3, 30);
            this.lb_HintDifficulty.Name = "lb_HintDifficulty";
            this.lb_HintDifficulty.Size = new System.Drawing.Size(61, 17);
            this.lb_HintDifficulty.TabIndex = 14;
            this.lb_HintDifficulty.Text = "Difficulty";
            // 
            // lb_HintName
            // 
            this.lb_HintName.AutoSize = true;
            this.lb_HintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HintName.Location = new System.Drawing.Point(3, 4);
            this.lb_HintName.Name = "lb_HintName";
            this.lb_HintName.Size = new System.Drawing.Size(89, 17);
            this.lb_HintName.TabIndex = 14;
            this.lb_HintName.Text = "lb_HintName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(868, 203);
            this.Controls.Add(this.pn_Hints);
            this.Controls.Add(this.lb_Difficulty);
            this.Controls.Add(this.lb_Points);
            this.Controls.Add(this.lb_Rank);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pn_ScoreList);
            this.Controls.Add(this.lb_Highscores);
            this.Controls.Add(this.pn_Menu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Activated += new System.EventHandler(this.UpdateUI);
            this.Enter += new System.EventHandler(this.UpdateUI);
            this.Leave += new System.EventHandler(this.UpdateUI);
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            this.pn_Hints.ResumeLayout(false);
            this.pn_Hints.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_modes;
        private System.Windows.Forms.RadioButton radb_Easy;
        private System.Windows.Forms.RadioButton radb_Medium;
        private System.Windows.Forms.TextBox tb_Tiles;
        private System.Windows.Forms.RadioButton radb_Hard;
        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_Highscores;
        private System.Windows.Forms.Label lb_Rank;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Points;
        private System.Windows.Forms.Panel pn_ScoreList;
        private System.Windows.Forms.Label lb_Difficulty;
        private System.Windows.Forms.Panel pn_Hints;
        private System.Windows.Forms.Label lb_HintGameSize;
        private System.Windows.Forms.Label lb_HintTime;
        private System.Windows.Forms.Label lb_HintPoints;
        private System.Windows.Forms.Label lb_HintDifficulty;
        private System.Windows.Forms.Label lb_HintName;
    }
}

