using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class frmMain : Form
    {
        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();



        public frmMain()
        {
            InitializeComponent();
            //set settings to defaults
            new Settings();
            //set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
            rdbback2.Select();
        }
        private void StartGame()
        {
            lblGameOver.Visible = false;
            //set settings to defaults
            new Settings();


            //create new player object
            snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            snake.Add(head);
            lblscoreValue.Text = Settings.Score.ToString();
            GenerateFood();

        }
        //Place random food game
        private void GenerateFood()
        {
            int maxXPos = picCanvas.Size.Width / Settings.width;
            int maxYPos = picCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver == true)
            {
                //check if enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                //if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.left)
                //    Settings.direction = Direction.right;
                //else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.right)
                //    Settings.direction = Direction.left;
                //else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.down)
                //    Settings.direction = Direction.up;
                //else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.up)
                //    Settings.direction = Direction.down;

                MovePlayer();
            }
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //set color of snake
                Brush snakeColore;


                //draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    if (i == 0)
                        snakeColore = Brushes.Black;//draw head
                    else
                        snakeColore = Brushes.Green;//rest of body

                    //draw snakes
                    canvas.FillEllipse(snakeColore,
                        new Rectangle(snake[i].X * Settings.width,
                                      snake[i].Y * Settings.Height,
                                      Settings.width, Settings.Height));

                    //draw food
                    canvas.FillEllipse(Brushes.White,
                        new Rectangle(food.X * Settings.width,
                        food.Y * Settings.Height, Settings.width, Settings.Height));

                }
            }
            else
            {
                string gameover = "Game over \nYour final score is:" + Settings.Score + "\nPress Enter to try agin.";
                lblGameOver.Text = gameover;
                lblGameOver.Visible = true;

            }
        }
        private void MovePlayer()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.up:
                            snake[i].Y--;
                            break;
                        case Direction.down:
                            snake[i].Y++;
                            break;
                        case Direction.left:
                            snake[i].X--;
                            break;
                        case Direction.right:
                            snake[i].X++;
                            break;
                        default:
                            break;
                    }

                    //get max x and y pos
                    int maxXPos = picCanvas.Size.Width / Settings.width;
                    int maxYPos = picCanvas.Size.Height / Settings.Height;

                    //detect collision with game border
                    if (snake[i].X < 0 || snake[i].Y < 0 ||
                          snake[i].X >= maxXPos || snake[i].Y >= maxYPos)
                    {
                        Die();
                    }

                    //detect collision with body
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X &&
                            snake[i].Y == snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //detect collision with food pice
                    if (snake[0].X == food.X && snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //move body
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }


        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            //add circle to body
            Circle food = new Circle();
            food.X = snake[snake.Count - 1].X;
            food.Y = snake[snake.Count - 1].Y;

            snake.Add(food);

            //update score
            Settings.Score += Settings.Points;
            lblGameOver.Text = Settings.Score.ToString();
            lblscoreValue.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Settings.GameOver == true)
            {
                //check if enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        if (Settings.direction != Direction.left)
                        {
                            Input.changeState(Keys.Right, true);
                            Settings.direction = Direction.right;
                        }
                        break;
                    case Keys.Left:
                        if (Settings.direction != Direction.right)
                        {
                            Input.changeState(Keys.Left, true);
                            Settings.direction = Direction.left;
                        }
                        break;
                    case Keys.Up:
                        if (Settings.direction != Direction.down)
                        {
                            Input.changeState(Keys.Up, true);
                            Settings.direction = Direction.up;
                        }
                        break;
                    case Keys.Down:
                        if (Settings.direction != Direction.up)
                        {
                            Input.changeState(Keys.Down, true);
                            Settings.direction = Direction.down;
                        }
                        break;
                    default:
                        break;
                }

                MovePlayer();
            }
            picCanvas.Invalidate();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Settings.GameOver == true)
            {
                //check if enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        Input.changeState(Keys.Right, true);
                        Settings.direction = Direction.right;
                        break;
                    case Keys.Left:
                        Input.changeState(Keys.Left, true);
                        Settings.direction = Direction.left;
                        break;
                    case Keys.Up:
                        Input.changeState(Keys.Up, true);
                        Settings.direction = Direction.up;
                        break;
                    case Keys.Down:
                        Input.changeState(Keys.Down, true);
                        Settings.direction = Direction.down;
                        break;
                    default:
                        break;
                }

                MovePlayer();
            }
            picCanvas.Invalidate();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {


            //start New Game
            StartGame();
            Settings.GameOver = false;

            gameTimer.Enabled = true;
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Settings.GameOver = false;
            gameTimer.Enabled = true;
            StartGame();
            textBox1.Select();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            Settings.GameOver = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.ExitThread();
        }

        private void rdbback1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbback1.Checked)
            {
                picCanvas.Image = pictureBox1.Image;
            }
            else
            {
                picCanvas.Image = pictureBox2.Image;
            }
        }

        private void rdbback2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbback2.Checked)
            {
                picCanvas.Image = pictureBox2.Image;
            }
            else
            {
                picCanvas.Image = pictureBox1.Image;
            }
        }
    }
}
