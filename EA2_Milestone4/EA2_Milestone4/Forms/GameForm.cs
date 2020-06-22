using EA2_Milestone4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA2_Milestone4.Forms
{
    public partial class GameForm : Form
    {
        Board newGame = new Board();
        int size = 0;
        Stopwatch sw = new Stopwatch();
        CustomDialog cusd = new CustomDialog();
        String endtime = "";
        int maxTime = -1;   //this will be based on score
        double diff = 0.1;  //used to determine score and also tiles
        string gamediff = "";


        /* Set up the gameend to see if game actually ended. Just in case for premature closure of the form.
         * if game actually ended, there are only two routes, game won or game lost.
         * Added a "set mark" to the project
         * 
         * If player closes the form, it opens up the main menu. Could have done the same thing with a back button but oh well
         * 
         * Based mines and sizes on the pre-programmed modes of windows minesweeper after a quick google search
         */

        bool gameend = false;
        FileAccessSystem FAM = new FileAccessSystem();


        bool win = false;

        //game is created
        public GameForm(int Tiles, String difficulty)
        {
            InitializeComponent();
            //made a realization that most minesweeper games dont really have CRAZY amounts of mines. So just settled with a minimum of 10% and maximum of 20%
            if (difficulty.Equals("Easy"))
            {
                diff = 0.12;
                size = 9;
                maxTime = 20;
                gamediff = "Easy";
            }
            else if (difficulty.Equals("Medium"))
            {
                diff = 0.15;
                size = 12;
                maxTime = 75;
                gamediff = "Medium";
            }
            else if (difficulty.Equals("Hard"))
            {
                diff = 0.20;
                size = 16;
                maxTime = 170;
                gamediff = "Hard";
            }
            if (Tiles > 0)
            {
                size = Tiles;
            }
            newGame = new Board() { Size = size, Grid = new Cell[size, size], Difficulty = diff };
            newGame.setupLiveNeighbors(newGame.Grid);
            generateGrid();
            Console.WriteLine("Live: " + newGame.getCells().Where(x => x.Live == true).Count());

            this.FormClosed += closeForm;
        }    

        //initiate the grid
        private void generateGrid()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    MyButton newBCell = new MyButton() { Size = new Size(50, 50), Location = new Point(x * 50, y * 50), BackColor = Color.FromArgb(210,210,210), ForeColor = Color.White,
                                        Tag = x+","+y, ButtonCell = GetCell(x,y) };
                    newBCell.MouseDown += btn_click;
                    this.pn_grid.Controls.Add(newBCell);
                }
            }
            //alter size of mainform
            this.pn_grid.Size = new Size(size * 50, size * 50);
            this.Size = new Size((size * 50) + 40, (size * 50) + 100);
            Console.WriteLine(this.Size.ToString());
            //make sure buttons are visible
            if (this.Size.Width < 499)
            {
                this.Size = new Size(500, (size*50)+100);
                this.pn_grid.Location = new Point((this.Size.Width/2)-(this.pn_grid.Size.Width/2)-15,50);
            }
        }

        //some methods

        private void checkGame(int condition)
        {
            var biggrid = this.pn_grid.Controls.OfType<MyButton>().ToList();      //put everything on a list
            foreach (var button in biggrid)
            {
                if (condition == 0)
                {
                    //partial clear
                    if (button.ButtonCell.Visited)
                    {
                        revealButton(button);
                    }
                }
                else
                {
                    //full clear
                    revealButton(button);
                }
            }
        }
        private void revealButton(MyButton button)
        {
            if (button.ButtonCell.Live)
            {
                button.BackColor = Color.Red;
                if (button.BackgroundImage!=null) { button.BackColor = Color.FromArgb(65, 10, 10); }
                if (button.ButtonCell.Visited) { button.BackColor = Color.FromArgb(150, 50, 50); }
                button.BackgroundImage = new Bitmap(FAM.getLibrary("\\Icons\\Bomb.png"));
                button.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                button.BackColor = Color.FromArgb(50, 50, 50);
                if (gameend&&!button.ButtonCell.Visited) { button.BackColor = Color.FromArgb(10, 10, 10); }
                button.Text = newGame.checkNeighbor(button.ButtonCell, 1).ToString();
                button.BackgroundImage = null;
                //button.Enabled = false;
            }
        }

        //just got lazy
        private Cell GetCell(int x, int y)
        {
            return newGame.Grid[x, y];
        }

        //get player score
        private void getPlayerScore(string name, int time, TimeSpan ts)
        {
            int panelscore = size * size * 100;
            if (time > maxTime * 1000)
            {
                //time is longer than the highest alloted time
                PlayerStats newscore = new PlayerStats(name, maxTime * 1000 + panelscore) {TimeFinish = ts, Difficulty = gamediff, GameSize = size };
                FAM.savePlayerScore(newscore);
                Console.WriteLine(maxTime*1000+ panelscore + " default score");
            }
            else
            {
                //time is within the alloted time 
                int score = (maxTime * 1000) + ((maxTime * 1000) - time) + panelscore;
                PlayerStats newscore = new PlayerStats(name, score) { TimeFinish = ts, Difficulty = gamediff, GameSize = size };
                FAM.savePlayerScore(newscore);
                Console.WriteLine(score+ " win score");
            }
        }


        //get time
        private String getTime()
        {
            string r = "";
            if (sw.ElapsedMilliseconds < 60000)
            {
                //show only second and mili
                r = sw.Elapsed.ToString("ss\\.ff");
            }
            else if (sw.ElapsedMilliseconds > 60000 && sw.ElapsedMilliseconds < 3600000)
            {
                //show min, second and mili
                r = sw.Elapsed.ToString("mm\\:ss\\.ff");
            }
            else if (sw.ElapsedMilliseconds > 3600000 && sw.ElapsedMilliseconds < 86400000)
            {
                //show hour, second and mili
                r = sw.Elapsed.ToString("hh\\:mm\\:ss");
            }
            else if (sw.ElapsedMilliseconds > 86400000)
            {
                //show day, hour, second and mili
                r = sw.Elapsed.ToString("dd hh\\:mm\\:ss");
            }
            return r;
        }


        //listeners

        private void btn_click(object sender, MouseEventArgs e)
        {
            MyButton sus = (MyButton)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (sus.ButtonCell.Visited)
                {
                    //do nothing
                }
                else
                {
                    sus.ButtonCell.Visited = true;
                    sus.ButtonCell.LiveNeighbors = newGame.checkNeighbor(sus.ButtonCell, 1);
                    if (!sus.ButtonCell.Live)
                    {
                        newGame.revealNearbyZero(sus.ButtonCell); //revealnearbyzero = floodfill()

                        // Console.WriteLine("This button is "+ newGame.Grid[x,y].Live);
                        checkGame(0);

                        if (newGame.getCells().Where(ce => ce.Visited).Count() == newGame.getCells().Where(ce => !ce.Live).Count())
                        {
                            sw.Stop();
                            lb_gamestatus.Text = "You won!";
                            sus.Text = "You won!";
                            gameend = true;
                            win = true;
                            endtime = getTime();
                            TimeSpan timeSpan = sw.Elapsed;
                            checkGame(1);

                            int gametime = (int)sw.ElapsedMilliseconds;
                            string playername = cusd.showStringDialog("You won! Type your name to enter score","Time: "+ endtime, "Game Status");
                            //game win
                            if (playername.Length > 0)
                            {
                                getPlayerScore(playername, gametime,timeSpan);
                                Console.WriteLine(gametime+" gametime");
                            }
                        }
                    }
                    else
                    {
                        //player clicked on a bomb

                        sw.Stop();

                        gameend = true;
                        win = false;
                        lb_gamestatus.Text = "You Lost!";
                        endtime = getTime();
                        checkGame(1);

                        //string promptd = cusd.showStringDialog("HEY HEY,", "YOU YOU");
                        bool promptd = cusd.showConfirmDialog("Game Lost! Time: "+ endtime, "Game Status");
                    }

                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //put in a soft mark
                if (!sus.ButtonCell.Visited)
                {
                    if (sus.BackgroundImage==null)
                    {
                        sus.BackColor = Color.FromArgb(65, 10, 10);
                        sus.BackgroundImage = new Bitmap(FAM.getLibrary("\\Icons\\Flag.png"));
                        sus.BackgroundImageLayout = ImageLayout.Center;
                    }
                    else{
                        sus.BackgroundImage = null;
                        sus.BackColor = Color.FromArgb(210, 210, 210);
                    }

                }
            }
            if (!sw.IsRunning)
            {
                sw.Start();
            }
        }

        //clear flags
        private void btn_clear(object sender, MouseEventArgs e)
        {
            var btns = this.pn_grid.Controls.OfType<MyButton>().ToList();
            foreach (var button in btns)
            {
                if (!button.ButtonCell.Visited)
                {
                    button.BackColor = Color.FromArgb(210, 210, 210);
                    button.BackgroundImage = null;
                }
            }
        }

        //go back to main menu
        private void btn_back(object sender, EventArgs e)
        {
            var parentform = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (gameend)
            {
                if (win)
                {
                    parentform.win++;
                }
                else
                {
                    parentform.loss++;
                }
            }
            parentform.Show();
            this.Close();
        }

        //if the form is closed
        private void closeForm(object sender, FormClosedEventArgs e)
        {
            var parentform = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (gameend)
            {
                if (win)
                {
                    parentform.win++;
                }
                else
                {
                    parentform.loss++;
                }
            }
            parentform.Show();
        }

        private void TickerCheck(object sender, EventArgs e)
        {
            if (sw.IsRunning&&!gameend)
            {
                lb_GameTime.Text = getTime();
            }
            else if (gameend)
            {
                lb_GameTime.Text = endtime;
                sw.Stop();
            }
        }

        private void Resized(object sender, EventArgs e)
        {
            Console.WriteLine("Form size: "+this.Size);
            if (this.Size.Width < 499)
            {
                this.Size = new Size(500, (size * 50) + 100);
                this.pn_grid.Location = new Point((this.Size.Width / 2) - (this.pn_grid.Size.Width / 2) - 15, 50);
            }
            this.pn_grid.Size = new Size(this.Size.Width - 50, this.Size.Height - 120); ;
            this.pn_grid.Location = new Point((this.Size.Width / 2) - (this.pn_grid.Size.Width / 2) - 15, 60); ;
            var ButtonGrid = this.pn_grid.Controls.OfType<MyButton>();

            foreach (var button in ButtonGrid)
            {
                button.Size = new Size(this.pn_grid.Size.Width/size,this.pn_grid.Size.Height/size);
                button.Location = new Point(button.Size.Width*button.ButtonCell.Column,button.Size.Height*button.ButtonCell.Row);
            }
        }
    }
}
