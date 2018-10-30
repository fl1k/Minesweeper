using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumUpDownMines_ValueChanged(object sender, EventArgs e)
        {
            if(NumUpDownGridSize.Value * NumUpDownGridSize.Value < NumUpDownMines.Value)
            {
                MessageBox.Show("Can't have more mines than blocks.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumUpDownMines.Value = NumUpDownGridSize.Value * NumUpDownGridSize.Value;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.StartGame((int)NumUpDownGridSize.Value,(int)NumUpDownMines.Value);
        }
    }
}
