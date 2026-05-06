using System;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;


namespace ShapesLib
{

    public abstract class Shape : Element
	{
        // public members
        public (int R, int G, int B) StrokeColor = (0,0,0);
        public (int R, int G, int B) FillColor = (0,0,0);
        public bool Filled = false;
        public float StrokeWidth = 1;

        // Constructors

        public Shape () 
        {
        }

        public override void Add(Element shape)
        {
            throw new NotImplementedException();
        }


        public override void Remove(Element shape)
        {
            throw new NotImplementedException();
        }

        public override List<Element> Children()
        {
            return new List<Element>();
        }
    }
}

