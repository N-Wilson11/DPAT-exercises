using System;
using Microsoft.Maui.Graphics;

namespace ShapesLib
{
    public class Group : Element
    {
        private List<Element> _shapes = new List<Element>();

        private (float width, float height) CalculateSize()
        {

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;

            foreach (var child in _shapes)
            {
                minX = Math.Min(minX, child.Position.x);
                minY = Math.Min(minY, child.Position.y);
                maxX = Math.Max(maxX, child.Position.x + child.Size.width);
                maxY = Math.Max(maxY, child.Position.y + child.Size.height);
            }
            return (maxX - minX, maxY - minY);
        }


        public Group()
        {
        }

        override public void Draw(ICanvas canvas)
        {
            foreach (Element shape in _shapes)
            {
                shape.Draw(canvas);
            }
        }

        override public string Description()
        {
            return "Group with " + _shapes.Count() + " elements.";
        }

        override public void Add(Element shape)
        {
            shape.Parent = this;
            _shapes.Add(shape);
            Size = CalculateSize();
        }

        override public void Remove(Element shape)
        {
            shape.Parent = null;
            _shapes.Remove(shape);
            Size = CalculateSize();
        }

        override public List<Element> Children()
        {
            return new List<Element>(_shapes);
        }
    }
}

