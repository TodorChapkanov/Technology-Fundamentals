namespace _06_CalculateRectangleArea
{
    using System;


    public class CalculateRectangleArea
    {
        public static void Main()
        {
            var rectangleHеight = double.Parse(Console.ReadLine());
            var rectangleWidth = double.Parse(Console.ReadLine());

            var rectangleArea = CalculateArea(rectangleHеight, rectangleWidth);

            Console.WriteLine(rectangleArea);
        }

        private static object CalculateArea(double rectangleHеight, double rectangleWidth)
        {
            var result = rectangleHеight * rectangleWidth;
            return result;
        }
    }
}
