using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class TTTGameBoard : Form
    {
        //placing variables out here will make it visable to the entire class.
        private bool isXturn = true;
        string[] moves = new string[9]; //this will hold the moves  
        public TTTGameBoard()
        {
            InitializeComponent();
        }

        private void TTTGameBoard_Load(object sender, EventArgs e)
        {
            //main game board - here the application will call the methods needed to run.
            // crate an array to hold the turns and were the "pinpoint" will draw off of.
            //upon further investigation it turns out that I cannot make a constant array.  Complication - The array should be editable
            //so that I can remove an item from the list as needed.
            string[] turnsXO = new string[] { "X", "O", "X", "O", "X", "O", "X", "O", "X" }; //an array to hold the turns
            
            string ballPointXOPlacer = "";
            

        }

        private void userClick(int squareNum)
        {

            if (isXturn == true)
            {
                moves[squareNum - 1] = "x";
            }
            else moves[squareNum -1] = "O";
            
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //close the program once this is clicked.
            Close();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //when this button is pressed it will reset the game entirely.  If there is a running tracker it'll need to wipe that too.
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            String[] turnsXO = new string[9] { "X", "O", "X", "O", "X", "O", "X", "O", "X" }; //refill the array
                                                                                              // Note - Will need something more complicated when the turns will proceed forward for.  Switching the string to O starting.
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display basic information for the user to view.
            MessageBox.Show("By Shawn Wolf", "Tic Tac Toe About");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //additional means to handle closing the application.
            Application.Exit();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            userClick(1);

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            userClick(1);
        }
    }
}
