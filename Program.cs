//#define TRIANGLES
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
		private Random random = new Random();
		public Form1()
		{
			this.Paint += Form1_Paint;
		}

		private int GenerateRandom(int min, int max)
		{
			return random.Next(min, max + 1);
		}

		private Color GenerateRandomColor()
		{
			return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			int rightStartX = GenerateRandom(100, 150);
			int rightStartY = GenerateRandom(50, 150);
			int rightLineWidth = GenerateRandom(0, 10);
			Color rightColor = GenerateRandomColor();
			double rightSideA = GenerateRandom(50, 90);
			double rightSideB = GenerateRandom(50, 90);

			int eqStartX = GenerateRandom(100, 150);
			int eqStartY = GenerateRandom(50, 150);
			int eqLineWidth = GenerateRandom(0, 10);
			Color eqColor = GenerateRandomColor();
			double eqSide = GenerateRandom(50, 90);

			RightTriangle rightTriangle = new RightTriangle(rightStartX, rightStartY, rightLineWidth, rightColor, rightSideA, rightSideB);
			EquilateralTriangle equilateralTriangle = new EquilateralTriangle(eqStartX, eqStartY, eqLineWidth, eqColor, eqSide);

			rightTriangle.Draw(e);
			equilateralTriangle.Draw(e);

			Console.WriteLine("Прямоугольный треугольник:");
			rightTriangle.Info(e);

			Console.WriteLine();

			Console.WriteLine("Равносторонний треугольник:");
			equilateralTriangle.Info(e);
		}
#if TRIANGLES
		//private void Form1_Paint(object sender, PaintEventArgs e)
		//{
		//	RightTriangle rightTriangle = new RightTriangle(150, 150, 2, Color.Green, 50, 80);
		//	EquilateralTriangle equilateralTriangle = new EquilateralTriangle(150, 150, 3, Color.Blue, 75);
		//	ObtuseTriangle obtuseTriangle = new ObtuseTriangle(150, 150, 3, Color.Red, 75, 90, 86, 150);

		//	rightTriangle.Draw(e);
		//	equilateralTriangle.Draw(e);

		//	Console.WriteLine("Прямоульный треугольник:");
		//	rightTriangle.Info(e);

		//	Console.WriteLine();

		//	Console.WriteLine("Равносторонний треугольник:");
		//	equilateralTriangle.Info(e);

		//	Console.WriteLine();

		//	Console.WriteLine("Тупоугольный треугольник:");
		//	obtuseTriangle.Info(e);
		//}

#endif
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}