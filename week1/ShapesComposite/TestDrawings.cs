using System.Text.RegularExpressions;
using ShapesLib;

public class TestDrawings
{
    public static Drawing FlatDrawing()
    {
        // drawing
        // |_ head
        // |_ leftEar
        // |- rightEar
        // |_ leftEye
        // |_ rightEye
        // |_ nose
        // |_ mouth

        var drawing = new Drawing(640, 400);

        var leftEar = new Circle(30);
        leftEar.Position = (100, 110);
        leftEar.StrokeColor = (255, 0, 0);
        leftEar.StrokeWidth = 3;
        drawing.Add(leftEar);
        Console.WriteLine(leftEar.Description());

        var rightEar = new Circle(30);
        rightEar.Position = (200, 110);
        rightEar.StrokeColor = (255, 0, 0);
        rightEar.StrokeWidth = 3;
        drawing.Add(rightEar);
        Console.WriteLine(leftEar.Description());

        var head = new Circle(60);
        head.Position = (150, 150);
        head.StrokeColor = (255, 128, 0);
        head.StrokeWidth = 3;
        head.FillColor = (0, 255, 128);
        head.Filled = true;
        drawing.Add(head);
        Console.WriteLine(head.Description());

        var leftEye = new Rectangle();
        leftEye.Position = (130, 130);
        leftEye.Size = (10, 20);
        leftEye.StrokeColor = (255, 0, 128);
        leftEye.Filled = true;
        drawing.Add(leftEye);
        Console.WriteLine(leftEye.Description());

        var rightEye = new Rectangle();
        rightEye.Position = (160, 140);
        rightEye.Size = (20, 5);
        rightEye.StrokeColor = (255, 0, 128);
        rightEye.Filled = true;
        drawing.Add(rightEye);
        Console.WriteLine(rightEye.Description());

        var nose = new Triangle();
        nose.Position = (150, 167);
        nose.Size = (30, 15);
        nose.StrokeColor = (64, 64, 16);
        nose.FillColor = (255, 255, 128);
        nose.Filled = true;
        drawing.Add(nose);
        Console.WriteLine(nose.Description());

        var mouth = new Circle(10);
        mouth.Position = (150, 190);
        drawing.Add(mouth);
        Console.WriteLine(mouth.Description());

        return drawing;
    }

    // Veranderde false in true na composite conversie
#if false
    public static Drawing HierarchicalDrawing()
    {
        // drawing
        // |_ outer
        // |  |_ head
        // |  |_ ears
        // |     |_ leftEar
        // |     |- rightEar
        // |
        // |_ inner
        //    |_ eyes
        //    |  |_ leftEye
        //    |  |_ rightEye
        //    |_ nose
        //    |_ mouth


        var drawing = new Drawing(640, 400);

        var outer = new Group();
        outer.Position = (70, 70);
        drawing.Add(outer);

        var ears = new Group();
        ears.Position = (0, 10);
        outer.Add(ears);

        var leftEar = new Circle(30);
        leftEar.Position = (30, 30);
        leftEar.StrokeColor = (255, 0, 0);
        leftEar.StrokeWidth = 3;
        ears.Add(leftEar);
        Console.WriteLine(leftEar.Description());

        var rightEar = new Circle(30);
        rightEar.Position = (130, 30);
        rightEar.StrokeColor = (255, 0, 0);
        rightEar.StrokeWidth = 3;
        ears.Add(rightEar);
        Console.WriteLine(leftEar.Description());

        var head = new Circle(60);
        head.Position = (80, 80);
        head.StrokeColor = (255, 128, 0);
        head.StrokeWidth = 3;
        head.FillColor = (0, 255, 128);
        head.Filled = true;
        outer.Add(head);
        Console.WriteLine(head.Description());

        var inner = new Group();
        inner.Position = (50, 50);
        drawing.Add(inner);

        var eyes = new Group();
        eyes.Position = (50, 50);
        inner.Add(eyes);

        var leftEye = new Rectangle();
        leftEye.Position = (30, 30);
        leftEye.Size = (10, 20);
        leftEye.StrokeColor = (255, 0, 128);
        leftEye.Filled = true;
        eyes.Add(leftEye);
        Console.WriteLine(leftEye.Description());

        var rightEye = new Rectangle();
        rightEye.Position = (60, 40);
        rightEye.Size = (20, 5);
        rightEye.StrokeColor = (255, 0, 128);
        rightEye.Filled = true;
        eyes.Add(rightEye);
        Console.WriteLine(rightEye.Description());

        var nose = new Triangle();
        nose.Position = (100, 117);
        nose.Size = (30, 15);
        nose.StrokeColor = (64, 64, 16);
        nose.FillColor = (255, 255, 128);
        nose.Filled = true;
        inner.Add(nose);
        Console.WriteLine(nose.Description());

        var mouth = new Circle(10);
        mouth.Position = (100, 140);
        inner.Add(mouth);
        Console.WriteLine(mouth.Description());

        return drawing;
    }
#endif
}
