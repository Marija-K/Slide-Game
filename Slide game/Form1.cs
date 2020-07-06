using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_game
{
    public partial class Form1 : Form
    {
        Level level = new Level();
        PictureBox player1 = new PictureBox();
        int speed = 5;
        int[] enemyspeed;
        bool moving;
        int currentlevelnum = 1;
        bool addedScore;
        Keys lastKeyPressed;
        bool inGame = false;
        bool [] LevelCompleted = new bool[5];
        int timerScore = 1000;
        int[] LevelScore = new int[5];
        bool gameEnded = false;
        void InitPlayer()
        {
            player1.Image = Properties.Resources.Player;
            player1.Height = 60;
            player1.Width = 60;
            player1.Location = new Point(60, 480);
            player1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        PictureBox[] walls;
        PictureBox[] spikes;
        PictureBox[] enemies;
        PictureBox[] coins;
        PictureBox goal = new PictureBox();
        int[] enemyMovement;
        public Form1()
        {
            InitializeComponent();
            InitPlayer();
            MainMenuPanel.Visible = true;
            ResetLevels();
            //StartForm(currentlevelnum);
        }

        public void StartForm(int i)
        {
            level.startLevel(i);
            walls = level.getWalls();
            this.Controls.AddRange(walls);
            spikes = level.getSpikes(); 
            enemies = level.getEnemies();
            if (enemies != null)
            {   
                enemyMovement = level.getEnemyMovement(i);
                this.Controls.AddRange(enemies);
                enemyspeed = new int[enemies.Length];
                ResetEnemySpeed();
                Enemy_Movement_Timer.Enabled = true;
            }           
            coins = level.getCoins();
            this.Controls.AddRange(coins);
            player1 = level.getPlayer();
            this.Controls.Add(player1);
            goal = level.getGoal();
            this.Controls.Add(goal);            
            
            
            
            if (spikes != null)
            {
                this.Controls.AddRange(spikes);
            }
            
            addedScore = false;
            moving = false;
            currentlevelnum = i;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!moving)
            {
                if (e.KeyCode == Keys.Left)
                {
                    Player_Movement_LEFT.Start();
                }
                if (e.KeyCode == Keys.Right)
                {
                    Player_Movement_RIGHT.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    Player_Movement_UP.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    Player_Movement_DOWN.Start();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    moving = true;
                    lastKeyPressed = e.KeyCode;
                }
            }
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                if(LevelCompletePanel.Visible == false){
                    PausePanel.Visible = true;
                    StopMovement();
                }
            }

        }

        private void Player_Movement_Timer_Tick_UP(object sender, EventArgs e)
        {
            player1.Top -= speed;
            if (level.DetectCollision(walls, player1))
            {
                Player_Movement_UP.Stop();
                player1.Top += speed;
                moving = false;
            }
            CheckforDeath();
        }

        private void Player_Movement_DOWN_Tick(object sender, EventArgs e)
        {
            player1.Top += speed;
            if (level.DetectCollision(walls, player1))
            {
                Player_Movement_DOWN.Stop();
                player1.Top -= speed;
                moving = false;
            }
            CheckforDeath();
        }

        private void Player_Movement_LEFT_Tick(object sender, EventArgs e)
        {
            player1.Left -= speed;
            if (level.DetectCollision(walls, player1))
            {
                Player_Movement_LEFT.Stop();
                player1.Left += speed;
                moving = false;
            }
            CheckforDeath();
        }

        private void Player_Movement_RIGHT_Tick(object sender, EventArgs e)
        {
            player1.Left += speed;
            if (level.DetectCollision(walls, player1))
            {
                Player_Movement_RIGHT.Stop();
                player1.Left -= speed;
                moving = false;
            }
            CheckforDeath();
        }

        private void CheckforDeath()
        {
            if (spikes != null)
                if (level.DetectCollision(spikes, player1))
                {
                    Death();
                }
            if (enemies != null)
                if (level.DetectCollision(enemies, player1))
                {
                    Death();
                }
        }

        private void StartTimers()
        {
            TimerScore_Timer.Start();
            Score_Timer.Start();
            //if (currentlevelnum >= 3)
            //{
            //    Enemy_Movement_Timer.Start();
            //}
        }

        private void StopTimers()
        {
            TimerScore_Timer.Stop();
            Score_Timer.Stop();
            //Enemy_Movement_Timer.Stop();
        }

        private void StopMovement()
        {
            Player_Movement_DOWN.Stop();
            Player_Movement_LEFT.Stop();
            Player_Movement_RIGHT.Stop();
            Player_Movement_UP.Stop();
            Enemy_Movement_Timer.Enabled = false;
            moving = true;
        }

        private void CollectCoin()
        {
            level.CollectCoin(coins, player1);

        }

        private void LevelCompletedScores(int coinsbonus, int total)
        {
            Current_Level_Timer_Score.Text = "" + timerScore;
            Coins_Bonus_Score.Text = "" + coinsbonus;
            Coins_Ratio.Text = level.getCoinsCollected() + "/" +level.getCoins().Length;
            Total_Current_Level_Score.Text = "" + total;
        }

        private void ResetLevels()
        {
            for (int i=0; i<5; i++)
            {
                LevelCompleted[i] = false;
            }
            LevelProgress();
        }

        private void ResetLevelsScore()
        {
            for (int i = 0; i < 5; i++)
            {
                LevelScore[i] = 0;
            }
            DisplayScores();
        }

        private void DisplayScores()
        {
            Level1_Score.Text = "" + LevelScore[0];
            Level2_Score.Text = "" + LevelScore[1];
            Level3_Score.Text = "" + LevelScore[2];
            Level4_Score.Text = "" + LevelScore[3];
            Level5_Score.Text = "" + LevelScore[4];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += LevelScore[i];
            }
            Total_Score.Text = "" + sum;
        } 

        private void LevelProgress()
        {
            if (LevelCompleted[0] == false)
            {
                Level2_Button.Enabled = false;
            }
            else
            {
                Level2_Button.Enabled = true;
            }
            if (LevelCompleted[1] == false)
            {
                Level3_Button.Enabled = false;
            }
            else
            {
                Level3_Button.Enabled = true;
            }
            if (LevelCompleted[2] == false)
            {
                Level4_Button.Enabled = false;
            }
            else
            {
                Level4_Button.Enabled = true;
            }
            if (LevelCompleted[3] == false)
            {
                Level5_Button.Enabled = false;
            }
            else
            {
                Level5_Button.Enabled = true;
            }
        }


        private void Death()
        {
            TimerScore_Timer.Stop();
            Dead.Visible = true;
            StopMovement();
            DeathPanel.Visible = true;
            
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            Start_Level(currentlevelnum);
        }

        private void Score_Timer_Tick(object sender, EventArgs e)
        {
            if (inGame)
            {
                CollectCoin();
            }
            CheckforDeath();
            int coinsbonus = 0;
            int total = 0;
            Timer.Text = "Score " + timerScore;
            CoinsLeft.Text = "Coins Left " + level.getCoinsLeft();
            CurrentLevel.Text = "Level " + currentlevelnum;
            if (level.LevelComplete(goal, player1))
            {
                TimerScore_Timer.Stop();
                StopMovement();
                if(level.getCoinsLeft() == 0)
                {
                    coinsbonus = 500;
                }
                total = timerScore + coinsbonus;
                if (!addedScore)
                {
                    if (LevelScore[currentlevelnum - 1] < total)
                    {
                        LevelScore[currentlevelnum - 1] = total;                        
                    }addedScore = true;
                }

                LevelCompletedScores(coinsbonus, total);
                if(!gameEnded)
                LevelCompletePanel.Visible = true;
                if (inGame)
                {
                    LevelCompleted[currentlevelnum - 1] = true;
                }
                Score_Timer.Stop();
            }
        }

        private void Next_Level_Click(object sender, EventArgs e)
        {            
            if (currentlevelnum >= 5)
            {
                StopTimers();
                LevelCompletePanel.Visible = false;
                GameWonPanel.Visible = true;
                gameEnded = true;
                //inGame = false;                
            }
            else
            {
                currentlevelnum++;
                Start_Level(currentlevelnum);
            }
        }

        public void Start_Game_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            Start_Level(1);
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            InitializeComponent();
            MainMenuPanel.Visible = true;
            LevelCompletePanel.Visible = false;
            StatsPanel.Visible = false;
            inGame = false;
            StopTimers();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            PausePanel.Visible = false;
            if (lastKeyPressed == Keys.Left)
            {
                Player_Movement_LEFT.Start();
            }
            if (lastKeyPressed == Keys.Right)
            {
                Player_Movement_RIGHT.Start();
            }
            if (lastKeyPressed == Keys.Up)
            {
                Player_Movement_UP.Start();
            }
            if (lastKeyPressed == Keys.Down)
            {
                Player_Movement_DOWN.Start();
            }
            if (lastKeyPressed == Keys.Left || lastKeyPressed == Keys.Right || lastKeyPressed == Keys.Up || lastKeyPressed == Keys.Down)
            {
                moving = true;
            }
            StartTimers();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            QuitPanel.Visible = true;
            MainMenuPanel.Enabled = false;
            QuitPanel.BringToFront();
        }

        private void Yes_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void No_Button_Click(object sender, EventArgs e)
        {
            QuitPanel.Visible = false;
            MainMenuPanel.Enabled = true;
            QuitPanel.SendToBack();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            HowtoPlayPanel.Visible = false;
            MainMenuPanel.Visible = true;
        }

        private void How_To_Play_Button_Click(object sender, EventArgs e)
        {
            HowtoPlayPanel.Visible = true;
            MainMenuPanel.Visible = false;
        }


        private void Level1_Button_Click(object sender, EventArgs e)
        {
            LevelSelectPanel.Visible = false;
            Start_Level(1);
        }

        private void Level2_Button_Click(object sender, EventArgs e)
        {
            LevelSelectPanel.Visible = false;
            Start_Level(2);
        }

        private void Level3_Button_Click(object sender, EventArgs e)
        {
            LevelSelectPanel.Visible = false;
            Start_Level(3);
        }

        private void Start_Level(int level)
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            InitializeComponent();
            StartForm(level);
            TimerScore_Timer.Start();            
            StatsPanel.Visible = true;
            inGame = true;
            timerScore = 1000;
            gameEnded = false;
        }

        private void ResetEnemySpeed()
        {
            for (int i=0; i<enemyspeed.Length; i++)
            {
                enemyspeed[i] = 5;
            }
        }

        private void High_Score_Button_Click(object sender, EventArgs e)
        {
            DisplayScores();
            MainMenuPanel.Visible = false;
            HighScorePanel.Visible = true;
            HighScoreDisplayPanel.Update();
        }

        private void Level_Select_Button_Click(object sender, EventArgs e)
        {
            LevelProgress();
            MainMenuPanel.Visible = false;
            LevelSelectPanel.Visible = true;
            Level_Selection_Panel.Update();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ResetLevels();
        }

        private void Level4_Button_Click(object sender, EventArgs e)
        {
            LevelSelectPanel.Visible = false;
            Start_Level(4);
        }

        private void Level5_Button_Click(object sender, EventArgs e)
        {
            LevelSelectPanel.Visible = false;
            Start_Level(5);
        }

        private void Back_Button2_Click(object sender, EventArgs e)
        {
            LevelSelectPanel.Visible = false;
            MainMenuPanel.Visible = true;
        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            if (LevelCompletePanel.Visible == false)
            {
                PausePanel.Visible = true;
                StopMovement();
                StopTimers();
            }
        }

        private void Back_Button3_Click(object sender, EventArgs e)
        {
            HighScorePanel.Visible = false;
            MainMenuPanel.Visible = true;
        }

        private void Reset_Score_Button_Click(object sender, EventArgs e)
        {
            ResetLevelsScore();
            HighScoreDisplayPanel.Update();
        }

        private void TimerScore_Timer_Tick(object sender, EventArgs e)
        {
            timerScore -= 10;
        }

        private void Enemy_Movement_Timer_Tick(object sender, EventArgs e)
        {
            for (int i=0; i<enemies.Length; i++)
            {
                if (enemyMovement[i] == 0)
                {
                    enemies[i].Left -= enemyspeed[i];
                }
                else
                {
                    enemies[i].Top -= enemyspeed[i];
                }
                if(level.DetectCollision(walls, enemies[i]))
                {
                    enemyspeed[i] = -enemyspeed[i];
                }
                if (level.DetectCollision(spikes, enemies[i]))
                {
                    enemyspeed[i] = -enemyspeed[i];
                }

            }
        }
    }
}
