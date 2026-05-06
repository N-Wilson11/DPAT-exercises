using System;
using System.Reflection;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;
using static System.Net.Mime.MediaTypeNames;

namespace ShapesLib
{
	public class Drawing
	{
		public int Width;
		public int Height;

		private List<Shape> _shapes = new List<Shape>();
		public (int, int, int) BackgroundColor;

		public void Add(Shape shape)
		{
			_shapes.Add(shape);
		}

		public Drawing(int width, int height)
		{
			Width = width;
			Height = height;
		}

        public void Draw(String imagePath)
		{
            // Create a canvas to draw on
            SkiaBitmapExportContext png = new(Width, Height, 1.0f);
            ICanvas canvas = png.Canvas;

			// Draw background
			canvas.FillRectangle(0, 0, Width, Height);

			// Draw shapes
			foreach (Shape shape in _shapes)
			{
				shape.Draw(canvas);
			}

            // Save the image as a PNG file
            png.WriteToFile(imagePath);

			System.Console.WriteLine("Image was written to file: " + imagePath + " in directory: " + System.IO.Path.GetDirectoryName(path: Assembly.GetEntryAssembly()?.Location ?? "???"));

        }
    }
}

