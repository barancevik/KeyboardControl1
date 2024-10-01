using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardControl1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = ball.Location.X;
            int y = ball.Location.Y;


            if (e.KeyCode == Keys.Right)
            {
                x = x + 10;

            }

            if (e.KeyCode == Keys.Left)
            {
                x = x - 10;
            }

            if (e.KeyCode == Keys.Up)
            {
                y = y - 10;
            }

            if (e.KeyCode == Keys.Down)
            {
                y = y + 10;
            }

            if (ball.Right >= lblright.Left)
            {
                lblright.BackColor = Color.Red;
                if (ball.Left <= lblright.Left)
                {
                    lblright.BackColor = Color.White;
                }
            }

            if (ball.Left <= lblleft.Right)
            {
                lblleft.BackColor = Color.Red;
                if (ball.Right >= lblleft.Left)
                {
                    lblleft.BackColor = Color.White;
                }
            }

            if(ball.Bottom>=lbldown.Top)
            {
                lbldown.BackColor = Color.Red;
                if(ball.Top<=lbldown.Bottom)
                {
                    lbldown.BackColor = Color.White;
                }
            }


            if(ball.Top<=lblup.Bottom)
            {
                lblup.BackColor = Color.Red;
                if(ball.Bottom>=lblup.Top)
                {
                    lblup.BackColor = Color.White;
                }
            }




            ball.Location = new Point(x, y);



        }
    }
        
}
