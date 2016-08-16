using System;
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
        }
    }
}
