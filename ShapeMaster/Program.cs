using GeometryLibrary.Shapes;

namespace ShapeMaster
{
    class Program
    {

        static void Main(string[] args)
        {
            var circle = new Circle(30);
            var triangle = new Triangle(25, 15,30);

            var area = circle.CalculateArea();
            Console.WriteLine($"Площадь круга равна: {area}");
            area = triangle.CalculateArea();
            Console.WriteLine($"Площадь треугольника равна: {area}");
            Console.ReadLine();
        }
    }
}

