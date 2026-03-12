using Assignment.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class numTotalCoin : Form
    {
        int money = 0;
        int money1 = 0;
        int money2 = 0;
        int money3 = 0;
        int money4 = 0;
        int money5 = 0;
        int money6 = 0;

        Random ran = new Random();
        int r1, r2, r3;

        bool isPlaying = false;

        public numTotalCoin()
        {
            InitializeComponent();
        }
      

        private void Calculate()
        {

            int winCoin = 0;

            int[] resultCount = new int[6];
            resultCount[r1]++;
            resultCount[r2]++;
            resultCount[r3]++;

            int[] bet = new int[6];

            int.TryParse(txtTiger.Text, out bet[0]);
            int.TryParse(txtPot.Text, out bet[1]);
            int.TryParse(txtRooster.Text, out bet[2]);
            int.TryParse(txtShrimp.Text, out bet[3]);
            int.TryParse(txtCrab.Text, out bet[4]);
            int.TryParse(txtFish.Text, out bet[5]);



            // calculate normal win
            for (int i = 0; i < 6; i++)
            {
                if (bet[i] > 0 && resultCount[i] > 0)
                {
                    winCoin += (bet[i] * resultCount[i]) + bet[i];
                }
            }

            // jackpot (fixed)
            //if (r1 == r2 && r2 == r3)
            //{
            //    if (bet[r1] > 0)
            //    {
            //        winCoin += 500;
            //    }
            //}

            // add to money
            money += winCoin;
            lblMoney.Text = money.ToString();

            // show result
            if (winCoin > 0)
            {
                MessageBox.Show("You win: " + winCoin);
            }
            else
            {
                MessageBox.Show("You lose!");
            }



            ClearBet();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Money cannot be negative!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            money += 100;
            lblMoney.Text = money.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (money >= 100)
            {
                money1 += 100;
                txtTiger.Text = money1.ToString();

                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money2 += 100;
                txtPot.Text = money2.ToString();

                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money3 += 100;
                txtRooster.Text = money3.ToString();

                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money4 += 100;
                txtShrimp.Text = money4.ToString();

                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money5 += 100;
                txtCrab.Text = money5.ToString();

                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (money >= 100)
            {
                money6 += 100;
                txtFish.Text = money6.ToString();

                money -= 100;
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private int GetTotalBet()
        {
            int total = 0;

            int.TryParse(txtTiger.Text, out int t1);
            int.TryParse(txtPot.Text, out int t2);
            int.TryParse(txtRooster.Text, out int t3);
            int.TryParse(txtShrimp.Text, out int t4);
            int.TryParse(txtCrab.Text, out int t5);
            int.TryParse(txtFish.Text, out int t6);

            total = t1 + t2 + t3 + t4 + t5 + t6;

            return total;
        }


        private void button13_Click(object sender, EventArgs e)
        {

            if (!isPlaying)   
            {
                if (GetTotalBet() == 0)
                {
                    MessageBox.Show("Please place a bet first!");
                    return;
                }

                isPlaying = true;
                btnplay.Text = "Stop";
                timer1.Start();

                

            }
            else   
            {
                isPlaying = false;
                btnplay.Text = "Play";
                timer1.Stop();

                

                Calculate();
            }

        }

        


        private void timer1_Tick(object sender, EventArgs e)
        {
            r1 = ran.Next(6);
            r2 = ran.Next(6);
            r3 = ran.Next(6);

            picResult1.Image = imageList1.Images[r1];
            picResult2.Image = imageList1.Images[r2];
            picResult3.Image = imageList1.Images[r3];
        }

        

        private void ClearBet()
        {
            money1 = money2 = money3 = money4 = money5 = money6 = 0;

            txtTiger.Text = "0";
            txtPot.Text = "0";
            txtRooster.Text = "0";
            txtShrimp.Text = "0";
            txtCrab.Text = "0";
            txtFish.Text = "0";

            picResult1.Image = null;
            picResult2.Image = null;
            picResult3.Image = null;

        }

        
        

    }

}
