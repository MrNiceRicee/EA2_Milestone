namespace EA2_Milestone4.Forms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.pn_grid = new System.Windows.Forms.Panel();
            this.btn_clearmarks = new System.Windows.Forms.Button();
            this.lb_gamestatus = new System.Windows.Forms.Label();
            this.btn_mainmenu = new System.Windows.Forms.Button();
            this.lb_GameTime = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pn_grid
            // 
            this.pn_grid.Location = new System.Drawing.Point(13, 62);
            this.pn_grid.Name = "pn_grid";
            this.pn_grid.Size = new System.Drawing.Size(775, 376);
            this.pn_grid.TabIndex = 3;
            // 
            // btn_clearmarks
            // 
            this.btn_clearmarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_clearmarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearmarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_clearmarks.Location = new System.Drawing.Point(465, 9);
            this.btn_clearmarks.Name = "btn_clearmarks";
            this.btn_clearmarks.Size = new System.Drawing.Size(150, 50);
            this.btn_clearmarks.TabIndex = 4;
            this.btn_clearmarks.Text = "Clear Mark Up";
            this.btn_clearmarks.UseVisualStyleBackColor = false;
            this.btn_clearmarks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_clear);
            // 
            // lb_gamestatus
            // 
            this.lb_gamestatus.AutoSize = true;
            this.lb_gamestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gamestatus.Location = new System.Drawing.Point(168, 9);
            this.lb_gamestatus.Name = "lb_gamestatus";
            this.lb_gamestatus.Size = new System.Drawing.Size(164, 20);
            this.lb_gamestatus.TabIndex = 5;
            this.lb_gamestatus.Text = "Game is not over yet";
            // 
            // btn_mainmenu
            // 
            this.btn_mainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_mainmenu.Location = new System.Drawing.Point(12, 9);
            this.btn_mainmenu.Name = "btn_mainmenu";
            this.btn_mainmenu.Size = new System.Drawing.Size(150, 50);
            this.btn_mainmenu.TabIndex = 7;
            this.btn_mainmenu.Text = "Back";
            this.btn_mainmenu.UseVisualStyleBackColor = false;
            this.btn_mainmenu.Click += new System.EventHandler(this.btn_back);
            // 
            // lb_GameTime
            // 
            this.lb_GameTime.AutoSize = true;
            this.lb_GameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GameTime.Location = new System.Drawing.Point(168, 39);
            this.lb_GameTime.Name = "lb_GameTime";
            this.lb_GameTime.Size = new System.Drawing.Size(106, 20);
            this.lb_GameTime.TabIndex = 8;
            this.lb_GameTime.Text = "Game Time: ";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.TickerCheck);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_GameTime);
            this.Controls.Add(this.btn_mainmenu);
            this.Controls.Add(this.lb_gamestatus);
            this.Controls.Add(this.btn_clearmarks);
            this.Controls.Add(this.pn_grid);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "GameForm";
            this.Text = "Minesweeper";
            this.ResizeEnd += new System.EventHandler(this.Resized);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_grid;
        private System.Windows.Forms.Button btn_clearmarks;
        private System.Windows.Forms.Label lb_gamestatus;
        private System.Windows.Forms.Button btn_mainmenu;
        private System.Windows.Forms.Label lb_GameTime;
        private System.Windows.Forms.Timer GameTimer;
    }
}