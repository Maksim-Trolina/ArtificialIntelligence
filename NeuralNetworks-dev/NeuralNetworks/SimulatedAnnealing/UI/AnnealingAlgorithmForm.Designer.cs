using System.Windows.Forms;

namespace NeuralNetworks.SimulatedAnnealing.UI
{
    partial class AnnealingAlgorithmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.maxTemperatureNumeric = new System.Windows.Forms.NumericUpDown();
            this.minTemperatureNumeric = new System.Windows.Forms.NumericUpDown();
            this.cRatioNumeric = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.maxRandomNumeric = new System.Windows.Forms.NumericUpDown();
            this.isSimmetricCheckBox = new System.Windows.Forms.CheckBox();
            this.randomWeightsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.countVertex = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sumWeightLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.shortestPathLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxTemperatureNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTemperatureNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRatioNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).BeginInit();
            this.SuspendLayout();
            // 
            // maxTemperatureNumeric
            // 
            this.maxTemperatureNumeric.Location = new System.Drawing.Point(229, 223);
            this.maxTemperatureNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxTemperatureNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxTemperatureNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxTemperatureNumeric.Name = "maxTemperatureNumeric";
            this.maxTemperatureNumeric.Size = new System.Drawing.Size(58, 20);
            this.maxTemperatureNumeric.TabIndex = 0;
            this.maxTemperatureNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTemperatureNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxTemperatureNumeric.ValueChanged += new System.EventHandler(this.maxTemperatureNumeric_ValueChanged);
            // 
            // minTemperatureNumeric
            // 
            this.minTemperatureNumeric.Location = new System.Drawing.Point(231, 151);
            this.minTemperatureNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minTemperatureNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minTemperatureNumeric.Name = "minTemperatureNumeric";
            this.minTemperatureNumeric.Size = new System.Drawing.Size(56, 20);
            this.minTemperatureNumeric.TabIndex = 1;
            this.minTemperatureNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minTemperatureNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cRatioNumeric
            // 
            this.cRatioNumeric.Location = new System.Drawing.Point(231, 188);
            this.cRatioNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cRatioNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cRatioNumeric.Name = "cRatioNumeric";
            this.cRatioNumeric.Size = new System.Drawing.Size(56, 20);
            this.cRatioNumeric.TabIndex = 2;
            this.cRatioNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cRatioNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 258);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(281, 24);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixGridView.Location = new System.Drawing.Point(321, 7);
            this.matrixGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.matrixGridView.MultiSelect = false;
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersWidth = 51;
            this.matrixGridView.RowTemplate.Height = 29;
            this.matrixGridView.Size = new System.Drawing.Size(309, 212);
            this.matrixGridView.TabIndex = 17;
            this.matrixGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrixGridView_CellValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Максимальный вес";
            // 
            // maxRandomNumeric
            // 
            this.maxRandomNumeric.Location = new System.Drawing.Point(231, 7);
            this.maxRandomNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxRandomNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxRandomNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxRandomNumeric.Name = "maxRandomNumeric";
            this.maxRandomNumeric.Size = new System.Drawing.Size(56, 20);
            this.maxRandomNumeric.TabIndex = 24;
            this.maxRandomNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxRandomNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxRandomNumeric.ValueChanged += new System.EventHandler(this.maxRandomNumeric_ValueChanged);
            // 
            // isSimmetricCheckBox
            // 
            this.isSimmetricCheckBox.AutoSize = true;
            this.isSimmetricCheckBox.Location = new System.Drawing.Point(231, 41);
            this.isSimmetricCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isSimmetricCheckBox.Name = "isSimmetricCheckBox";
            this.isSimmetricCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isSimmetricCheckBox.TabIndex = 23;
            this.isSimmetricCheckBox.UseVisualStyleBackColor = true;
            this.isSimmetricCheckBox.CheckedChanged += new System.EventHandler(this.isSimmetricCheckBox_CheckedChanged);
            // 
            // randomWeightsButton
            // 
            this.randomWeightsButton.Location = new System.Drawing.Point(6, 107);
            this.randomWeightsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomWeightsButton.Name = "randomWeightsButton";
            this.randomWeightsButton.Size = new System.Drawing.Size(281, 26);
            this.randomWeightsButton.TabIndex = 22;
            this.randomWeightsButton.Text = "Сгенерировать матрицу";
            this.randomWeightsButton.UseVisualStyleBackColor = true;
            this.randomWeightsButton.Click += new System.EventHandler(this.randomWeightsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Количество вершин";
            // 
            // countVertex
            // 
            this.countVertex.Location = new System.Drawing.Point(229, 65);
            this.countVertex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countVertex.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countVertex.Name = "countVertex";
            this.countVertex.Size = new System.Drawing.Size(56, 20);
            this.countVertex.TabIndex = 20;
            this.countVertex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countVertex.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.countVertex.ValueChanged += new System.EventHandler(this.countVertex_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Макс. температура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Мин. температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Коеффициент C";
            // 
            // sumWeightLabel
            // 
            this.sumWeightLabel.AutoSize = true;
            this.sumWeightLabel.Location = new System.Drawing.Point(494, 268);
            this.sumWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sumWeightLabel.Name = "sumWeightLabel";
            this.sumWeightLabel.Size = new System.Drawing.Size(41, 13);
            this.sumWeightLabel.TabIndex = 35;
            this.sumWeightLabel.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 268);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Суммарный вес цикла: ";
            // 
            // shortestPathLabel
            // 
            this.shortestPathLabel.AutoSize = true;
            this.shortestPathLabel.Location = new System.Drawing.Point(494, 240);
            this.shortestPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shortestPathLabel.Name = "shortestPathLabel";
            this.shortestPathLabel.Size = new System.Drawing.Size(41, 13);
            this.shortestPathLabel.TabIndex = 33;
            this.shortestPathLabel.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 240);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Кратчайший Гамильтонов цикл: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Симметричность";
            // 
            // AnnealingAlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumWeightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.shortestPathLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxRandomNumeric);
            this.Controls.Add(this.isSimmetricCheckBox);
            this.Controls.Add(this.randomWeightsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countVertex);
            this.Controls.Add(this.matrixGridView);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cRatioNumeric);
            this.Controls.Add(this.minTemperatureNumeric);
            this.Controls.Add(this.maxTemperatureNumeric);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnnealingAlgorithmForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnnealingAlgorithmForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxTemperatureNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTemperatureNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRatioNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRandomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countVertex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.NumericUpDown maxTemperatureNumeric;
        private System.Windows.Forms.NumericUpDown minTemperatureNumeric;
        private System.Windows.Forms.NumericUpDown cRatioNumeric;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView matrixGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxRandomNumeric;
        private System.Windows.Forms.CheckBox isSimmetricCheckBox;
        private System.Windows.Forms.Button randomWeightsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown countVertex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sumWeightLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label shortestPathLabel;
        private System.Windows.Forms.Label label11;
    }
}