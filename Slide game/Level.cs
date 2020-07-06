using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_game
{
    class Level
    {
        
        private PictureBox[] CurrentLevel;
        private PictureBox[] walls;
        private PictureBox[] enemies;
        private PictureBox[] spikes;
        private PictureBox player;
        private PictureBox[] coins;
        private PictureBox goal;
        bool[] coinremoved;
        int coinsLeft;
        int coinsCollected;
        int Score = 0;
        public static int HORIZONTAL = 0;
        public static int VERTICAL = 1;
        private int[] level3enemies = { HORIZONTAL, HORIZONTAL, VERTICAL };
        private int[] level4enemies = { HORIZONTAL, HORIZONTAL};
        private int[] level5enemies = { VERTICAL, VERTICAL, VERTICAL};
        private int[] currentlevelenemies;

        public static int[] level1layout = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                            1, 3, 0, 0, 0, 0, 0, 1, 1, 1,
                                            1, 1, 0, 0, 1, 0, 0, 0, 1, 1,
                                            1, 3, 0, 0, 0, 1, 0, 0, 3, 1,
                                            1, 0, 0, 0, 0, 0, 0, 0, 0, 1,
                                            1, 0, 0, 0, 0, 0, 1, 0, 0, 1,
                                            1, 0, 0, 1, 3, 0, 0, 1, 0, 1,
                                            1, 1, 1, 0, 1, 0, 0, 0, 0, 1,
                                            1, 5, 0, 0, 0, 0, 3, 1, 4, 1,
                                            1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                          };

        public static int[] level2layout = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                            1, 0, 3, 0, 1, 3, 0, 0, 0, 1,
                                            1, 0, 2, 0, 1, 0, 1, 2, 0, 1,
                                            1, 0, 2, 0, 1, 0, 1, 1, 0, 1,
                                            1, 0, 2, 3, 0, 0, 1, 2, 0, 1,
                                            1, 0, 0, 0, 0, 1, 0, 0, 0, 1,
                                            1, 1, 0, 0, 2, 1, 0, 0, 1, 1,
                                            1, 0, 0, 0, 1, 0, 0, 3, 0, 1,
                                            1, 5, 0, 1, 3, 0, 1, 2, 4, 1,
                                            1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                          };


        public static int[] level3layout = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                            1, 3, 0, 0, 1, 3, 1, 1, 1, 1,
                                            1, 0, 0, 0, 1, 0, 0, 1, 1, 1,
                                            1, 6, 0, 0, 0, 0, 0, 1, 1, 1,
                                            1, 0, 0, 3, 0, 0, 0, 3, 1, 1,
                                            1, 0, 0, 1, 0, 0, 0, 0, 3, 1,
                                            1, 0, 0, 3, 1, 0, 0, 0, 0, 1,
                                            1, 6, 0, 0, 0, 1, 6, 1, 0, 1,
                                            1, 5, 0, 0, 1, 1, 1, 1, 4, 1,
                                            1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                          };

        public static int[] level4layout = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                            1, 1, 0, 0, 0, 0, 1, 1, 3, 1,
                                            1, 0, 3, 1, 2, 0, 1, 0, 3, 1,
                                            1, 0, 2, 1, 0, 0, 0, 0, 3, 1,
                                            1, 0, 1, 6, 0, 3, 0, 0, 1, 1,
                                            1, 0, 0, 0, 0, 1, 0, 0, 3, 1,
                                            1, 1, 6, 0, 3, 0, 0, 0, 0, 1,
                                            1, 0, 0, 0, 1, 0, 0, 1, 0, 1,
                                            1, 5, 0, 0, 0, 0, 3, 1, 4, 1,
                                            1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                          };

        public static int[] level5layout = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                                            1, 3, 3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 1,
                                            1, 3, 0, 0, 0, 2, 1, 0, 2, 1, 1, 1, 1, 0, 1,
                                            1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 3, 0, 1,
                                            1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1,
                                            1, 3, 0, 0, 2, 1, 2, 0, 1, 0, 1, 0, 3, 0, 1,
                                            1, 0, 1, 0, 2, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1,
                                            1, 0, 0, 0, 0, 2, 0, 0, 0, 0, 1, 0, 3, 0, 1,
                                            1, 0, 0, 0, 0, 2, 0, 1, 0, 0, 1, 0, 0, 1, 1,
                                            1, 0, 0, 6, 0, 1, 0, 0, 0, 6, 1, 0, 3, 0, 1,
                                            1, 0, 0, 1, 0, 0, 3, 0, 0, 2, 1, 1, 0, 0, 1,
                                            1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 1, 0, 3, 0, 1,
                                            1, 0, 0, 0, 0, 2, 1, 2, 2, 2, 1, 0, 6, 1, 1,
                                            1, 5, 0, 0, 1, 2, 2, 2, 2, 2, 1, 0, 3, 4, 1,
                                            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,

        };
        
        public Level()
        {

        }

        public PictureBox[] getWalls()
        {
            return walls;
        }

        public PictureBox[] getSpikes()
        {
            return spikes;
        }

        public PictureBox[] getEnemies()
        {
            return enemies;
        }

        public PictureBox[] getCoins()
        {
            return coins;
        }

        public PictureBox getPlayer()
        {
            return player;
        }

        public PictureBox getGoal()
        {
            return goal;
        }

        public int getScore()
        {
            return Score;
        }

        public void addScore(int i)
        {
            Score += i;
        }

        public int getCoinsLeft()
        {
            return coinsLeft;
        }

        public int getCoinsCollected()
        {
            return coinsCollected;
        }

        public int[] getEnemyMovement(int level)
        {
            if (level == 3)
            {
                currentlevelenemies = level3enemies;
            }
            if (level == 4)
            {
                currentlevelenemies = level4enemies;
            }
            if (level == 5)
            {
                currentlevelenemies = level5enemies;
            }
            return currentlevelenemies;
        }

        public void generateLevel(int [] levellayout)
        {
            int k = 0;
            List<PictureBox> wallspots = new List<PictureBox>();
            List<PictureBox> spikespots = new List<PictureBox>();
            List<PictureBox> enemyspots = new List<PictureBox>();
            List<PictureBox> coinspots = new List<PictureBox>();
            int size = (int)Math.Sqrt(levellayout.Length);
            int HW = 60;
            if (size == 15)
            {
                HW = 40;
            }

            for (int i=0; i<size; i++)
            {
                for (int j=0; j<size; j++)
                {
                    if (levellayout[k] == 1)
                    {
                        PictureBox pb = new PictureBox
                        {
                            Height = HW,
                            Width = HW,
                            Image = Properties.Resources.Wall,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(HW * j, HW * i),
                            
                        };
                        wallspots.Add(pb);
                    }
                    if (levellayout[k] == 2)
                    {
                        PictureBox pb = new PictureBox
                        {
                            Height = HW,
                            Width = HW,
                            Image = Properties.Resources.Spike,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(HW * j, HW * i),

                        };
                        spikespots.Add(pb);
                    }

                    if (levellayout[k] == 3)
                    {
                        PictureBox pb = new PictureBox
                        {
                            Height = HW,
                            Width = HW,
                            Image = Properties.Resources.Coin,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(HW * j, HW * i),

                        };
                        coinspots.Add(pb);
                    }

                    if (levellayout[k] == 4)
                    {
                        PictureBox pb = new PictureBox
                        {
                            Height = HW,
                            Width = HW,
                            Image = Properties.Resources.Flag,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(HW * j, HW * i),

                        };
                        goal = pb;
                    }

                    if (levellayout[k] == 5)
                    {
                        PictureBox pb = new PictureBox
                        {
                            Height = HW,
                            Width = HW,
                            Image = Properties.Resources.Player,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(HW * j, HW * i),

                        };
                        player = pb;
                    }

                    if (levellayout[k] == 6)
                    {
                        PictureBox pb = new PictureBox
                        {
                            Height = HW,
                            Width = HW,
                            Image = Properties.Resources.Enemy,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(HW * j, HW * i),

                        };
                        enemyspots.Add(pb);
                    }

                    k++;
                }
            }
            PictureBox[] wallslayout = new PictureBox[wallspots.Count];
            for (int i = 0; i < wallspots.Count; i++)
            {
                wallslayout[i] = wallspots[i];
            }
            walls = wallslayout;
            PictureBox[] spikelayout = new PictureBox[spikespots.Count];
            for (int i = 0; i < spikespots.Count; i++)
            {
                spikelayout[i] = spikespots[i];
            }
            spikes = spikelayout;
            PictureBox[] enemylayout = new PictureBox[enemyspots.Count];
            for (int i = 0; i < enemyspots.Count; i++)
            {
                enemylayout[i] = enemyspots[i];
            }
            enemies = enemylayout;
            PictureBox[] coinlayout = new PictureBox[coinspots.Count];
            coinsLeft = coinspots.Count;
            coinsCollected = 0;
            coinremoved = new bool[coinspots.Count];
            for (int i=0; i<coinspots.Count; i++)
            {
                coinremoved[i] = false;
            }
            for (int i = 0; i < coinspots.Count; i++)
            {
                coinlayout[i] = coinspots[i];
            }
            coins = coinlayout;
        }

        public void startLevel(int level)
        {
            if ( level == 1)
            {
                generateLevel(level1layout);
            }
            if (level == 2)
            {
                generateLevel(level2layout);
            }
            if (level == 3)
            {
                generateLevel(level3layout);
            }
            if (level == 4)
            {
                generateLevel(level4layout);
            }
            if (level == 5)
            {
                generateLevel(level5layout);
            }
        }

        public bool DetectCollision(PictureBox[] objects, PictureBox player)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (player.Bounds.IntersectsWith(objects[i].Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        public void CollectCoin(PictureBox[] coins, PictureBox player)
        {
            
            for (int i = 0; i < coins.Length; i++)
            {   
                if (player.Bounds.IntersectsWith(coins[i].Bounds))
                {
                    coins[i].Visible = false;
                    if (!coinremoved[i])
                    {
                        coinsLeft--;
                        coinremoved[i] = true;
                        coinsCollected++;
                    }
                }
            }
        }

        public bool LevelComplete( PictureBox goal, PictureBox player)
        {      
            if (player.Bounds.Location==goal.Bounds.Location)
                {
                return true;
                }
            return false;
        }

    }
}
