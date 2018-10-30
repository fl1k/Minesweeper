namespace Minesweeper
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mineFieldGrid = new System.Windows.Forms.DataGridView();
            this.lblSq = new System.Windows.Forms.Label();
            this.lblMines = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mineFieldGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mineFieldGrid
            // 
            this.mineFieldGrid.AllowUserToAddRows = false;
            this.mineFieldGrid.AllowUserToDeleteRows = false;
            this.mineFieldGrid.AllowUserToOrderColumns = true;
            this.mineFieldGrid.AllowUserToResizeColumns = false;
            this.mineFieldGrid.AllowUserToResizeRows = false;
            this.mineFieldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mineFieldGrid.ColumnHeadersVisible = false;
            this.mineFieldGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.mineFieldGrid.Location = new System.Drawing.Point(-1, 24);
            this.mineFieldGrid.Name = "mineFieldGrid";
            this.mineFieldGrid.ReadOnly = true;
            this.mineFieldGrid.RowHeadersVisible = false;
            this.mineFieldGrid.Size = new System.Drawing.Size(25, 25);
            this.mineFieldGrid.TabIndex = 0;
            this.mineFieldGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mineFieldGrid_CellClick);
            // 
            // lblSq
            // 
            this.lblSq.AutoSize = true;
            this.lblSq.Location = new System.Drawing.Point(6, 4);
            this.lblSq.Name = "lblSq";
            this.lblSq.Size = new System.Drawing.Size(103, 13);
            this.lblSq.TabIndex = 1;
            this.lblSq.Text = "Remaining squares: ";
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.Location = new System.Drawing.Point(178, 4);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(38, 13);
            this.lblMines.TabIndex = 2;
            this.lblMines.Text = "Mines:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMines);
            this.Controls.Add(this.lblSq);
            this.Controls.Add(this.mineFieldGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Game";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.mineFieldGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mineFieldGrid;
        private System.Windows.Forms.Label lblSq;
        private System.Windows.Forms.Label lblMines;
    }
}