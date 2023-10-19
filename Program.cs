namespace Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle radius = new Circle(5);
            radius.getArea();

            Circle radius2 = new Circle(6);
            radius2.getArea();

            Triangle area = new Triangle(3, 7);
            area.triangelArea();

        }
    }
}