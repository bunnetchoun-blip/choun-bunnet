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
    public partial class Form2 : Form

    
    {
        public Form2(int yourCoin, int winCoin)
        {
            InitializeComponent();

            txtwinCoin.Text = winCoin + "R";
            txtYourCoin.Text = yourCoin + "R";
            txtTotalCoin.Text = (yourCoin + winCoin) + "R";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtwinCoin_Click(object sender, EventArgs e)
        {

        }

        private void txtYourCoin_Click(object sender, EventArgs e)
        {

        }
    }
}
