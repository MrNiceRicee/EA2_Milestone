using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using EA2_Milestone4.Classes;
using EA2_Milestone4.Forms;

namespace EA2_Milestone4
{
    public partial class Form1 : Form
    {


        /* I have comments on the game form as well. I am not entirely happy at the code.
         * It works but it doesn't look clean and kind of looks like its all over the place
         * 
         * 
         * 
         */

        public int win { get; set; }
        public int loss { get; set; }

        private FileAccessSystem FAM = new FileAccessSystem();

        internal List<PlayerStats> PlayerList = new List<PlayerStats>();
        public Form1()
        {
            win = 0;
            loss = 0;

            //load the initial list
            Console.WriteLine("SaveFile: "+FAM.getSaveFile());
            FAM.savePlayerList(PlayerList);
            foreach (var item in FAM.getScoreCards())
            {
                if (item!=null)
                {
                    Console.WriteLine(item.Name + " . " + item.Score);
                }
            }

            InitializeComponent();
            updateScoreList();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            //got to do some perliminary checks. 
            if (radb_Easy.Checked || radb_Medium.Checked || radb_Hard.Checked)
            {
                //check if user actually selected a difficulty
                //get difficulty.
                if (tb_Tiles.Text.Equals("Tile Default: 10. Min: 5. Max 20"))
                {
                    //go to default
                    btn_Start.Text = "Starting "+ getActive().Text + " 10 tile game";

                    //start game here
                    //check if ANY other gameforms have been activated. If it is close it.
                    if (Application.OpenForms.OfType<GameForm>().Count() >= 1)
                    {
                        Application.OpenForms.OfType<GameForm>().First().Close();
                    }
                    GameForm newGame = new GameForm(10, getActive().Text);
                    newGame.Show();
                    this.Hide();
                }
                else
                {
                    //anything but the hint. Time to see if its a real number.
                    if (int.TryParse(tb_Tiles.Text, out int amount))
                    {
                        if (amount < 5)
                        {
                            btn_Start.Text = "Please enter a number higher than 5";
                        } else if (amount > 20)
                        {
                            btn_Start.Text = "Please enter a number lower than 20";

                        } else
                        {
                            //go with custom number
                            generateGame(amount);
                        }
                    }
                    else if (tb_Tiles.Text.Equals("Tile size: Default. Enter for custom")) 
                    {
                        generateGame(-1);
                    }
                    else
                    {
                        btn_Start.Text = "Please enter a number.";
                    }
                }
            }
            else
            {
                btn_Start.Text = "Please select difficulty.";
            }
        }


        private void generateGame(int amount)
        {
            btn_Start.Text = "Start";
            //start game here
            if (Application.OpenForms.OfType<GameForm>().Count() >= 1)
            {
                Application.OpenForms.OfType<GameForm>().First().Close();
            }
            GameForm newGame = new GameForm(amount, getActive().Text);
            newGame.Show();
            this.Hide();
        }

        //DataGrid
        //update the current top 5 scores
        private void updateScoreList()
        {
            PlayerList.Clear();
            PlayerList.AddRange(FAM.getScoreCards());

            //remove old controls
            var old = this.pn_ScoreList.Controls.OfType<Label>();
            foreach (var item in old)
            {
                this.pn_ScoreList.Controls.Remove(item);
            }

            PlayerList.Sort((a,b)=> b.Score.CompareTo(a.Score));
            //add new top 5 score
            int counter = 0;
            foreach (var student in PlayerList.Take(5))
            {
                
                Label rank = new Label() { Text = (counter + 1) + ".", AutoSize = true, Location = new Point(5, 4 + (counter * 20)), Tag = student };
                Label name = new Label() { Text = student.Name, AutoSize = true, Location = new Point(55, 4 + (counter * 20)), Tag = student };
                Label difficulty = new Label() { Text = student.Difficulty, AutoSize = true, Location = new Point(130, +4 + (counter * 20)), Tag = student };
                Label score = new Label() { Text = String.Format("{0:n0}", student.Score), AutoSize = true, Location = new Point(200, 4 + (counter * 20)), Tag = student };

                rank.MouseHover += ScoreEnterHover;
                name.MouseHover += ScoreEnterHover;
                difficulty.MouseHover += ScoreEnterHover;
                score.MouseHover += ScoreEnterHover;

                rank.MouseLeave += ScoreLeaveHover;
                name.MouseLeave += ScoreLeaveHover;
                difficulty.MouseLeave += ScoreLeaveHover;
                score.MouseLeave += ScoreLeaveHover;

                pn_ScoreList.Controls.Add(rank);
                pn_ScoreList.Controls.Add(name);
                pn_ScoreList.Controls.Add(difficulty);
                pn_ScoreList.Controls.Add(score);
                counter++;
            }
        }

        private RadioButton getActive()
        {
            if (radb_Easy.Checked)
            {
                return radb_Easy;
            }else if (radb_Medium.Checked)
            {
                return radb_Medium;
            }else
            {
                return radb_Hard;
            }
        }

        //Because visual studio doesn't support hint on textbox, decided to add one
        private void TileAmount_Enter(object sender, EventArgs e)
        {
            if (tb_Tiles.Text.Equals("Tile size: Default. Enter for custom"))
            {
                tb_Tiles.Text = "";

                tb_Tiles.ForeColor = Color.Gainsboro;
            }
        }

        private void TileAmount_Leave(object sender, EventArgs e)
        {
            if (tb_Tiles.Text.Equals(""))
            {
                tb_Tiles.Text = "Tile size: Default. Enter for custom";

                tb_Tiles.ForeColor = Color.DimGray;
            }
        }

        private void UpdateUI(object sender, EventArgs e)
        {
            updateScoreList();
            updateScoreList();
        }

        //reveal score
        private void ScoreEnterHover(object sender, EventArgs e)
        {
            Label sus = (Label)sender;
            this.pn_Hints.Visible = true;
            if (sus.Tag!=null)
            {
                this.lb_HintName.Text = "Name: "+(sus.Tag as PlayerStats).Name;
                this.lb_HintDifficulty.Text = "Difficulty: " + (sus.Tag as PlayerStats).Difficulty;
                this.lb_HintPoints.Text = "Score: " + String.Format("{0:n0}", (sus.Tag as PlayerStats).Score);
                this.lb_HintTime.Text = "Time: " + (sus.Tag as PlayerStats).TimeFinish.ToString("mm\\:ss\\.ff");
                this.lb_HintGameSize.Text = "Game Size: " + (sus.Tag as PlayerStats).GameSize;

            }
        }
        private void ScoreLeaveHover(object sender, EventArgs e)
        {
            this.pn_Hints.Visible = false;
        }
    }
}
