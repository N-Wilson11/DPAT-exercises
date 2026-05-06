using ShapesLib;
using ShapesBuilder;
using System.Collections.Generic;

var itemBuilder = new RoadItemBuilder();

var intersection = new Drawing(600,600);
intersection.BackgroundColor = (0, 120, 0);

// Add bicycle track
var bicycleLane1 = itemBuilder.CreateLane(true, (15, 600), (200, 80, 0), 2);
bicycleLane1.Position = (285, 0);
intersection.Add(bicycleLane1);

var bicycleLane2= itemBuilder.CreateLane(true, (15, 600), (200, 80, 0), 2);
bicycleLane2.Position = (300, 0);
intersection.Add(bicycleLane2);

var bicycleEdge1 = new Rectangle();
bicycleEdge1.Filled = true;
bicycleEdge1.FillColor = (255, 255, 255);
bicycleEdge1.StrokeColor = (255, 255, 255);
bicycleEdge1.Size = (1, 600);
bicycleEdge1.Position = (285, 0);
intersection.Add(bicycleEdge1);

var bicycleEdge2 = new Rectangle();
bicycleEdge2.Filled = true;
bicycleEdge2.FillColor = (255, 255, 255);
bicycleEdge2.StrokeColor = (255, 255, 255);
bicycleEdge2.Size = (1, 600);
bicycleEdge2.Position = (314, 0);
intersection.Add(bicycleEdge2);

// Add road
var roadLane1 = itemBuilder.CreateLane(false, (600, 80), (0, 0, 0), 5);
roadLane1.Position = (0, 260);
intersection.Add(roadLane1);

var roadEdge1 = new Rectangle();
roadEdge1.Filled = true;
roadEdge1.FillColor = (255, 255, 255);
roadEdge1.StrokeColor = (255, 255, 255);
roadEdge1.Size = (600,5);
roadEdge1.Position = (0, 260);
intersection.Add(roadEdge1);

var roadEdge2 = new Rectangle();
roadEdge2.Filled = true;
roadEdge2.FillColor = (255, 255, 255);
roadEdge2.StrokeColor = (255, 255, 255);
roadEdge2.Size = (600, 5);
roadEdge2.Position = (0, 335);
intersection.Add(roadEdge2);

// Add Traffic light

var light1 = itemBuilder.CreateLights(Direction.West);
light1.Position = (205, 345);
intersection.Add(light1);

var light2 = itemBuilder.CreateLights(Direction.East);
light2.Position = (315, 225);
intersection.Add(light2);

// Add Crossing

var crossing = itemBuilder.CreateCrossing(true, (50,80));
crossing.Position = (500, 260);
intersection.Add(crossing);

intersection.Draw("intersection.png");




