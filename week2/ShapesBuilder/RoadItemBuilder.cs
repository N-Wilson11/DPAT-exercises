using System;
using ShapesLib;

namespace ShapesBuilder
{
	public class RoadItemBuilder
	{


		public RoadItemBuilder()
		{

	    }

        public Group CreateLane(bool isVertical,
                                (int width, int height) size,
                                (int R, int G, int B) tarmacColor,
                                int markingsWidth)
        {
            var result = new Group();

            var body = new Rectangle();
            body.Size = size;
            body.FillColor = tarmacColor;
            body.StrokeColor = tarmacColor;
            body.Filled = true;

            result.Add(body);

            // add markings
            if (isVertical)
            {
                var numberOfCenterMarkings = size.height / (markingsWidth * 10);
                for (int index = 0; index < numberOfCenterMarkings; index++)
                {
                    var centerMarking = new Rectangle();
                    centerMarking.Size = (markingsWidth, markingsWidth * 5);
                    centerMarking.Position = (size.width - (markingsWidth), index * markingsWidth * 10);
                    centerMarking.FillColor = (255, 255, 255);
                    centerMarking.StrokeColor = (100, 100, 100);
                    centerMarking.Filled = true;
                    result.Add(centerMarking);
                }
            }
            else
            {
                var numberOfCenterMarkings = size.width / (markingsWidth * 10);
                for (int index = 0; index < numberOfCenterMarkings; index++)
                {
                    var centerMarking = new Rectangle();
                    centerMarking.Size = (markingsWidth * 5, markingsWidth);
                    centerMarking.Position = (index * markingsWidth * 10, size.height - (markingsWidth));
                    centerMarking.FillColor = (255, 255, 255);
                    centerMarking.StrokeColor = (100, 100, 100);
                    centerMarking.Filled = true;
                    result.Add(centerMarking);

                }

            }
            return result;
        }

        public Group CreateCrossing(Boolean isVertical, (int width, int height) size)
        {
            var result = new Group();
            const int stripeHeight = 10;
            int stripeWidth = (isVertical) ? (int)size.width : (int)size.height;
            int start = 0;
            int end = (isVertical) ? size.height : size.width;
            int current = start;
            
            while (current<end)
            {
                var stripe = new Rectangle();
                stripe.Filled = true;
                stripe.FillColor = (255, 255, 255);
                stripe.StrokeColor = (100, 100, 100);
                var currentStripeHeight = stripeHeight;
                currentStripeHeight = Math.Min(currentStripeHeight, (isVertical) ? size.height - current : size.width - current);
                stripe.Size = (isVertical) ? (stripeWidth, currentStripeHeight) : (currentStripeHeight, stripeWidth);
                stripe.Position = (isVertical) ? (0, current) : (current, 0);
                result.Add(stripe);
                current += stripeHeight * 2;
            }

            return result;
        }
            
        public Group CreateLights(Direction direction)
        {
            Group result= new Group();
            Rectangle body = new Rectangle();
            Circle redLight = new Circle(10);
            Circle yellowLight = new Circle(10);
            Circle greenLight = new Circle(10);

            // Set general parameters
            body.FillColor = (80, 80, 80);
            body.StrokeColor = (200, 200, 200);
            body.Filled = true;

            redLight.StrokeColor = (80, 0, 65);
            redLight.FillColor = (250, 0, 0);
            redLight.Filled = true;

            yellowLight.StrokeColor = (40, 80, 80);
            yellowLight.FillColor = (250, 100, 0);
            yellowLight.Filled = true;

            greenLight.StrokeColor = (0, 8, 0);
            greenLight.FillColor = (0, 250, 0);
            greenLight.Filled = true;

            // Adjust parameters for orientation
            switch (direction)
            {
                case Direction.South:
                    body.Size = (30, 80);
                    redLight.Position = (15, 15);
                    yellowLight.Position = (15, 40);
                    greenLight.Position = (15, 65);
                    break;

                case Direction.North:
                    body.Size = (30, 80);
                    redLight.Position = (15, 65);
                    yellowLight.Position = (15, 40);
                    greenLight.Position = (15, 15);
                    break;

                case Direction.East:
                    body.Size = (80, 30);
                    redLight.Position = (15, 15);
                    yellowLight.Position = (40, 15);
                    greenLight.Position = (65, 15);
                    break;

                case Direction.West:
                    body.Size = (80, 30);
                    redLight.Position = (65, 15);
                    yellowLight.Position = (40, 15);
                    greenLight.Position = (15, 15);
                    break;

            }

            result.Add(body);
            result.Add(redLight);
            result.Add(yellowLight);
            result.Add(greenLight);

            return result;
        }
    }
}


