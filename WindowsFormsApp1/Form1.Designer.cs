namespace WindowsFormsApp1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sideA = new System.Windows.Forms.NumericUpDown();
            this.sideB = new System.Windows.Forms.NumericUpDown();
            this.sideC = new System.Windows.Forms.NumericUpDown();
            this.results = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideC)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sideA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sideB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sideC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.results, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Side c length: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side b length: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "Side a length: ";
            // 
            // sideA
            // 
            this.sideA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideA.Location = new System.Drawing.Point(122, 3);
            this.sideA.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sideA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(195, 26);
            this.sideA.TabIndex = 4;
            this.sideA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sideA_ValueChanged);
            // 
            // sideB
            // 
            this.sideB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideB.Location = new System.Drawing.Point(122, 103);
            this.sideB.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sideB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(195, 26);
            this.sideB.TabIndex = 5;
            this.sideB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sideB_ValueChanged);
            // 
            // sideC
            // 
            this.sideC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideC.Location = new System.Drawing.Point(122, 203);
            this.sideC.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.sideC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(195, 26);
            this.sideC.TabIndex = 6;
            this.sideC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sideC_ValueChanged);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results.Location = new System.Drawing.Point(323, 300);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(474, 150);
            this.results.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "TriangleClassifier";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sideA;
        private System.Windows.Forms.NumericUpDown sideB;
        private System.Windows.Forms.NumericUpDown sideC;
        private System.Windows.Forms.Label results;
    }
}

