using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DS
{
    public partial class UI : Form
    {
        private TicTacToe game;
        private int result;

        public UI()
        {
            InitializeComponent();
        }

        public UI(TicTacToe ttt): base()
        {
            game = ttt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('a');
        }

        private void UI_Load(object sender, EventArgs e)
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            label7.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            cmdStart.Enabled = true;
            
        }
        private void cmdStart_Click(object sender, EventArgs e)
        {
            result = 0;
            int firstPlayer;
            if(optHuman.Checked == true)
                firstPlayer = 0;
            else
                firstPlayer = 1;
            game = new TicTacToe(this,3, firstPlayer);
            new System.Threading.Thread(new System.Threading.ThreadStart(game.Play)).Start();
            timer1.Enabled = true;
            cmdStart.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('b');
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('c');
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('d');
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('e');
        }

        private void label6_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('f');
        }

        private void label7_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('g');
        }

        private void label8_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('h');
        }

        private void label9_Click(object sender, EventArgs e)
        {
            HumanPlayer hp = (HumanPlayer)game.GetHumanPlayer();
            hp.SetMove('i');
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[][] board = game.GetBoard();
            if (board[0][0] != 0)
            {
                label1.Text = board[0][0]==1?"X":"0";
            }
            if (board[0][1] != 0)
            {
                label2.Text = board[0][1]==1?"X":"0";
            }
            if (board[0][2] != 0)
            {
                label3.Text = board[0][2]==1?"X":"0";
            }
            if (board[1][0] != 0)
            {
                label4.Text = board[1][0]==1?"X":"0";
            }
            if (board[1][1] != 0)
            {
                label5.Text = board[1][1]==1?"X":"0";
            }
            if (board[1][2] != 0)
            {
                label6.Text = board[1][2]==1?"X":"0";
            }
            if (board[2][0] != 0)
            {
                label7.Text = board[2][0]==1?"X":"0";
            }
            if (board[2][1] != 0)
            {
                label8.Text = board[2][1]==1?"X":"0";
            }
            if (board[2][2] != 0)
            {
                label9.Text = board[2][2]==1?"X":"0";
            }
        }
        public void setResult(int res)
        {
            result = res;
            if (result == 1)
                MessageBox.Show("Player 1 wins");
            else if (result == 2)
                MessageBox.Show("Player 2 wins");
            /*DialogResult dr = MessageBox.Show("Play Again ?","Game over", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                InitializeBoard();
            }*/
        }
    }
}
