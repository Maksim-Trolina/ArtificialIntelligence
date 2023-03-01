using System.ComponentModel;

namespace NeuralNetworks;

partial class Hamming
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
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.button1 = new System.Windows.Forms.Button();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.listView1 = new System.Windows.Forms.ListView();
        this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.button5 = new System.Windows.Forms.Button();
        this.button6 = new System.Windows.Forms.Button();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox1.Location = new System.Drawing.Point(12, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(200, 200);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
        this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
        this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(316, 439);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(97, 26);
        this.button1.TabIndex = 1;
        this.button1.Text = "Clear";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // pictureBox2
        // 
        this.pictureBox2.Location = new System.Drawing.Point(6, 19);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new System.Drawing.Size(187, 181);
        this.pictureBox2.TabIndex = 2;
        this.pictureBox2.TabStop = false;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.listView1);
        this.groupBox1.Location = new System.Drawing.Point(220, 217);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(193, 216);
        this.groupBox1.TabIndex = 4;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Samples";
        // 
        // listView1
        // 
        this.listView1.Location = new System.Drawing.Point(6, 19);
        this.listView1.Name = "listView1";
        this.listView1.Size = new System.Drawing.Size(181, 191);
        this.listView1.TabIndex = 0;
        this.listView1.UseCompatibleStateImageBehavior = false;
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(12, 228);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(202, 26);
        this.button3.TabIndex = 5;
        this.button3.Text = "Search";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // button4
        // 
        this.button4.Location = new System.Drawing.Point(12, 260);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(202, 26);
        this.button4.TabIndex = 6;
        this.button4.Text = "Clear image";
        this.button4.UseVisualStyleBackColor = true;
        this.button4.Click += new System.EventHandler(this.button4_Click);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.button5);
        this.groupBox2.Location = new System.Drawing.Point(12, 292);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(202, 173);
        this.groupBox2.TabIndex = 5;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Info";
        // 
        // button5
        // 
        this.button5.Location = new System.Drawing.Point(6, 516);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(198, 26);
        this.button5.TabIndex = 3;
        this.button5.Text = "Add patterns images";
        this.button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        this.button6.Location = new System.Drawing.Point(220, 439);
        this.button6.Name = "button6";
        this.button6.Size = new System.Drawing.Size(90, 26);
        this.button6.TabIndex = 7;
        this.button6.Text = "Add";
        this.button6.UseVisualStyleBackColor = true;
        this.button6.Click += new System.EventHandler(this.button6_Click);
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.pictureBox2);
        this.groupBox3.Location = new System.Drawing.Point(220, 3);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(198, 208);
        this.groupBox3.TabIndex = 5;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Answer";
        // 
        // Hamming
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(430, 471);
        this.Controls.Add(this.groupBox3);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button6);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.pictureBox1);
        this.Name = "Hamming";
        this.Text = "Hamming";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hamming_FormClosed);
        this.Load += new System.EventHandler(this.Hamming_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.groupBox3.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.Button button6;

    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button5;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}