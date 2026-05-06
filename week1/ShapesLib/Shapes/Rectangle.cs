using System;
using Microsoft.Maui.Graphics;

namespace ShapesLib
{
	public class Rectangle : Shape
	{

        public Rectangle()
        {

        }

        public override string Description()
        {
            return "Rectangle with size " + Size.width + "x" + Size.height + " at location (" + Position.x + "," + Position.y + ").";
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.StrokeSize = StrokeWidth;
            canvas.StrokeColor = Color.FromRgb(StrokeColor.R, StrokeColor.G, StrokeColor.B);

            if (Filled)
            {
                canvas.FillColor = Color.FromRgb(FillColor.R, FillColor.G, FillColor.B);
                canvas.FillRectangle(Position.x, Position.y, Size.width, Size.height);
            }

            canvas.DrawRectangle(Position.x, Position.y, Size.width, Size.height);
        }

    }
}

