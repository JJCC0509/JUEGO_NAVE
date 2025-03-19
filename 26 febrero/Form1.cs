using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _JUEGO_NAVE
{
    public partial class game : Form
    {
        int X = 100;
        bool dir = true;
        bool leftPressed, rightPressed;
        private List<PictureBox> bullets = new List<PictureBox>();
        private int score = 0;
        private Label lblScore;

        public game()
        {
            InitializeComponent();
            this.Load += new EventHandler(form1_load);
            this.KeyDown += new KeyEventHandler(game_KeyDown);
            this.KeyUp += new KeyEventHandler(game_KeyUp);
            TMR_1.Tick += new EventHandler(TMR_1_Tick);

            
            TMR_1.Interval = 20;
            TMR_1.Start();

            
            Timer tmrGame = new Timer { Interval = 20 };
            tmrGame.Tick += new EventHandler(TMR_Game_Tick);
            tmrGame.Start();
        }

        private void TMR_1_Tick(object sender, EventArgs e)
        {
            OVNI.Location = new Point(X, 20);
            if (dir)
            {
                X += 10;
            }
            else
            {
                X -= 10;
            }
            if (X >= this.ClientSize.Width - OVNI.Width)
            {
                dir = false;
            }
            if (X <= 10)
            {
                dir = true;
            }
        }

        private void TMR_Game_Tick(object sender, EventArgs e)
        {
            
            int x = NAVE.Location.X;
            int STEP = 10;
            if (leftPressed && x > 0) x -= STEP;
            if (rightPressed && x + NAVE.Width < this.ClientSize.Width) x += STEP;
            NAVE.Location = new Point(x, NAVE.Location.Y);

            
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].Top -= 15;
                if (bullets[i].Bounds.IntersectsWith(OVNI.Bounds))
                {
                    this.Controls.Remove(bullets[i]);
                    bullets.RemoveAt(i);
                    score += 10;
                    lblScore.Text = $"Puntuación: {score}";
                    OVNI.Location = new Point(100, 20);
                }
                else if (bullets[i].Top < 0)
                {
                    this.Controls.Remove(bullets[i]);
                    bullets.RemoveAt(i);
                }
            }
        }

     

        private void form1_load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            lblScore = new Label
            {
                Location = new Point(10, 10),
                Text = "Puntuación: 0",
                AutoSize = true
            };
            this.Controls.Add(lblScore);
        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) leftPressed = true;
            if (e.KeyCode == Keys.D) rightPressed = true;
            if (e.KeyCode == Keys.Space)
            {
                
                PictureBox bullet = new PictureBox
                {
                    Size = new Size(5, 10),
                    BackColor = Color.Red,
                    Location = new Point(NAVE.Location.X + NAVE.Width / 2 - 2, NAVE.Location.Y - 10)
                };
                this.Controls.Add(bullet);
                bullets.Add(bullet);
            }
        }

        private void game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) leftPressed = false;
            if (e.KeyCode == Keys.D) rightPressed = false;
        }
        private void game_Load(object sender, EventArgs e) { }
    }
}
