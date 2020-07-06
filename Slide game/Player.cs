using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_game
{
    class Player
    {
        PictureBox player = new PictureBox();

        public Player()
        {
            player.Image = Image.FromFile("C:/Users/User/source/repos/Slide game/Slide game/Resources/Player.jpg");
            player.Height = 60;
            player.Width = 60;
            player.Location = new Point(80, 450);
        }

        public PictureBox getPlayer()
        {
            return player;
        }

        public void MoveLeft()
        {
            player.Left += 2;                     
        }

        public void MoveRight()
        {
            player.Left -= 2;
        }

        public void MoveUp()
        {
            player.Top += 2;
        }

        public void MoveDown()
        {
            player.Top -= 2;
        }

        public bool DetectCollision(PictureBox [] objects, PictureBox player)
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

    }
}
