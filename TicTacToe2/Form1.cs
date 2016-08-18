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
            String[] turnsXO = new string[] { "X", "O", "X", "O", "X", "O", "X", "O", "X" }; //an array to hold the turns
        String ballPointXOPlacer = "";
    }


    private void btn1_Click(object sender, EventArgs e)
    {


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
}
}
