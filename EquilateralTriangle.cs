using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometr
{
	public class EquilateralTriangle : Triangle
	{
		public EquilateralTriangle(int startX, int startY, int lineWidth, Color color, double side)
			: base(startX, startY, lineWidth, color, side, side, side)
		{
		}

		public override double GetArea()
		{
			return (Math.Sqrt(3) / 4) * sideA * sideA;
		}

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);

			double height = (sideA * Math.Sqrt(3)) / 2;

			Point[] points = new Point[3];

			points[0] = new Point(StartX, StartY);                 //Bottom Left
			points[1] = new Point(StartX + (int)sideA, StartY);       //Bottom Right
			points[2] = new Point(StartX + (int)(sideA / 2), StartY - (int)height); //Top

			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
