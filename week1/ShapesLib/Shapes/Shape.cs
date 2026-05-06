using System;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;


namespace ShapesLib
{

    public abstract class Shape
	{
        // public members
        public (float x, float y) Position = (0, 0);
        public (float width, float height) Size = (0, 0);
        public (int R, int G, int B) StrokeColor = (0,0,0);
        public (int R, int G, int B) FillColor = (0,0,0);
        public bool Filled = false;
        public float StrokeWidth = 1;

        // Constructors

        public Shape () 
        {
        }

        // All sub-shapes should implement:

        public abstract void Draw(ICanvas canvas);
        public abstract string Description();

 	}
}

