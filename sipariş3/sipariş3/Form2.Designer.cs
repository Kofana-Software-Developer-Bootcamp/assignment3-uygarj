﻿
namespace sipariş3
{
	partial class Frm2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(129, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identity Number :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(129, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name Surname:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telephone";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(264, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 3;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(264, 89);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 26);
			this.textBox2.TabIndex = 4;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(264, 143);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 26);
			this.textBox3.TabIndex = 5;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(150, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "City";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "istanbul ",
            "ankara",
            "izmir"});
			this.comboBox1.Location = new System.Drawing.Point(259, 193);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 28);
			this.comboBox1.TabIndex = 7;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Items.AddRange(new object[] {
            "1234",
            "5678",
            "9012"});
			this.listBox1.Location = new System.Drawing.Point(69, 449);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(144, 224);
			this.listBox1.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(473, 289);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 97);
			this.button1.TabIndex = 9;
			this.button1.Text = "Order";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Items.AddRange(new object[] {
            "serkan inan",
            "uygar ide",
            "aykut baş"});
			this.listBox2.Location = new System.Drawing.Point(213, 449);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(151, 224);
			this.listBox2.TabIndex = 10;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 20;
			this.listBox3.Items.AddRange(new object[] {
            "1111",
            "2222",
            "3333"});
			this.listBox3.Location = new System.Drawing.Point(353, 449);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(145, 224);
			this.listBox3.TabIndex = 11;
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.ItemHeight = 20;
			this.listBox4.Items.AddRange(new object[] {
            "ankara",
            "izmir",
            "isanbul"});
			this.listBox4.Location = new System.Drawing.Point(492, 449);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(145, 224);
			this.listBox4.TabIndex = 12;
			// 
			// listBox5
			// 
			this.listBox5.FormattingEnabled = true;
			this.listBox5.ItemHeight = 20;
			this.listBox5.Items.AddRange(new object[] {
            "2",
            "3",
            "1"});
			this.listBox5.Location = new System.Drawing.Point(631, 449);
			this.listBox5.Name = "listBox5";
			this.listBox5.Size = new System.Drawing.Size(145, 224);
			this.listBox5.TabIndex = 13;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(427, 198);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 26);
			this.textBox4.TabIndex = 14;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(542, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Number";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(111, 426);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "Identity";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(245, 426);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 20);
			this.label7.TabIndex = 17;
			this.label7.Text = "Customer";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(385, 426);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 20);
			this.label8.TabIndex = 18;
			this.label8.Text = "Telephone";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(521, 426);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 20);
			this.label9.TabIndex = 19;
			this.label9.Text = "City";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(665, 426);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 20);
			this.label10.TabIndex = 20;
			this.label10.Text = "Number";
			// 
			// Frm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 687);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.listBox5);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Frm2";
			this.Text = "Form2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm2_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.ComboBox comboBox1;
		public System.Windows.Forms.ListBox listBox1;
		public System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}