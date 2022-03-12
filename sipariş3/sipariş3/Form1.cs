using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace sipariş3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			//SoundPlayer fifa = new SoundPlayer();
			//string oyun = Application.StartupPath + "\\ses.wav";
			//fifa.SoundLocation = oyun;
			//fifa.Play();
			//this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox3.Text == "1234")
			{
				MessageBox.Show("Serkan İnan your order is already completed", "İNFO");
			}
			else if (textBox3.Text == "5678")
			{
				MessageBox.Show("Uygar İde your order is already completed", "İNFO");
			}
			else if (textBox3.Text == "9012")
			{
				MessageBox.Show("Aykut Baş your order is already completed", "İNFO");
			}
			else if (textBox3.Text == "")
			{
				MessageBox.Show("Cannot be Blank!");
			}
			else
			{
				Frm2 frm2 = new Frm2();
				frm2.Show();
				this.Hide();
			}
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
			{
				e.Handled = true;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
