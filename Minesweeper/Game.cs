using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Minesweeper
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        int[,] mineLocations;
        int squares;

        public void StartGame(int n, int mines)
        {
            mineFieldGrid.RowCount = n;
            mineFieldGrid.ColumnCount = n;
            squares = (n * n) - mines;
            for (int i = 0; i < n; i++)
            {
                mineFieldGrid.Columns[i].Width = 35;
                mineFieldGrid.Rows[i].Height = 35;
            }
            mineFieldGrid.Height = n * 35 + 3;
            mineFieldGrid.Width = n * 35 + 3;
            this.Height = mineFieldGrid.Height + 60;
            this.Width = mineFieldGrid.Width + 14;
            mineLocations = generateMines(n, mines);
            this.Show();
            lblSq.Text = $"Remaining squares: {squares}";
            lblMines.Text = $"Mines: {mines}";
            WinCheck(squares);
        }

        private int[,] generateMines(int gridsize, int mines)
        {
            Random r1 = new Random();
            int[,] mineLocations = new int[mines, 2];
            for (int i = 0; i < mines; i++)
            {
                mineLocations[i, 0] = r1.Next(0, gridsize);
                mineLocations[i, 1] = r1.Next(0, gridsize);
                for (int j = 0; j < i; j++)
                {
                    if (mineLocations[j, 0] == mineLocations[i, 0] && mineLocations[j, 1] == mineLocations[i, 1])
                        i--;
                }
            }
            return mineLocations;
        }

        private int getMineCountAround(int x, int y, int[,] mineLocations)
        {
            int count = 0;
            if (x - 1 >= 0)
                if (isAMine(x - 1, y, mineLocations))
                    count++;
            if (x + 1 < mineFieldGrid.RowCount)
                if (isAMine(x + 1, y, mineLocations))
                    count++;
            if (y - 1 >= 0)
                if (isAMine(x, y - 1, mineLocations))
                    count++;
            if (y + 1 < mineFieldGrid.RowCount)
                if (isAMine(x, y + 1, mineLocations))
                    count++;
            return count;
        }

        private bool isAMine(int x, int y, int[,] mineLocations)
        {
            for (int i = 0; i < mineLocations.GetLength(0); i++)
            {
                if (mineLocations[i, 0] == x && mineLocations[i, 1] == y)
                    return true;
            }
            return false;
        }

        private bool isRevealed(int x, int y)
        {
            if (mineFieldGrid[x, y].Style.BackColor == Color.Green)
                return true;
            else
                return false;
        }

        private void WinCheck(int remainingSquares)
        {
            if (remainingSquares == 0)
            {
                for (int i = 0; i < mineLocations.GetLength(0); i++)
                {
                    mineFieldGrid[mineLocations[i, 0], mineLocations[i, 1]].Style.BackColor = Color.Red;
                }
                MessageBox.Show("There are no remaining squares, you've won!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void mineFieldGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.mineFieldGrid.ClearSelection();
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                mineFieldGrid[x, y].Style.BackColor = Color.Orange;
            }
            else
            {
                if (isAMine(x, y, mineLocations))
                {
                    for (int i = 0; i < mineLocations.GetLength(0); i++)
                    {
                        mineFieldGrid[mineLocations[i, 0], mineLocations[i, 1]].Style.BackColor = Color.Red;
                    }
                    MessageBox.Show("You've ran into a mine, good luck next time!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    ShowEmptySquaresAround(x, y);
                    lblSq.Text = $"Remaining squares: {squares}";
                    WinCheck(squares);
                }
            }
        }

        private void ShowEmptySquaresAround(int x, int y)
        {
            squares--;
            mineFieldGrid[x, y].Value = getMineCountAround(x, y, mineLocations).ToString();
            mineFieldGrid[x, y].Style.BackColor = Color.Green;
            if (x - 1 >= 0)
                if (!(isAMine(x - 1, y, mineLocations) || isRevealed(x -1,y)))
                    ShowEmptySquaresAround(x - 1, y);
            if (x + 1 < mineFieldGrid.RowCount)
                if (!(isAMine(x + 1, y, mineLocations) || isRevealed(x + 1, y)))
                    ShowEmptySquaresAround(x + 1, y);
            if (y - 1 >= 0)
                if (!(isAMine(x, y - 1, mineLocations) || isRevealed(x, y -1)))
                    ShowEmptySquaresAround(x, y - 1);
            if (y + 1 < mineFieldGrid.ColumnCount)
                if (!(isAMine(x, y + 1, mineLocations) || isRevealed(x, y + 1)))
                    ShowEmptySquaresAround(x, y + 1);
        }
    }
}
