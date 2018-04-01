namespace AntColonyOptimization.Visual.Controls
{
    partial class ACOPropertiesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alphaUpDown = new System.Windows.Forms.NumericUpDown();
            this.betaUpDown = new System.Windows.Forms.NumericUpDown();
            this.rhoUpDown = new System.Windows.Forms.NumericUpDown();
            this.antCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.iterationsUpDown = new System.Windows.Forms.NumericUpDown();
            this.qUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.alphaUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.betaUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rhoUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.antCountUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.iterationsUpDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.qUpDown, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "α";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "β\t";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ρ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ants";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iterations";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Q";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaUpDown
            // 
            this.alphaUpDown.DecimalPlaces = 1;
            this.alphaUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphaUpDown.Location = new System.Drawing.Point(76, 3);
            this.alphaUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alphaUpDown.Name = "alphaUpDown";
            this.alphaUpDown.Size = new System.Drawing.Size(68, 20);
            this.alphaUpDown.TabIndex = 6;
            this.alphaUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betaUpDown
            // 
            this.betaUpDown.DecimalPlaces = 1;
            this.betaUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaUpDown.Location = new System.Drawing.Point(76, 28);
            this.betaUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betaUpDown.Name = "betaUpDown";
            this.betaUpDown.Size = new System.Drawing.Size(68, 20);
            this.betaUpDown.TabIndex = 7;
            this.betaUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rhoUpDown
            // 
            this.rhoUpDown.DecimalPlaces = 1;
            this.rhoUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rhoUpDown.Location = new System.Drawing.Point(76, 53);
            this.rhoUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rhoUpDown.Name = "rhoUpDown";
            this.rhoUpDown.Size = new System.Drawing.Size(68, 20);
            this.rhoUpDown.TabIndex = 8;
            this.rhoUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // antCountUpDown
            // 
            this.antCountUpDown.Location = new System.Drawing.Point(76, 78);
            this.antCountUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.antCountUpDown.Name = "antCountUpDown";
            this.antCountUpDown.Size = new System.Drawing.Size(68, 20);
            this.antCountUpDown.TabIndex = 9;
            this.antCountUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // iterationsUpDown
            // 
            this.iterationsUpDown.Location = new System.Drawing.Point(76, 103);
            this.iterationsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationsUpDown.Name = "iterationsUpDown";
            this.iterationsUpDown.Size = new System.Drawing.Size(68, 20);
            this.iterationsUpDown.TabIndex = 10;
            this.iterationsUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // qUpDown
            // 
            this.qUpDown.Location = new System.Drawing.Point(76, 128);
            this.qUpDown.Name = "qUpDown";
            this.qUpDown.Size = new System.Drawing.Size(68, 20);
            this.qUpDown.TabIndex = 11;
            // 
            // ACOPropertiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ACOPropertiesControl";
            this.Size = new System.Drawing.Size(150, 161);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alphaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown alphaUpDown;
        private System.Windows.Forms.NumericUpDown betaUpDown;
        private System.Windows.Forms.NumericUpDown rhoUpDown;
        private System.Windows.Forms.NumericUpDown antCountUpDown;
        private System.Windows.Forms.NumericUpDown iterationsUpDown;
        private System.Windows.Forms.NumericUpDown qUpDown;
    }
}
