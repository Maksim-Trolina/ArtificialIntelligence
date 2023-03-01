using System.ComponentModel;

namespace NeuralNetworks;

partial class Hopfield
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
        this.gridPictureBox = new System.Windows.Forms.PictureBox();
        this.imageList = new System.Windows.Forms.ListView();
        this.button4 = new System.Windows.Forms.Button();
        this.acceptableSamplesLabel = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.RowsCount = new System.Windows.Forms.NumericUpDown();
        this.ColumnCount = new System.Windows.Forms.NumericUpDown();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.RowsCount)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.ColumnCount)).BeginInit();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(75, 498);
        this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(253, 37);
        this.button1.TabIndex = 0;
        this.button1.Text = "Add pattern";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(333, 498);
        this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(253, 37);
        this.button2.TabIndex = 5;
        this.button2.Text = "Search";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // dataGridBoolColumn1
        // 
        this.dataGridBoolColumn1.Width = -1;
        // 
        // gridPictureBox
        // 
        this.gridPictureBox.Location = new System.Drawing.Point(75, 76);
        this.gridPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.gridPictureBox.Name = "gridPictureBox";
        this.gridPictureBox.Size = new System.Drawing.Size(513, 414);
        this.gridPictureBox.TabIndex = 23;
        this.gridPictureBox.TabStop = false;
        this.gridPictureBox.Click += new System.EventHandler(this.gridPictureBox_Click);
        // 
        // imageList
        // 
        this.imageList.Location = new System.Drawing.Point(607, 76);
        this.imageList.Margin = new System.Windows.Forms.Padding(4);
        this.imageList.Name = "imageList";
        this.imageList.Size = new System.Drawing.Size(308, 414);
        this.imageList.TabIndex = 25;
        this.imageList.UseCompatibleStateImageBehavior = false;
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(605, 498);
        this.button4.Margin = new System.Windows.Forms.Padding(4);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(309, 37);
        this.button4.TabIndex = 26;
        this.button4.Text = "Clear patterns";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // acceptableSamplesLabel
        // 
        this.acceptableSamplesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.acceptableSamplesLabel.Location = new System.Drawing.Point(777, 33);
        this.acceptableSamplesLabel.Name = "acceptableSamplesLabel";
        this.acceptableSamplesLabel.Size = new System.Drawing.Size(139, 39);
        this.acceptableSamplesLabel.TabIndex = 27;
        this.acceptableSamplesLabel.Text = "label1";
        this.acceptableSamplesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(643, 28);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(164, 44);
        this.label1.TabIndex = 28;
        this.label1.Text = "Количество допустимых образцов";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // RowsCount
        // 
        this.RowsCount.Location = new System.Drawing.Point(128, 28);
        this.RowsCount.Name = "RowsCount";
        this.RowsCount.Size = new System.Drawing.Size(109, 22);
        this.RowsCount.TabIndex = 29;
        this.RowsCount.ValueChanged += new System.EventHandler(this.RowsCount_ValueChanged);
        // 
        // ColumnCount
        // 
        this.ColumnCount.Location = new System.Drawing.Point(370, 28);
        this.ColumnCount.Name = "ColumnCount";
        this.ColumnCount.Size = new System.Drawing.Size(104, 22);
        this.ColumnCount.TabIndex = 30;
        this.ColumnCount.ValueChanged += new System.EventHandler(this.ColumnCount_ValueChanged);
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(75, 22);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(47, 32);
        this.label2.TabIndex = 31;
        this.label2.Text = "Rows";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(298, 22);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(66, 32);
        this.label3.TabIndex = 32;
        this.label3.Text = "Columns";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Hopfield
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(939, 546);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.ColumnCount);
        this.Controls.Add(this.RowsCount);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.acceptableSamplesLabel);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.imageList);
        this.Controls.Add(this.gridPictureBox);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
        this.Name = "Hopfield";
        this.Text = "Hopfield";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hopfield_FormClosed);
        this.Load += new System.EventHandler(this.Hopfield_Load);
        ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.RowsCount)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.ColumnCount)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.NumericUpDown RowsCount;
    private System.Windows.Forms.NumericUpDown ColumnCount;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label acceptableSamplesLabel;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.ListView imageList;

        private System.Windows.Forms.PictureBox gridPictureBox;

        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        #endregion
}