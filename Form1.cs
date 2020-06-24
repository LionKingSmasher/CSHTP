using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSHTP
{
	public partial class Form1 : Form
	{
		public int P(int n)
		{
			bool choice = true;
			for (int i = 2; i <= Math.Sqrt(n) + 1; i++)
			{
				if (n % i == 0) choice = false;
			}
			if (choice) return 1;
			else return 0;
		}
		public int NP(int n)
		{
			bool choice = true;
			for (int i = 2; i <= Math.Sqrt(n) + 1; i++)
			{
				if (n % i == 0) choice = false;
			}
			if (choice) return 0;
			else return 1;
		}
		public int H(int n)
		{
			bool choice = true;
			for(int i = 2; i<=Math.Sqrt(n) + 1; i++)
			{
				if (n % i == 0) choice = false;
			}
			if (choice) return -1;
			else return 1;
		}
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			chart1.Series.Clear();
			Series s1 = new Series("Prime Head Tail");
			Series s2 = new Series("Not Prime");
			Series s3 = new Series("Prime");
			chart1.Series.Add(s1);
			chart1.Series.Add(s2);
			chart1.Series.Add(s3);
			string input_s = textBox1.Text;
			int int_changed = int.Parse(input_s);
			int sum_1 = 0;
			int sum_2 = 0;
			int sum_3 = 0;


			chart1.Series["Prime Head Tail"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			chart1.Series["Prime"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			chart1.Series["Not Prime"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

			for (int i=2; i<=int_changed; i++)
			{
				sum_1 += H(i);
				sum_2 += NP(i);
				sum_3 += P(i);
				chart1.Series["Prime Head Tail"].Points.Add(sum_1);
				chart1.Series["Prime"].Points.Add(sum_3);
				chart1.Series["Not Prime"].Points.Add(sum_2);
			}
		}
	}
}
