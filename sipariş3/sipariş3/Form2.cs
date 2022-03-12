using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sipariş3
{
	public partial class Frm2 : Form
	{
		public Frm2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string tc = "", AdSoyad = "", telefon = "", urun = "", tane = "";
			tc = textBox1.Text;
			AdSoyad = textBox2.Text;
			telefon = textBox3.Text;
			tane = textBox4.Text;
			urun = comboBox1.Text;

			MessageBox.Show("Registration Completed", "İNFO");

			listBox1.Items.Add(tc);
			listBox2.Items.Add(AdSoyad);
			listBox3.Items.Add(telefon);
			listBox4.Items.Add(urun);
			listBox5.Items.Add(tane);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void Frm2_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
