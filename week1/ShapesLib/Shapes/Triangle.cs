using System;
using Microsoft.Maui.Graphics;

namespace ShapesLib
{
	public class Triangle : Shape
	{

        public override string Description()
        {
            return "Triangle with base width " + Size.width + " and height " + Size.height + " at location (" + Position.x + "," + Position.y + ").";
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.StrokeSize = StrokeWidth;
            canvas.StrokeColor = Color.FromRgb(StrokeColor.R, StrokeColor.G, StrokeColor.B);

            var halfWidth = Size.width / 2;
            var halfHeight = Size.height / 2;

            PathF path = new PathF();
            path.MoveTo(AbsolutePosition.x - halfWidth, AbsolutePosition.y - halfHeight);
            path.LineTo(AbsolutePosition.x + halfWidth, AbsolutePosition.y - halfHeight);
            path.LineTo(AbsolutePosition.x, AbsolutePosition.y + halfHeight);
            path.Close();

            if (Filled)
            {
                canvas.FillColor = Color.FromRgb(FillColor.R, FillColor.G, FillColor.B);
                canvas.FillPath(path);
            }

            canvas.DrawPath(path);
        }

    }
}

