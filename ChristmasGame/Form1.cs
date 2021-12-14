using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int treeSpeed = 6;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            santa.Top += gravity;
            snowflake.Top += gravity;
            snowflake1.Top += gravity;

            treeTop.Left -= treeSpeed;
            treeBottom.Left -= treeSpeed;

            scoreLabel.Text = $"score : {score}"; 

            if(treeTop.Left < -60)
            {
                treeTop.Left = 969;
                score++;
            }
            if(treeBottom.Left < -60)
            {
                treeBottom.Left = 965;
                score++;
            }

            if(santa.Top < -25)
            {
                gameOver();
            }

            if(santa.Bounds.IntersectsWith(treeTop.Bounds) || santa.Bounds.IntersectsWith(treeBottom.Bounds) || santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void santa_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer1.Stop();
            scoreLabel.Text = "Game Over!";
            button.Visible = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
