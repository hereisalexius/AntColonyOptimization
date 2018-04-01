namespace AntColonyOptimization.Visual.Graphs
{
    partial class GraphEditControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exportLengthstButton = new System.Windows.Forms.Button();
            this.importLengthstButton = new System.Windows.Forms.Button();
            this.distanceLengthView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportPheromonetButton = new System.Windows.Forms.Button();
            this.importPheromonetButton = new System.Windows.Forms.Button();
            this.distancePheromoneView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nodeUpDown = new System.Windows.Forms.NumericUpDown();
            this.graphView1 = new AntColonyOptimization.Visual.Graphs.GraphView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceLengthView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distancePheromoneView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exportLengthstButton);
            this.groupBox1.Controls.Add(this.importLengthstButton);
            this.groupBox1.Controls.Add(this.distanceLengthView);
            this.groupBox1.Location = new System.Drawing.Point(420, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lengths";
            // 
            // exportLengthstButton
            // 
            this.exportLengthstButton.Location = new System.Drawing.Point(87, 183);
            this.exportLengthstButton.Name = "exportLengthstButton";
            this.exportLengthstButton.Size = new System.Drawing.Size(75, 23);
            this.exportLengthstButton.TabIndex = 2;
            this.exportLengthstButton.Text = "Export";
            this.exportLengthstButton.UseVisualStyleBackColor = true;
            this.exportLengthstButton.Click += new System.EventHandler(this.exportLengthstButton_Click);
            // 
            // importLengthstButton
            // 
            this.importLengthstButton.Location = new System.Drawing.Point(6, 183);
            this.importLengthstButton.Name = "importLengthstButton";
            this.importLengthstButton.Size = new System.Drawing.Size(75, 23);
            this.importLengthstButton.TabIndex = 1;
            this.importLengthstButton.Text = "Import";
            this.importLengthstButton.UseVisualStyleBackColor = true;
            this.importLengthstButton.Click += new System.EventHandler(this.importLengthstButton_Click);
            // 
            // distanceLengthView
            // 
            this.distanceLengthView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.distanceLengthView.Location = new System.Drawing.Point(6, 19);
            this.distanceLengthView.Name = "distanceLengthView";
            this.distanceLengthView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.distanceLengthView.Size = new System.Drawing.Size(388, 158);
            this.distanceLengthView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exportPheromonetButton);
            this.groupBox2.Controls.Add(this.importPheromonetButton);
            this.groupBox2.Controls.Add(this.distancePheromoneView);
            this.groupBox2.Location = new System.Drawing.Point(420, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 209);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pheromone";
            // 
            // exportPheromonetButton
            // 
            this.exportPheromonetButton.Location = new System.Drawing.Point(87, 180);
            this.exportPheromonetButton.Name = "exportPheromonetButton";
            this.exportPheromonetButton.Size = new System.Drawing.Size(75, 23);
            this.exportPheromonetButton.TabIndex = 2;
            this.exportPheromonetButton.Text = "Export";
            this.exportPheromonetButton.UseVisualStyleBackColor = true;
            this.exportPheromonetButton.Click += new System.EventHandler(this.exportPheromonetButton_Click);
            // 
            // importPheromonetButton
            // 
            this.importPheromonetButton.Location = new System.Drawing.Point(6, 180);
            this.importPheromonetButton.Name = "importPheromonetButton";
            this.importPheromonetButton.Size = new System.Drawing.Size(75, 23);
            this.importPheromonetButton.TabIndex = 1;
            this.importPheromonetButton.Text = "Import";
            this.importPheromonetButton.UseVisualStyleBackColor = true;
            this.importPheromonetButton.Click += new System.EventHandler(this.importPheromonetButton_Click);
            // 
            // distancePheromoneView
            // 
            this.distancePheromoneView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.distancePheromoneView.Location = new System.Drawing.Point(6, 19);
            this.distancePheromoneView.Name = "distancePheromoneView";
            this.distancePheromoneView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.distancePheromoneView.Size = new System.Drawing.Size(388, 155);
            this.distancePheromoneView.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(10, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(91, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Node sise(view) : ";
            // 
            // nodeUpDown
            // 
            this.nodeUpDown.Location = new System.Drawing.Point(263, 6);
            this.nodeUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nodeUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nodeUpDown.Name = "nodeUpDown";
            this.nodeUpDown.Size = new System.Drawing.Size(51, 20);
            this.nodeUpDown.TabIndex = 9;
            this.nodeUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // graphView1
            // 
            this.graphView1.BackColor = System.Drawing.Color.White;
            this.graphView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphView1.Location = new System.Drawing.Point(10, 35);
            this.graphView1.Margin = new System.Windows.Forms.Padding(10);
            this.graphView1.Name = "graphView1";
            this.graphView1.Size = new System.Drawing.Size(400, 400);
            this.graphView1.TabIndex = 0;
            // 
            // GraphEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nodeUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphView1);
            this.Name = "GraphEditControl";
            this.Size = new System.Drawing.Size(830, 445);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distanceLengthView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distancePheromoneView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GraphView graphView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView distanceLengthView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nodeUpDown;
        private System.Windows.Forms.DataGridView distancePheromoneView;
        private System.Windows.Forms.Button exportLengthstButton;
        private System.Windows.Forms.Button importLengthstButton;
        private System.Windows.Forms.Button exportPheromonetButton;
        private System.Windows.Forms.Button importPheromonetButton;
    }
}
