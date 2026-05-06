using System;
using Microsoft.Maui.Graphics;

namespace ShapesLib
{
    public abstract class Element
    {

        public (float x, float y) Position = (0, 0);

        public (float x, float y) AbsolutePosition
        {
            get
            {
                var parentPosition = Parent?.AbsolutePosition ?? (0, 0);
                return (parentPosition.x + Position.x, parentPosition.y + Position.y);
            }

            set
            {
                (float x, float y) parentPosition = Parent?.AbsolutePosition ?? (0, 0);
                Position =  (value.x - parentPosition.x, value.y - parentPosition.y);
            }
        }

        public (float width, float height) Size = (0, 0);

        public Element? Parent;

        public Element()
        {
        }

        public abstract void Draw(ICanvas canvas);
        public abstract string Description();
        public abstract void Add(Element shape);
        public abstract void Remove(Element shape);
        public abstract List<Element> Children();

    }
}

