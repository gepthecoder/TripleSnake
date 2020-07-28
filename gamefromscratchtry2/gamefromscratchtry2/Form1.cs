using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace gamefromscratchtry2
{
    public partial class Form1 : Form
    {
        //snake 1
        private List<circle> snake = new List<circle>();

        //snake2
        private List<circle> snake1 = new List<circle>();

        private circle food = new circle();
        private circle doublefood = new circle();

        public Form1()
        {
           
            
            PlayBackgroundSound();
            
            InitializeComponent();
            lblLeva.Text = "False";
            lblDesna.Text = "False";

            new Settings();

            gameTimer.Interval = 500 / Settings.speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();           

            StartGame();
        }


        private void StartGame()
        {           
            messagelbl.Visible = false;

            new Settings();

            snake.Clear();
            circle head = new circle();
            head.X = 10;
            head.Y = 20;
            snake.Add(head);

            new Settings1();

            snake1.Clear();
            circle head1 = new circle();
            head1.X = 60;
            head1.Y = 20;
            snake1.Add(head1);
                        

            lblscore.Text = Settings.score.ToString();
            lblscore1.Text = Settings1.score.ToString();
            GenerateFood();

        }

        private void GenerateFood()
        {
            int maxXPos = GameField.Size.Width / Settings.width;
            int maxYPos = GameField.Size.Height / Settings.height;
            Random r = new Random();
            Random z = new Random();

            food = new circle();           
            food.X = r.Next(0, maxXPos);
            food.Y = r.Next(0, maxYPos);

            
            doublefood = new circle();
            doublefood.X = z.Next(0, maxXPos);
            doublefood.Y = z.Next(0, maxXPos);

        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.gameover == true && Settings1.gameover == true)
            {
                if (Input.KeyPressed(Keys.Enter))
                    StartGame();                             
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                    if(Input.KeyPressed(Keys.D) && Settings1.direction != Direction.Left)
                    {
                        Settings1.direction = Direction.Right;
                    }

                }                  
                else if(Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                    if (Input.KeyPressed(Keys.A) && Settings1.direction != Direction.Right)
                    {
                        Settings1.direction = Direction.Left;
                    }
                }                   
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                    if (Input.KeyPressed(Keys.W) && Settings1.direction != Direction.Down)
                    {
                        Settings1.direction = Direction.Up;
                    }
                }                  
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                    if (Input.KeyPressed(Keys.S) && Settings1.direction != Direction.Up)
                    {
                        Settings1.direction = Direction.Down;
                    }
                }


                else if (Input.KeyPressed(Keys.D) && Settings1.direction != Direction.Left)
                    Settings1.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.A) && Settings1.direction != Direction.Right)
                    Settings1.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.W) && Settings1.direction != Direction.Down)
                    Settings1.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.S) && Settings1.direction != Direction.Up)
                    Settings1.direction = Direction.Down;

                MoveSnake();
                MoveSnake1();
            }
             
            GameField.Invalidate();
            

        }

        private void GameField_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            
            if(!Settings.gameover)
            {
                Brush snakeColor; //snake

                for(int i = 0; i < snake.Count; i++)
                {
                    //narišemo glavo
                    if (i == 0)
                        snakeColor = Brushes.DarkRed;
                    else snakeColor = Brushes.Brown;

                    //narišemo telo
                    canvas.FillEllipse(snakeColor,
                        new Rectangle(snake[i].X * Settings.width,
                                      snake[i].Y * Settings.height,
                                      Settings.width,
                                      Settings.height));
                    //narišemo hrano
                    canvas.FillEllipse(Brushes.Chocolate,
                        new Rectangle(food.X * Settings.width,
                                      food.Y * Settings.height,
                                      Settings.width, Settings.height));
                }
               
            }

            else
            {
                lblLeva.Text = "Dead!";
            }

            if (!Settings1.gameover)
            {
                Brush snakeColor1; //snake1

                for (int i = 0; i < snake1.Count; i++)
                {
                    //narišemo glavo
                    if (i == 0)
                        snakeColor1 = Brushes.DarkGreen;
                    else snakeColor1 = Brushes.Navy;

                    //narišemo telo
                    canvas.FillEllipse(snakeColor1,
                        new Rectangle(snake1[i].X * Settings1.width,
                                      snake1[i].Y * Settings1.height,
                                      Settings1.width,
                                      Settings1.height));
                    //narišemo hrano
                    canvas.FillEllipse(Brushes.Chocolate,
                        new Rectangle(doublefood.X * Settings1.width,
                                      doublefood.Y * Settings1.height,
                                      Settings1.width, Settings1.height));
                }
            }
            else
            {
                lblDesna.Text = "Dead!";
            }


        }

        private void MoveSnake()
        {
            for(int i = snake.Count-1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            snake[i].X++;
                            break;
                        case Direction.Left:
                            snake[i].X--;
                            break;
                        case Direction.Up:
                            snake[i].Y--;
                            break;
                        case Direction.Down:
                            snake[i].Y++;
                            break;
                    }

                    //get max X and Y Pos
                    int maxXpos = GameField.Size.Width / Settings.width;
                    int maxYpos = GameField.Size.Height / Settings.height;

                    //detect collisions with game borders
                    if(snake[i].X < 0 || snake[i].X >= maxXpos
                        || snake[i].Y < 0 || snake[i].Y >= maxYpos)
                    {
                        Die();
                    }

                    //detect collision with body
                    for(int j = 1; j < snake.Count; j++)
                    {
                        if(snake[i].X == snake[j].X &&
                            snake[i].Y == snake[j].Y)
                        {
                            Die();                 
                        }
                    }

                    //detect collison with food
                    if((snake[0].X == food.X && snake[0].Y == food.Y) || (snake[0].X == doublefood.X && snake[0].Y == doublefood.Y))
                    {
                        Eat();
                    }


                }
                else
                {
                    //movebody || the next point to the position of the previous #constant movement
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
        }

        private void MoveSnake1()
        {
            for (int i = snake1.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (Settings1.direction)
                    {
                        case Direction.Right:
                            snake1[i].X++;
                            break;
                        case Direction.Left:
                            snake1[i].X--;
                            break;
                        case Direction.Up:
                            snake1[i].Y--;
                            break;
                        case Direction.Down:
                            snake1[i].Y++;
                            break;
                    }

                    //get max X and Y Pos
                    int maxXpos = GameField.Size.Width / Settings1.width;
                    int maxYpos = GameField.Size.Height / Settings1.height;

                    //detect collisions with game borders
                    if (snake1[i].X < 0 || snake1[i].X >= maxXpos
                        || snake1[i].Y < 0 || snake1[i].Y >= maxYpos)
                    {
                        Die1();
                    }

                    //detect collision with body
                    for (int j = 1; j < snake1.Count; j++)
                    {
                        if (snake1[i].X == snake1[j].X &&
                            snake1[i].Y == snake1[j].Y)
                        {
                            Die1();                      
                        }
                    }

                    //detect collison with food
                    if ((snake1[0].X == food.X && snake1[0].Y == food.Y) || (snake1[0].X == doublefood.X && snake1[0].Y == doublefood.Y))
                    {
                        Eat1();                      
                    }


                }
                else
                {
                    //movebody || the next point to the position of the previous #constant movement
                    snake1[i].X = snake1[i - 1].X;
                    snake1[i].Y = snake1[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            circle food = new circle();
            circle doublefood = new circle();

            food.X = snake[snake.Count - 1].X;
            food.Y = snake[snake.Count - 1].Y;
            doublefood.X = snake[snake.Count - 1].X;
            doublefood.Y = snake[snake.Count - 1].Y;

            snake.Add(food);
            PlayEatingSound();

            Settings.score += Settings.points;          
            lblscore.Text = Settings.score.ToString();          
            GenerateFood();
            GenerateFood();
        }
       
        private void Eat1()
        {
            circle food = new circle();
            circle doublefood = new circle();

            food.X = snake1[snake1.Count - 1].X;
            food.Y = snake1[snake1.Count - 1].Y;
            doublefood.X = snake1[snake1.Count - 1].X;
            doublefood.Y = snake1[snake1.Count - 1].Y;

            snake1.Add(food);
            PlayEatingSound();

            Settings1.score += Settings1.points;
            lblscore1.Text = Settings1.score.ToString();
            GenerateFood();
            GenerateFood();
        }

        private void Die()
        {
            PlayDyingSound();
            Settings.gameover = true;

        }

        private void Die1()
        {
            PlayDyingSound();
            Settings1.gameover = true;
        }

        private void PlayBackgroundSound()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\GEP\Desktop\N1\C#\gamefromscratchtry2\gamefromscratchtry2\krmak.wav"))
            {

                soundPlayer.Play(); 
            }
        }
        private void PlayEatingSound()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\GEP\Desktop\N1\C#\gamefromscratchtry2\gamefromscratchtry2\eaten.wav"))
            {
                soundPlayer.Play(); 
            }
        }
        private void PlayDyingSound()
        {
            using (var soundPlayer = new SoundPlayer(@"C:\Users\GEP\Desktop\N1\C#\gamefromscratchtry2\gamefromscratchtry2\endgame.wav"))
            {
                soundPlayer.Play(); 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void DesignGameFloor()
        {
            
           
            
        }

    }
}
