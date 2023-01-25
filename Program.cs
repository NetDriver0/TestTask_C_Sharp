using TestTask1;

Circle circle = new Circle();
circle.Radius = 6;
Console.WriteLine("Площадь круга = " + circle.Area());
Console.WriteLine();

Triangle triangle = new Triangle();
triangle.SetSides(4, 3, 5);
Console.WriteLine("Площадь треугольника = " + triangle.Area());
Console.WriteLine("Треугольник прямоугольный = "+ triangle.IsSquare());
Console.ReadKey();
