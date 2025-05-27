using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometr
{
	public class ObtuseTriangle : Triangle
	{
		private double angle; //Obtuse angle (greater than 90 and less than 180)

		public ObtuseTriangle(int startX, int startY, int lineWidth, Color color, double sideA, double sideB, double sideC, double angle)
			: base(startX, startY, lineWidth, color, sideA, sideB, sideC)
		{
			if (angle <= 90 || angle >= 180)
			{
				throw new ArgumentException("Angle must be obtuse (between 90 and 180 degrees)!!!");
			}

			this.angle = angle;
		}

		public override double GetArea()
		{
			double angleInRadians = angle * Math.PI / 180.0;
			return 0.5 * sideA * sideB * Math.Sin(angleInRadians);
		}

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);

			Point[] points = new Point[3];

			points[0] = new Point(StartX, StartY);
			points[1] = new Point(StartX + (int)sideA, StartY);
																
			double angleInRadians = angle * Math.PI / 180.0;
			int x3 = StartX + (int)(sideB * Math.Cos(angleInRadians));
			int y3 = StartY - (int)(sideB * Math.Sin(angleInRadians));
			points[2] = new Point(x3, y3);
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
