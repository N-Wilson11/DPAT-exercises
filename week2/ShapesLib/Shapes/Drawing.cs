using System;
using System.Reflection;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;
using static System.Net.Mime.MediaTypeNames;

namespace ShapesLib
{
	public class Drawing : Group
	{
        public (int R, int G, int B) BackgroundColor = (255,255,255);
		private Rectangle _background;

        public Drawing(int width, int height)
		{
			_background = new Rectangle();
			_background.Size = (width, height);
		}

		public void Draw(String imagePath)
		{
			// Create a canvas to draw on
            SkiaBitmapExportContext png = new((int)_background.Size.width, (int)_background.Size.height, 1.0f);
            ICanvas canvas = png.Canvas;

			// Draw background
			canvas.FillColor = Color.FromRgb(BackgroundColor.R, BackgroundColor.G, BackgroundColor.B);
            canvas.FillRectangle(0, 0, _background.Size.width, _background.Size.height);

			// Perform normal Drawing of a Group
			base.Draw(canvas);

            // Save the image as a PNG file
            png.WriteToFile(imagePath);

            System.Console.WriteLine("Image was written to file: " + imagePath + " in directory: " + System.IO.Path.GetDirectoryName(path: Assembly.GetEntryAssembly()?.Location ?? "???"));

        }
    }
}

