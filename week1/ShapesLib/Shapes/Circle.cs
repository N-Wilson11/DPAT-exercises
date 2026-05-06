using System;
using Microsoft.Maui.Graphics;

namespace ShapesLib
{
	public class Circle : Shape
	{
        public Circle()
        {
        }

        public Circle(float radius)
		{
            Size = (radius * 2, radius * 2);
		}

        public override string Description()
        {
            return "Cirlce with radius " + Size.width / 2 + " at location (" + Position.x + "," + Position.y + ").";
        }


        public override void Draw(ICanvas canvas)
        {
            float radius = Size.width / 2;

            canvas.StrokeSize = StrokeWidth;
            canvas.StrokeColor = Color.FromRgb(StrokeColor.R, StrokeColor.G, StrokeColor.B);

            if (Filled)
            {
                canvas.FillColor = Color.FromRgb(FillColor.R, FillColor.G, FillColor.B);
                canvas.FillCircle(Position.x, Position.y, radius);
            }

            canvas.DrawCircle(Position.x, Position.y, radius);
        }

    }
}

