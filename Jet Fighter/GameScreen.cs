using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jet_Fighter
{
    public partial class GameScreen : UserControl
    {

        List<Bullet> bullets = new List<Bullet>();
        List<Bullet2> bullets2 = new List<Bullet2>();

        Size screenSize;
        
        public static int gsWidth = 600;
        public static int gsHeight = 600;
        
        Random randGen = new Random();
        PlayerWhite white;
        PlayerBlack black;
        Bullet bullet;
        Bullet2 bullet2;

        int shotOk = 50;

        int playerWhiteLives = 3;
        int playerBlackLives = 3; 
        

        bool upArrowDown = false;
        bool downArrowDown = false;
        public static bool leftArrowDown = false;
        bool rightArrowDown = false;

        bool wKeyDown = false;
        bool sKeyDown = false;
        bool aKeyDown = false;
        bool dKeyDown = false;

        bool spacebarDown = false;
        bool mKeyDown = false;
       
        


        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        
        public void InitializeGame()
        {
            screenSize = new Size(this.Width, this.Height);

      
            int x = 285;
            int y = 500;
            white = new PlayerWhite(x, y);

            //bullet = new Bullet(x, y, 0, -6);

            x = 285;
            y = 50;

            black = new PlayerBlack(x, y);

            playerWhite.Text = $"";
           
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
           
            //Player White 
            if (leftArrowDown == true)
            {
                white.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                white.Move("right", screenSize);
            }

            if (upArrowDown == true)
            {
                white.Move("up", screenSize);
            }

            if (downArrowDown == true)
            {
                white.Move("down", screenSize);
            }




            if (aKeyDown == true)
            {
                black.Move("left", screenSize);
            }

            if (dKeyDown == true)
            {
                black.Move("right", screenSize);
            }

            if (wKeyDown == true)
            {
                black.Move("up", screenSize);
            }

            if (sKeyDown == true)
            {
                black.Move("down", screenSize);
            }

            shotOk--;

            if (spacebarDown == true && shotOk <= 0)
            {
                
                bullet2 = new Bullet2(black.x, black.y + 5, 0, 8);
                bullets2.Add(bullet2);

                shotOk = 50;
            }


            if (mKeyDown == true && shotOk <= 0)
            {

                bullet = new Bullet(white.x, white.y - 5, 0, -8);
                bullets.Add(bullet);

                shotOk = 50;
            }


           
            

            foreach (Bullet b in bullets)
            {
                b.Move(screenSize);

           
            }

            foreach (Bullet b in bullets)
            {
                if (b.Collision(white)) 
                {
                    playerWhiteLives--;
                    bullets.Remove(b);  
                    break;
                }
               
            }

            foreach (Bullet b in bullets)
            {
                if (b.Collision(black))
                {
                    playerBlackLives--;
                    bullets.Remove(b);
                    break;
                }

            }





            if (playerWhiteLives == 0)
            {
                gameTimer.Enabled = false; Form1.ChangeScreen(this, new MenuScreen());
            }

            if (playerBlackLives == 0)
            {
                gameTimer.Enabled = false; Form1.ChangeScreen(this, new MenuScreen());
            }


            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            playerWhite.Text = $"{playerWhiteLives}";
            playerBlack.Text = $"{playerBlackLives}";

            e.Graphics.FillEllipse(Brushes.White, white.x, white.y, white.height,
                white.width);

           
            foreach (Bullet b in bullets)
            {
                e.Graphics.FillEllipse(Brushes.Black, b.x, b.y,
               b.size, b.size);
            }

            
            
           

            e.Graphics.FillEllipse(Brushes.Black, black.x, black.y, black.height, black.width);

            
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.Space:
                    spacebarDown = false;
                    break;
                case Keys.M:
                    mKeyDown = false;
                    break;
            }




        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.Space:
                    spacebarDown = true;
                    break;
                case Keys.M:
                    mKeyDown = true;
                    break;
            }








        }
    }
}
