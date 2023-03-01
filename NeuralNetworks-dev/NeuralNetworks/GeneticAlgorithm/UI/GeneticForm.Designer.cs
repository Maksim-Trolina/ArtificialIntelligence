using System.Windows.Forms;

namespace NeuralNetworks.GeneticAlgorithm.UI
{
    partial class GeneticForm
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
            this.functionsLabel = new System.Windows.Forms.Label();
            this.countStartedPopulationNumeric = new System.Windows.Forms.NumericUpDown();
            this.countGenerationNumeric = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.linearCrossing = new System.Windows.Forms.RadioButton();
            this.geometryCrossing = new System.Windows.Forms.RadioButton();
            this.arithmeticCrossing = new System.Windows.Forms.RadioButton();
            this.simplestCrossing = new System.Windows.Forms.RadioButton();
            this.countPointsNumeric = new System.Windows.Forms.NumericUpDown();
            this.binaryPointCrossing = new System.Windows.Forms.RadioButton();
            this.flatCrossing = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.probabilityNumeric = new System.Windows.Forms.NumericUpDown();
            this.binaryRandomMutation = new System.Windows.Forms.RadioButton();
            this.realRandomMutation = new System.Windows.Forms.RadioButton();
            this.outbreedingSelection = new System.Windows.Forms.RadioButton();
            this.inbreedingSelection = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numberSurvivedNumeric = new System.Windows.Forms.NumericUpDown();
            this.tournamentSelection = new System.Windows.Forms.RadioButton();
            this.panmixiaSelection = new System.Windows.Forms.RadioButton();
            this.rankSelection = new System.Windows.Forms.RadioButton();
            this.simpleSelection = new System.Windows.Forms.RadioButton();
            this.functionsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.countStartedPopulationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGenerationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSurvivedNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // functionsLabel
            // 
            this.functionsLabel.AutoSize = true;
            this.functionsLabel.Location = new System.Drawing.Point(10, 234);
            this.functionsLabel.Name = "functionsLabel";
            this.functionsLabel.Size = new System.Drawing.Size(53, 13);
            this.functionsLabel.TabIndex = 1;
            this.functionsLabel.Text = "Функции";
            // 
            // countStartedPopulationNumeric
            // 
            this.countStartedPopulationNumeric.Location = new System.Drawing.Point(349, 193);
            this.countStartedPopulationNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countStartedPopulationNumeric.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.countStartedPopulationNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.countStartedPopulationNumeric.Name = "countStartedPopulationNumeric";
            this.countStartedPopulationNumeric.Size = new System.Drawing.Size(64, 20);
            this.countStartedPopulationNumeric.TabIndex = 3;
            this.countStartedPopulationNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countStartedPopulationNumeric.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // countGenerationNumeric
            // 
            this.countGenerationNumeric.Location = new System.Drawing.Point(123, 193);
            this.countGenerationNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countGenerationNumeric.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.countGenerationNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countGenerationNumeric.Name = "countGenerationNumeric";
            this.countGenerationNumeric.Size = new System.Drawing.Size(64, 20);
            this.countGenerationNumeric.TabIndex = 4;
            this.countGenerationNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countGenerationNumeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(10, 269);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(616, 30);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // linearCrossing
            // 
            this.linearCrossing.AutoSize = true;
            this.linearCrossing.Location = new System.Drawing.Point(6, 123);
            this.linearCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linearCrossing.Name = "linearCrossing";
            this.linearCrossing.Size = new System.Drawing.Size(151, 17);
            this.linearCrossing.TabIndex = 7;
            this.linearCrossing.TabStop = true;
            this.linearCrossing.Text = "Вещественное линейное";
            this.linearCrossing.UseVisualStyleBackColor = true;
            this.linearCrossing.CheckedChanged += new System.EventHandler(this.linearCrossing_CheckedChanged);
            // 
            // geometryCrossing
            // 
            this.geometryCrossing.AutoSize = true;
            this.geometryCrossing.Location = new System.Drawing.Point(6, 102);
            this.geometryCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.geometryCrossing.Name = "geometryCrossing";
            this.geometryCrossing.Size = new System.Drawing.Size(186, 17);
            this.geometryCrossing.TabIndex = 6;
            this.geometryCrossing.TabStop = true;
            this.geometryCrossing.Text = "Вещественное геометрическое";
            this.geometryCrossing.UseVisualStyleBackColor = true;
            this.geometryCrossing.CheckedChanged += new System.EventHandler(this.geometryCrossing_CheckedChanged);
            // 
            // arithmeticCrossing
            // 
            this.arithmeticCrossing.AutoSize = true;
            this.arithmeticCrossing.Location = new System.Drawing.Point(6, 60);
            this.arithmeticCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arithmeticCrossing.Name = "arithmeticCrossing";
            this.arithmeticCrossing.Size = new System.Drawing.Size(189, 17);
            this.arithmeticCrossing.TabIndex = 5;
            this.arithmeticCrossing.TabStop = true;
            this.arithmeticCrossing.Text = "Вещественное арифметическое";
            this.arithmeticCrossing.UseVisualStyleBackColor = true;
            this.arithmeticCrossing.CheckedChanged += new System.EventHandler(this.ArithmeticCrossing_CheckedChanged);
            // 
            // simplestCrossing
            // 
            this.simplestCrossing.AutoSize = true;
            this.simplestCrossing.Location = new System.Drawing.Point(6, 39);
            this.simplestCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simplestCrossing.Name = "simplestCrossing";
            this.simplestCrossing.Size = new System.Drawing.Size(164, 17);
            this.simplestCrossing.TabIndex = 4;
            this.simplestCrossing.TabStop = true;
            this.simplestCrossing.Text = "Вещественное простейшее";
            this.simplestCrossing.UseVisualStyleBackColor = true;
            this.simplestCrossing.CheckedChanged += new System.EventHandler(this.simplestCrossing_CheckedChanged);
            // 
            // countPointsNumeric
            // 
            this.countPointsNumeric.Location = new System.Drawing.Point(165, 15);
            this.countPointsNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countPointsNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.countPointsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countPointsNumeric.Name = "countPointsNumeric";
            this.countPointsNumeric.Size = new System.Drawing.Size(45, 20);
            this.countPointsNumeric.TabIndex = 2;
            this.countPointsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countPointsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // binaryPointCrossing
            // 
            this.binaryPointCrossing.AutoSize = true;
            this.binaryPointCrossing.Location = new System.Drawing.Point(6, 18);
            this.binaryPointCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binaryPointCrossing.Name = "binaryPointCrossing";
            this.binaryPointCrossing.Size = new System.Drawing.Size(153, 17);
            this.binaryPointCrossing.TabIndex = 1;
            this.binaryPointCrossing.TabStop = true;
            this.binaryPointCrossing.Text = "Бинарное многоточечное";
            this.binaryPointCrossing.UseVisualStyleBackColor = true;
            this.binaryPointCrossing.CheckedChanged += new System.EventHandler(this.binaryPointCrossing_CheckedChanged);
            // 
            // flatCrossing
            // 
            this.flatCrossing.AutoSize = true;
            this.flatCrossing.Location = new System.Drawing.Point(6, 81);
            this.flatCrossing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatCrossing.Name = "flatCrossing";
            this.flatCrossing.Size = new System.Drawing.Size(145, 17);
            this.flatCrossing.TabIndex = 0;
            this.flatCrossing.TabStop = true;
            this.flatCrossing.Text = "Вещественное плоское";
            this.flatCrossing.UseVisualStyleBackColor = true;
            this.flatCrossing.CheckedChanged += new System.EventHandler(this.flatCrossing_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Начальная популяция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сколько поколений";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность \r\nмутации, %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // probabilityNumeric
            // 
            this.probabilityNumeric.Location = new System.Drawing.Point(62, 104);
            this.probabilityNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.probabilityNumeric.Name = "probabilityNumeric";
            this.probabilityNumeric.Size = new System.Drawing.Size(73, 20);
            this.probabilityNumeric.TabIndex = 2;
            this.probabilityNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.probabilityNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // binaryRandomMutation
            // 
            this.binaryRandomMutation.AutoSize = true;
            this.binaryRandomMutation.Location = new System.Drawing.Point(6, 18);
            this.binaryRandomMutation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binaryRandomMutation.Name = "binaryRandomMutation";
            this.binaryRandomMutation.Size = new System.Drawing.Size(174, 17);
            this.binaryRandomMutation.TabIndex = 1;
            this.binaryRandomMutation.TabStop = true;
            this.binaryRandomMutation.Text = "Бинарная случайная мутация";
            this.binaryRandomMutation.UseVisualStyleBackColor = true;
            this.binaryRandomMutation.CheckedChanged += new System.EventHandler(this.binaryRandomMutation_CheckedChanged);
            // 
            // realRandomMutation
            // 
            this.realRandomMutation.AutoSize = true;
            this.realRandomMutation.Location = new System.Drawing.Point(6, 34);
            this.realRandomMutation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.realRandomMutation.Name = "realRandomMutation";
            this.realRandomMutation.Size = new System.Drawing.Size(200, 17);
            this.realRandomMutation.TabIndex = 0;
            this.realRandomMutation.TabStop = true;
            this.realRandomMutation.Text = "Вещественная случайная мутация";
            this.realRandomMutation.UseVisualStyleBackColor = true;
            this.realRandomMutation.CheckedChanged += new System.EventHandler(this.realRandomMutation_CheckedChanged);
            // 
            // outbreedingSelection
            // 
            this.outbreedingSelection.AutoSize = true;
            this.outbreedingSelection.Location = new System.Drawing.Point(6, 123);
            this.outbreedingSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outbreedingSelection.Name = "outbreedingSelection";
            this.outbreedingSelection.Size = new System.Drawing.Size(83, 17);
            this.outbreedingSelection.TabIndex = 7;
            this.outbreedingSelection.TabStop = true;
            this.outbreedingSelection.Text = "Аутбридинг";
            this.outbreedingSelection.UseVisualStyleBackColor = true;
            this.outbreedingSelection.CheckedChanged += new System.EventHandler(this.outbreedingSelection_CheckedChanged);
            // 
            // inbreedingSelection
            // 
            this.inbreedingSelection.AutoSize = true;
            this.inbreedingSelection.Location = new System.Drawing.Point(6, 102);
            this.inbreedingSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inbreedingSelection.Name = "inbreedingSelection";
            this.inbreedingSelection.Size = new System.Drawing.Size(80, 17);
            this.inbreedingSelection.TabIndex = 6;
            this.inbreedingSelection.TabStop = true;
            this.inbreedingSelection.Text = "Инбридинг";
            this.inbreedingSelection.UseVisualStyleBackColor = true;
            this.inbreedingSelection.CheckedChanged += new System.EventHandler(this.inbreedingSelection_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сколько выживших";
            // 
            // numberSurvivedNumeric
            // 
            this.numberSurvivedNumeric.Location = new System.Drawing.Point(541, 193);
            this.numberSurvivedNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberSurvivedNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberSurvivedNumeric.Name = "numberSurvivedNumeric";
            this.numberSurvivedNumeric.Size = new System.Drawing.Size(62, 20);
            this.numberSurvivedNumeric.TabIndex = 4;
            this.numberSurvivedNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberSurvivedNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tournamentSelection
            // 
            this.tournamentSelection.AutoSize = true;
            this.tournamentSelection.Location = new System.Drawing.Point(6, 81);
            this.tournamentSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tournamentSelection.Name = "tournamentSelection";
            this.tournamentSelection.Size = new System.Drawing.Size(113, 17);
            this.tournamentSelection.TabIndex = 3;
            this.tournamentSelection.TabStop = true;
            this.tournamentSelection.Text = "Турнирный отбор";
            this.tournamentSelection.UseVisualStyleBackColor = true;
            this.tournamentSelection.CheckedChanged += new System.EventHandler(this.tournamentSelection_CheckedChanged);
            // 
            // panmixiaSelection
            // 
            this.panmixiaSelection.AutoSize = true;
            this.panmixiaSelection.Location = new System.Drawing.Point(6, 60);
            this.panmixiaSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panmixiaSelection.Name = "panmixiaSelection";
            this.panmixiaSelection.Size = new System.Drawing.Size(83, 17);
            this.panmixiaSelection.TabIndex = 2;
            this.panmixiaSelection.TabStop = true;
            this.panmixiaSelection.Text = "Панмиксия";
            this.panmixiaSelection.UseVisualStyleBackColor = true;
            this.panmixiaSelection.CheckedChanged += new System.EventHandler(this.panmixiaSelection_CheckedChanged);
            // 
            // rankSelection
            // 
            this.rankSelection.AutoSize = true;
            this.rankSelection.Location = new System.Drawing.Point(6, 18);
            this.rankSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rankSelection.Name = "rankSelection";
            this.rankSelection.Size = new System.Drawing.Size(107, 17);
            this.rankSelection.TabIndex = 1;
            this.rankSelection.TabStop = true;
            this.rankSelection.Text = "Ранговый отбор";
            this.rankSelection.UseVisualStyleBackColor = true;
            this.rankSelection.CheckedChanged += new System.EventHandler(this.rankSelection_CheckedChanged);
            // 
            // simpleSelection
            // 
            this.simpleSelection.AutoSize = true;
            this.simpleSelection.Location = new System.Drawing.Point(6, 39);
            this.simpleSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleSelection.Name = "simpleSelection";
            this.simpleSelection.Size = new System.Drawing.Size(100, 17);
            this.simpleSelection.TabIndex = 0;
            this.simpleSelection.TabStop = true;
            this.simpleSelection.Text = "Простой отбор";
            this.simpleSelection.UseVisualStyleBackColor = true;
            this.simpleSelection.CheckedChanged += new System.EventHandler(this.simpleSelection_CheckedChanged);
            // 
            // functionsComboBox
            // 
            this.functionsComboBox.FormattingEnabled = true;
            this.functionsComboBox.Items.AddRange(new object[] {
            "f(x1,x2) = x1^2 +3*x2^2 + 2*x1*x2",
            "f(x1,x2) = 100*(x2-x1^2)^2 + (1-x1)^2",
            "f(x1,x2) = -12*x2 + 4*x1^2 + 4*x2^2 - 4*x1*x2",
            "f(x1,x2) = (x1-2)^4 + (x1-2*x2)^2",
            "f(x1,x2) = 4*(x1-5)^2 + (x2-6)^2",
            "f(x1,x2) = 2* x1^3 + 4*x1*x2^3 - 10* x1*x2 + x2^2"});
            this.functionsComboBox.Location = new System.Drawing.Point(73, 232);
            this.functionsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.functionsComboBox.Name = "functionsComboBox";
            this.functionsComboBox.Size = new System.Drawing.Size(554, 21);
            this.functionsComboBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.binaryPointCrossing);
            this.groupBox1.Controls.Add(this.countPointsNumeric);
            this.groupBox1.Controls.Add(this.simplestCrossing);
            this.groupBox1.Controls.Add(this.arithmeticCrossing);
            this.groupBox1.Controls.Add(this.flatCrossing);
            this.groupBox1.Controls.Add(this.geometryCrossing);
            this.groupBox1.Controls.Add(this.linearCrossing);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скрещивание";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rankSelection);
            this.groupBox2.Controls.Add(this.simpleSelection);
            this.groupBox2.Controls.Add(this.panmixiaSelection);
            this.groupBox2.Controls.Add(this.tournamentSelection);
            this.groupBox2.Controls.Add(this.inbreedingSelection);
            this.groupBox2.Controls.Add(this.outbreedingSelection);
            this.groupBox2.Location = new System.Drawing.Point(244, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 155);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отбор";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.binaryRandomMutation);
            this.groupBox3.Controls.Add(this.realRandomMutation);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.probabilityNumeric);
            this.groupBox3.Location = new System.Drawing.Point(447, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 157);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Мутация";
            // 
            // GeneticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 315);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberSurvivedNumeric);
            this.Controls.Add(this.functionsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.countGenerationNumeric);
            this.Controls.Add(this.countStartedPopulationNumeric);
            this.Controls.Add(this.functionsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GeneticForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneticForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countStartedPopulationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGenerationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPointsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSurvivedNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox functionsComboBox;

        #endregion

        private System.Windows.Forms.Label functionsLabel;
        private System.Windows.Forms.NumericUpDown countStartedPopulationNumeric;
        private System.Windows.Forms.NumericUpDown countGenerationNumeric;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton binaryPointCrossing;
        private System.Windows.Forms.RadioButton flatCrossing;
        private System.Windows.Forms.NumericUpDown countPointsNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton binaryRandomMutation;
        private System.Windows.Forms.RadioButton realRandomMutation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown probabilityNumeric;
        private System.Windows.Forms.RadioButton tournamentSelection;
        private System.Windows.Forms.RadioButton panmixiaSelection;
        private System.Windows.Forms.RadioButton rankSelection;
        private System.Windows.Forms.RadioButton simpleSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberSurvivedNumeric;
        private System.Windows.Forms.RadioButton outbreedingSelection;
        private System.Windows.Forms.RadioButton inbreedingSelection;
        private System.Windows.Forms.RadioButton linearCrossing;
        private System.Windows.Forms.RadioButton geometryCrossing;
        private System.Windows.Forms.RadioButton arithmeticCrossing;
        private System.Windows.Forms.RadioButton simplestCrossing;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}