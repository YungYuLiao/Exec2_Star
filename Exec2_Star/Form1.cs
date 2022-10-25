using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			//取得列數
			int row = 0;
			try
			{
				row = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//生成靠左星號
			string stars = GenerateLeftStars(row);
			//呈現星號
			Display(stars);
		}

		private void Display(string stars)
		{
			txtResult.Text = stars;
		}

		private string GenerateLeftStars(int row)
		{
			string stars = string.Empty;
			for (int i = 1; i <= row; i++)
			{
				stars += new string('*', i) + "\r\n";
			}
			return stars;
		}

		private int GetRows()
		{
			string input = txtRows.Text;
			bool isInt = int.TryParse(input, out int row);
			if (isInt == false)
			{
				throw new Exception("請輸入列數");
			}
			if(row <= 0)
			{
				throw new Exception("列數必須大於0");
			}
			if(row > 10)
			{
				throw new Exception("列數必須小於10");
			}
			return row;
		}

		private string GenerateRightStars(int row)
		{
			string stars = string.Empty;
			for (int i = 1; i <= row; i++)
			{
				stars += new string('*', i).PadLeft(2*row-i)+"\r\n"; 
			}
			return stars;
		}
		private string GenerateMiddleStars(int row)
		{
			string stars = string.Empty;
			for (int i = 1; i <= row; i++)
			{
				stars += new string('*', i).PadLeft(row) + "\r\n";
			}
			return stars;
		}

		private void btnMiddle_Click(object sender, EventArgs e)
		{
			//取得列數
			int row = 0;
			row = GetRows();
			//生成等腰星號
			string stars = GenerateMiddleStars(row);
			//呈現星號
			Display(stars);
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			//取得列數
			int row = 0;
			row = GetRows();
			//生成靠右星號
			string stars = GenerateRightStars(row);
			//呈現星號
			Display(stars);

		}
	}
}
