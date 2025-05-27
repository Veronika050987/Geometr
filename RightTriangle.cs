using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometr
{
	public class RightTriangle : Triangle
	{
		public RightTriangle(int startX, int startY, int lineWidth, Color color, double sideA, double sideB)
			: base(startX, startY, lineWidth, color, sideA, sideB, Math.Sqrt(sideA * sideA + sideB * sideB))
		{
		}

		public override double GetArea()
		{
			return 0.5 * sideA * sideB;
		}

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);

			Point[] points = new Point[3];
			points[0] = new Point(StartX, StartY);  // Bottom-left corner
			points[1] = new Point(StartX + (int)sideA, StartY); // Bottom-right corner
			points[2] = new Point(StartX, StartY - (int)sideB);  // Top-left corner

			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
