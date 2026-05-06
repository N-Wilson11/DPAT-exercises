using System;
namespace ShapesBuilder
{
	public enum Direction
	{
        North,
        South,
        West,
        East
    }

    static class DirectionMethods
    {

        public static Boolean IsVertical(this Direction direction)
        {
            return direction == Direction.North || direction == Direction.South;
        }
    }

}

