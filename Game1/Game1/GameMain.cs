using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class GameMain : Form
    {
        public GameMain()
        {
            InitializeComponent();
        }
        int speed = 16;
        int vdir = +1;
        int hdir = +1;
        int slide_speed = 50;
        bool gameOver = false;
        int score = 0;
        bool _left = false, _right = false;
        bool pause
        {
            get
            { return !pnlPause.Visible; }
            set
            { pnlPause.Visible = !value; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void vert_Tick(object sender, EventArgs e)
        {
            if (picBall.Top < 0)
            {
                vdir = +1;
            }
            else if (picBall.Top > (this.Height - picBall.Height - picslid.Height))
            {
                vdir = -1;

                if (picBall.Left < picslid.Left || ((picBall.Left + picBall.Width) > (picslid.Left + picslid.Width)))
                {
                    vert.Enabled = hor.Enabled = false;
                    pnlGameOver.Visible = true;
                    gameOver = true;
                    lblValue.BackColor = Color.DarkRed;
                    btnRefreshGame.BackColor = Color.DarkRed;
                    lblValue.Text = "Game Over!";

                }
                else
                {
                    score++;
                    speed++;
                }

            }
            lblScore.Text = score.ToString();
            picBall.Top += vdir * speed;
        }
        private void hor_Tick(object sender, EventArgs e)
        {
            if (picBall.Left < 0)
            {
                hdir = +1;
            }
            else if (picBall.Left > (this.Width - picBall.Width))
            {
                hdir = -1;
            }
            picBall.Left += hdir * speed;
        }
        private void GameMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                _right = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                _left = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                vert.Enabled = hor.Enabled = pause = false;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                vert.Enabled = hor.Enabled = pause = true;
            }
        }
        private void watch_Tick(object sender, EventArgs e)
        {
            if (_right && picslid.Left < (this.Width - picslid.Width))
            {
                picslid.Left = picslid.Left + slide_speed;
            }
            else if (_left && picslid.Left > 0)
            {
                picslid.Left = picslid.Left - slide_speed;

            }

        }

        private void btnRefreshGame_Click(object sender, EventArgs e)
        {
            vert.Enabled = hor.Enabled = true;
            lblScore.Text = "0";
            pnlGameOver.Visible = false;
        }
        private void btnMinimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

        private void GameMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false;
            }
            else
            {
                _left = true;
            }
        }
    }
}
