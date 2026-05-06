using ShapesLib;

var flatDrawing = TestDrawings.FlatDrawing();
flatDrawing.Draw("drawing_flat.png");

// Wanneer je de composite geimplementeerd hebt, kun je onderstaande testcode activeren
//var hierarchicalDrawing = TestDrawings.HierarchicalDrawing();
//hierarchicalDrawing.Draw("drawing_hierarchical.png");

System.Console.ReadKey();

