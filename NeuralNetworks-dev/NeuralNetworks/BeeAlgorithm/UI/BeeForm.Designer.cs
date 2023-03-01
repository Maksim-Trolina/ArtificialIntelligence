using System.Windows.Forms;

namespace NeuralNetworks.BeeAlgorithm.UI
{
    partial class BeeForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.countScoutBeesNumeric = new System.Windows.Forms.NumericUpDown();
            this.countEliteBeesNumeric = new System.Windows.Forms.NumericUpDown();
            this.countDefaultBeesNumeric = new System.Windows.Forms.NumericUpDown();
            this.deltaNumeric = new System.Windows.Forms.NumericUpDown();
            this.countIterationsNumeric = new System.Windows.Forms.NumericUpDown();
            this.countLocalSearchNumeric = new System.Windows.Forms.NumericUpDown();
            this.countElitePointsNumeric = new System.Windows.Forms.NumericUpDown();
            this.upperBoundNumeric = new System.Windows.Forms.NumericUpDown();
            this.lowerBoundNumeric = new System.Windows.Forms.NumericUpDown();
            this.functionsComboBox = new System.Windows.Forms.ComboBox();
            this.functionsLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countScoutBeesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEliteBeesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDefaultBeesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLocalSearchNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countElitePointsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(11, 206);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(820, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // countScoutBeesNumeric
            // 
            this.countScoutBeesNumeric.Location = new System.Drawing.Point(746, 44);
            this.countScoutBeesNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countScoutBeesNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.countScoutBeesNumeric.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            this.countScoutBeesNumeric.Name = "countScoutBeesNumeric";
            this.countScoutBeesNumeric.Size = new System.Drawing.Size(85, 22);
            this.countScoutBeesNumeric.TabIndex = 7;
            this.countScoutBeesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countScoutBeesNumeric.Value = new decimal(new int[] { 300, 0, 0, 0 });
            this.countScoutBeesNumeric.ValueChanged += new System.EventHandler(this.countScoutBeesNumeric_ValueChanged);
            // 
            // countEliteBeesNumeric
            // 
            this.countEliteBeesNumeric.Location = new System.Drawing.Point(746, 9);
            this.countEliteBeesNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countEliteBeesNumeric.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.countEliteBeesNumeric.Name = "countEliteBeesNumeric";
            this.countEliteBeesNumeric.Size = new System.Drawing.Size(85, 22);
            this.countEliteBeesNumeric.TabIndex = 8;
            this.countEliteBeesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countEliteBeesNumeric.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // countDefaultBeesNumeric
            // 
            this.countDefaultBeesNumeric.Location = new System.Drawing.Point(746, 81);
            this.countDefaultBeesNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countDefaultBeesNumeric.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.countDefaultBeesNumeric.Name = "countDefaultBeesNumeric";
            this.countDefaultBeesNumeric.Size = new System.Drawing.Size(85, 22);
            this.countDefaultBeesNumeric.TabIndex = 9;
            this.countDefaultBeesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countDefaultBeesNumeric.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // deltaNumeric
            // 
            this.deltaNumeric.DecimalPlaces = 1;
            this.deltaNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.deltaNumeric.Location = new System.Drawing.Point(303, 44);
            this.deltaNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deltaNumeric.Name = "deltaNumeric";
            this.deltaNumeric.Size = new System.Drawing.Size(85, 22);
            this.deltaNumeric.TabIndex = 10;
            this.deltaNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deltaNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // countIterationsNumeric
            // 
            this.countIterationsNumeric.Location = new System.Drawing.Point(303, 117);
            this.countIterationsNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countIterationsNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.countIterationsNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.countIterationsNumeric.Name = "countIterationsNumeric";
            this.countIterationsNumeric.Size = new System.Drawing.Size(85, 22);
            this.countIterationsNumeric.TabIndex = 11;
            this.countIterationsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countIterationsNumeric.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // countLocalSearchNumeric
            // 
            this.countLocalSearchNumeric.Location = new System.Drawing.Point(303, 9);
            this.countLocalSearchNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countLocalSearchNumeric.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.countLocalSearchNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.countLocalSearchNumeric.Name = "countLocalSearchNumeric";
            this.countLocalSearchNumeric.Size = new System.Drawing.Size(85, 22);
            this.countLocalSearchNumeric.TabIndex = 12;
            this.countLocalSearchNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countLocalSearchNumeric.Value = new decimal(new int[] { 80, 0, 0, 0 });
            this.countLocalSearchNumeric.ValueChanged += new System.EventHandler(this.countLocalSearchNumeric_ValueChanged);
            // 
            // countElitePointsNumeric
            // 
            this.countElitePointsNumeric.Location = new System.Drawing.Point(303, 81);
            this.countElitePointsNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countElitePointsNumeric.Name = "countElitePointsNumeric";
            this.countElitePointsNumeric.Size = new System.Drawing.Size(85, 22);
            this.countElitePointsNumeric.TabIndex = 13;
            this.countElitePointsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countElitePointsNumeric.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // upperBoundNumeric
            // 
            this.upperBoundNumeric.Location = new System.Drawing.Point(486, 44);
            this.upperBoundNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upperBoundNumeric.Name = "upperBoundNumeric";
            this.upperBoundNumeric.Size = new System.Drawing.Size(85, 22);
            this.upperBoundNumeric.TabIndex = 1;
            this.upperBoundNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upperBoundNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.upperBoundNumeric.ValueChanged += new System.EventHandler(this.upperBoundNumeric_ValueChanged);
            // 
            // lowerBoundNumeric
            // 
            this.lowerBoundNumeric.Location = new System.Drawing.Point(486, 81);
            this.lowerBoundNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowerBoundNumeric.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this.lowerBoundNumeric.Name = "lowerBoundNumeric";
            this.lowerBoundNumeric.Size = new System.Drawing.Size(85, 22);
            this.lowerBoundNumeric.TabIndex = 0;
            this.lowerBoundNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowerBoundNumeric.Value = new decimal(new int[] { 10, 0, 0, -2147483648 });
            this.lowerBoundNumeric.ValueChanged += new System.EventHandler(this.lowerBoundNumeric_ValueChanged);
            // 
            // functionsComboBox
            // 
            this.functionsComboBox.FormattingEnabled = true;
            this.functionsComboBox.Items.AddRange(new object[] { "f(x1,x2) = x1^2 +3*x2^2 + 2*x1*x2", "f(x1,x2) = 100*(x2-x1^2)^2 + (1-x1)^2", "f(x1,x2) = -12*x2 + 4*x1^2 + 4*x2^2 - 4*x1*x2", "f(x1,x2) = x1^3 + x2^2 - 3*x2 -2*x2 + 2" });
            this.functionsComboBox.Location = new System.Drawing.Point(94, 160);
            this.functionsComboBox.Name = "functionsComboBox";
            this.functionsComboBox.Size = new System.Drawing.Size(738, 24);
            this.functionsComboBox.TabIndex = 24;
            // 
            // functionsLabel
            // 
            this.functionsLabel.AutoSize = true;
            this.functionsLabel.Location = new System.Drawing.Point(11, 160);
            this.functionsLabel.Name = "functionsLabel";
            this.functionsLabel.Size = new System.Drawing.Size(76, 17);
            this.functionsLabel.TabIndex = 4;
            this.functionsLabel.Text = "Функции -";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(285, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "Количество точек локального поиска    -";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Окрестность точки                                   -";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 26);
            this.label12.TabIndex = 28;
            this.label12.Text = "Количество точек для элитных пчёл      -";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(452, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Границы:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(403, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 26);
            this.label13.TabIndex = 30;
            this.label13.Text = "Верхняя - ";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(403, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 26);
            this.label14.TabIndex = 31;
            this.label14.Text = "Нижняя  -";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(587, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Элитные пчёлы       -";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(587, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 26);
            this.label9.TabIndex = 33;
            this.label9.Text = "Пчёлы-разведчики  -";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(587, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 26);
            this.label15.TabIndex = 34;
            this.label15.Text = "Пчёлы-работяги      -";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Количество итераций                              -";
            // 
            // BeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.countScoutBeesNumeric);
            this.Controls.Add(this.countDefaultBeesNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.countEliteBeesNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lowerBoundNumeric);
            this.Controls.Add(this.upperBoundNumeric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.countElitePointsNumeric);
            this.Controls.Add(this.countLocalSearchNumeric);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deltaNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.functionsComboBox);
            this.Controls.Add(this.countIterationsNumeric);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.functionsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BeeForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeeForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countScoutBeesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countEliteBeesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countDefaultBeesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countIterationsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLocalSearchNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countElitePointsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label15;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.ComboBox functionsComboBox;

        #endregion

        private System.Windows.Forms.Label functionsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown countScoutBeesNumeric;
        private System.Windows.Forms.NumericUpDown countEliteBeesNumeric;
        private System.Windows.Forms.NumericUpDown countDefaultBeesNumeric;
        private System.Windows.Forms.NumericUpDown deltaNumeric;
        private System.Windows.Forms.NumericUpDown countIterationsNumeric;
        private System.Windows.Forms.NumericUpDown countLocalSearchNumeric;
        private System.Windows.Forms.NumericUpDown countElitePointsNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown upperBoundNumeric;
        private System.Windows.Forms.NumericUpDown lowerBoundNumeric;
    }
}