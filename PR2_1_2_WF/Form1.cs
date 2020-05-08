using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_1_2_WF
{
	public partial class practic2 : Form
	{
		public practic2()
		{
			InitializeComponent();
		}

		private void x_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
			{
				e.Handled = true;
			}
		}
		
		private void Check_Click(object sender, EventArgs e)
		{
			double X = Convert.ToDouble(x.Text);
			double Y = Convert.ToDouble(y.Text);
			if ((Y < -15 || X < -15) || (Y > 0 || X > 0)) result.Text = "Внутри";
			else
			{
				if (((Y >= -15 && Y <= 0) && (X==0|| X==-15)) || ((X >= -15 && X <=0) && (Y==0 || Y == -15))) result.Text = "На границе";
				else result.Text = "Вне";
			}
			Console.ReadLine();
		}

		private void sex_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> men = new List<string>() { "Миша", "Сергей", "Витя", "Кирилл", "Саша" };
			List<string> women = new List<string>() { "Маша", "Света","Вика", "Кристина", "Саша" };
			if (sex.SelectedIndex == 0)
			{
				string rez = "";
				foreach (string name in men)
				{
					rez  += name + "\n";
					names.Text = rez;
				}
			}
			else
			{
				string rez = "";
				foreach (string name in women)
				{
					rez += name + "\n";
					names.Text = rez;
				}
			}
		}

		private void show_Click(object sender, EventArgs e)
		{
			int current = 9;
			string str = "";
			while (current < 100)
			{
				current++;
				if (current / 10 == current % 10) current++;
				str += current.ToString() + " ";
			}
			show_box.Text = str;
			current = 9;
			str += "\n";
			do
			{
				current++;
				if (current / 10 == current % 10) current++;
				str += current.ToString() + " ";
			} while (current < 100);
			show_box.Text = str;
			str += "\n";
			for (int i = 10; i < 100; i++)
			{
				if (i / 10 == i % 10) i++;
				str += i.ToString() + " ";
			}
			show_box.Text = str;
		}

		private void show4_Click(object sender, EventArgs e)
		{
			string str = "";
			for (int i = 1; i <= 4; i++, str+="\n")
			{
				for (int j = 0; j < i; j++)
				{
					str += i.ToString() + " ";
				}
				str += "\n";
				for (int m = 0; m < i; m++)
					str += (5 + i).ToString() + " ";
			}
			show_box4.Text = str;
		}
	}
}
