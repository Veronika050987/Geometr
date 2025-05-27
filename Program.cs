using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Geometr
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.Paint += Form1_Paint;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			RightTriangle rightTriangle = new RightTriangle(150, 150, 2, Color.Green, 50, 80);
			EquilateralTriangle equilateralTriangle = new EquilateralTriangle(150, 150, 3, Color.Blue, 75);
			ObtuseTriangle obtuseTriangle = new ObtuseTriangle(150, 150, 3, Color.Red, 75, 90, 86, 150);

			rightTriangle.Draw(e);
			equilateralTriangle.Draw(e);

			Console.WriteLine("Прямоульный треугольник:");
			rightTriangle.Info(e);

			Console.WriteLine();

			Console.WriteLine("Равносторонний треугольник:");
			equilateralTriangle.Info(e);

			Console.WriteLine();

			Console.WriteLine("Тупоугольный треугольник:");
			obtuseTriangle.Info(e);
		}

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}