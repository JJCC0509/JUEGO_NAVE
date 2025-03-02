using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _JUEGO_NAVE
{
    public partial class Form1 : Form
    {
        int X = 100;
        bool dir = true;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(form1_load);
            this.NAVE.KeyPress += new KeyPressEventHandler(NAVE_KeyPress);



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
            if (X >= this.Size.Width - OVNI.Width)
            {
                dir = false;
            }
            if (X <= 10)
            {
                dir = true;
            }



        }


        private void IMG_1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DESPLAZAR_Click(object sender, EventArgs e)
        {
            TMR_1.Enabled = true;
            MessageBox.Show(this.OVNI.Size.Width.ToString());
        }

        private void NAVE_Click(object sender, EventArgs e)
        {

        }
        private void form1_load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void NAVE_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            int x = NAVE.Location.X;
            int y = NAVE.Location.Y;
            int STEP =10;
            if (e.KeyChar == 'D' || e.KeyChar=='d')
            {
                x += STEP;
                if (x+NAVE.Width > this.ClientSize.Width)
                {
                    x = this.ClientSize.Width - NAVE.Width;
                }
            }
            if (e.KeyChar == 'A' || e.KeyChar == 'a')
            {
                x -= STEP;
                if (x < 0)
                {
                    x = 0;
                }
            }
           
            
            Point p= new Point(x, y);
            NAVE.Location = p;
        }

    }
}