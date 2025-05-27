using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometr
{
	public abstract class Triangle : Shape
	{
		protected double sideA;
		protected double sideB;
		protected double sideC;

		public Triangle(int startX, int startY, int lineWidth, Color color, double sideA, double sideB, double sideC)
			: base(startX, startY, lineWidth, color)
		{
			this.sideA = sideA;
			this.sideB = sideB;
			this.sideC = sideC;
		}

		public override double GetPerimeter()
		{
			return sideA + sideB + sideC;
		}

		public abstract override double GetArea();

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);

			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)sideA, (int)sideA);
		}

		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
			Console.WriteLine($"Сторона A: {sideA}");
			Console.WriteLine($"Сторона B: {sideB}");
			Console.WriteLine($"Сторона C: {sideC}");
		}
	}
}