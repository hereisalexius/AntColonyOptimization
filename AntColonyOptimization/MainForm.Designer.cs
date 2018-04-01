namespace AntColonyOptimization
{
    partial class MainForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.iterSwitch = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.lengthsText = new System.Windows.Forms.TextBox();
            this.pathText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.acoPropertiesControl1 = new AntColonyOptimization.Visual.Controls.ACOPropertiesControl();
            this.graphEditControl1 = new AntColonyOptimization.Visual.Graphs.GraphEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.iterSwitch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 179);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Run";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // iterSwitch
            // 
            this.iterSwitch.Location = new System.Drawing.Point(63, 239);
            this.iterSwitch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterSwitch.Name = "iterSwitch";
            this.iterSwitch.ReadOnly = true;
            this.iterSwitch.Size = new System.Drawing.Size(90, 20);
            this.iterSwitch.TabIndex = 3;
            this.iterSwitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iteration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lengthText);
            this.groupBox1.Controls.Add(this.lengthsText);
            this.groupBox1.Controls.Add(this.pathText);
            this.groupBox1.Location = new System.Drawing.Point(13, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lengths order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cities order";
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(6, 122);
            this.lengthText.Name = "lengthText";
            this.lengthText.ReadOnly = true;
            this.lengthText.Size = new System.Drawing.Size(128, 20);
            this.lengthText.TabIndex = 2;
            // 
            // lengthsText
            // 
            this.lengthsText.Location = new System.Drawing.Point(6, 83);
            this.lengthsText.Name = "lengthsText";
            this.lengthsText.ReadOnly = true;
            this.lengthsText.Size = new System.Drawing.Size(128, 20);
            this.lengthsText.TabIndex = 1;
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(6, 44);
            this.pathText.Name = "pathText";
            this.pathText.ReadOnly = true;
            this.pathText.Size = new System.Drawing.Size(128, 20);
            this.pathText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acoPropertiesControl1
            // 
            this.acoPropertiesControl1.Location = new System.Drawing.Point(3, 12);
            this.acoPropertiesControl1.Name = "acoPropertiesControl1";
            this.acoPropertiesControl1.Size = new System.Drawing.Size(150, 161);
            this.acoPropertiesControl1.TabIndex = 1;
            // 
            // graphEditControl1
            // 
            this.graphEditControl1.Location = new System.Drawing.Point(159, 12);
            this.graphEditControl1.Name = "graphEditControl1";
            this.graphEditControl1.Size = new System.Drawing.Size(830, 445);
            this.graphEditControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iterSwitch);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.acoPropertiesControl1);
            this.Controls.Add(this.graphEditControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ant Colony Optimization";
            ((System.ComponentModel.ISupportInitialize)(this.iterSwitch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Visual.Graphs.GraphEditControl graphEditControl1;
        private Visual.Controls.ACOPropertiesControl acoPropertiesControl1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown iterSwitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.TextBox lengthsText;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button button1;
    }
}

