using System;
using Microsoft.Maui.Graphics;

namespace ShapesLib.Shapes
{
    public abstract class Element
    {
        public (float x, float y) Position = (0, 0);
        public (float width, float height) Size = (0, 0);
        public Element? Parent;

        public Element()
        {
        }

        public abstract void Draw(ICanvas canvas);
        public abstract string Description();
        public abstract void Add(Element shape);
    }


    public class Group : Element
    {
        private List<Element> _shapes = new List<Element>();

        public Group()
        {
        }

        override public void Draw(ICanvas canvas)
        {
        }

        override public string Description()
        {
            return "Group with " + _shapes.Count + " elements.";
        }

        override public void Add(Element shape)
        {
        }
    }

}