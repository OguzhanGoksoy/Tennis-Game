using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yataydegisim = 1, dikeydegisim = 1, artis = 1;
        private void label4_Click(object sender, EventArgs e)
        {



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            yataydegisim = artis;
            dikeydegisim = artis;
            ball.Top = 160;
            ball.Left = 380;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += yataydegisim;
            ball.Top += dikeydegisim;

            if (ball.Top >= (this.Height - 110))
            {
                dikeydegisim = -artis;


            }
            if (ball.Top <= 0)
            {
                dikeydegisim = artis;
            }
            if (ball.Left >= 740)
            {
                if ((ball.Top >= rk2.Top) && ((ball.Top <= rk2.Top + 80)))
                {
                    yataydegisim *= -1;

                }
            }
            if (ball.Left <= 18)
            {
                if ((ball.Top >= rk1.Top) && (ball.Top <= rk1.Top + 80))
                {
                    yataydegisim *= -1;

                }
            }
        
        if ((ball.Left>770)| (ball.Left<-30))
        {
            if(ball.Left<-30)
            {
                label3.Text = (Convert.ToByte(label3.Text) + 1).ToString();
                yataydegisim = Convert.ToByte(label3.Text) + Convert.ToByte(label4.Text) + 1;
            }
            else
            {
                label4.Text = (Convert.ToByte(label4.Text) + 1).ToString();
                     yataydegisim = Convert.ToByte(label3.Text) + Convert.ToByte(label4.Text) + 1;
            }
            timer1.Enabled = false;
            afasdfas.Visible = true;
            ball.Left= 380;
                ball.Top=160;
            rk1.Top=120;
            rk2.Top = 120;

            if (label3.Text == "5")
            {
                MessageBox.Show("Oyun Bitti ! tebrikler Oyuncu 2");
                yataydegisim = 1; dikeydegisim = 1; artis = 1;
            }
            else if (label4.Text == "5")
            {
                MessageBox.Show("Oyun Bitti ! tebrikler Oyuncu 1");
                yataydegisim = 1; dikeydegisim = 1; artis = 1;
            }
        }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                afasdfas.Visible = false;
            }
        }

     

        private void ball_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                afasdfas.Visible = false;
            }
        }

      
        private void rk2_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (rk2.Top > 10)
                {
                    rk2.Top -= 20;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (rk2.Top < 260)
                {
                    rk2.Top += 20;
                }
            }

        }

        private void rk2_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 65)
            {
                if (rk2.Top > 10)
                {
                    rk2.Top -= 20;
                }
            }

            if (e.KeyChar == 68)
            {
                if (rk2.Top < 260)
                {
                    rk2.Top += 20;
                }
            }
        }

      
        private void rk1_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (rk2.Top > 10)
                {
                    rk2.Top -= 20;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (rk2.Top < 260)
                {
                    rk2.Top += 20;
                }
            }

        }

        private void rk1_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 65)
            {
                if (rk1.Top > 10)
                {
                    rk1.Top -= 20;
                }
            }

            if (e.KeyChar == 68)
            {
                if (rk1.Top < 260)
                {
                    rk1.Top += 20;
                }
            }
        }
    }
}
