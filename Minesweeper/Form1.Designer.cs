namespace Minesweeper
{
    partial class Form1
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
            this.NumUpDownGridSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumUpDownMines = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMines)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUpDownGridSize
            // 
            this.NumUpDownGridSize.Location = new System.Drawing.Point(15, 42);
            this.NumUpDownGridSize.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumUpDownGridSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumUpDownGridSize.Name = "NumUpDownGridSize";
            this.NumUpDownGridSize.Size = new System.Drawing.Size(120, 20);
            this.NumUpDownGridSize.TabIndex = 0;
            this.NumUpDownGridSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount of mines";
            // 
            // NumUpDownMines
            // 
            this.NumUpDownMines.Location = new System.Drawing.Point(15, 81);
            this.NumUpDownMines.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumUpDownMines.Name = "NumUpDownMines";
            this.NumUpDownMines.Size = new System.Drawing.Size(120, 20);
            this.NumUpDownMines.TabIndex = 3;
            this.NumUpDownMines.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumUpDownMines.ValueChanged += new System.EventHandler(this.NumUpDownMines_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 165);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.NumUpDownMines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUpDownGridSize);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUpDownGridSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumUpDownMines;
        private System.Windows.Forms.Button btnStart;
    }
}

