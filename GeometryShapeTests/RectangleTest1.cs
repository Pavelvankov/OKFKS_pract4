using System;
using Xunit;
using GeometryShape;

namespace GeometryShapeTests
{
    public class ShapeTests
    {
        // 1. Тесты создания фигур
        [Fact]
        public void Rectangle_Creation_ShouldSetWidthAndHeight()
        {
            double width = 5;
            double height = 10;

            var rectangle = new Rectangle(width, height);

            Assert.Equal(width, rectangle.Width);
            Assert.Equal(height, rectangle.Height);
        }


        // 2. Проверка методов Area() и Perimeter() для Rectangle
        [Fact]
        public void Rectangle_Area_ShouldReturnCorrectValue()
        {
            var rectangle = new Rectangle(5, 10);
            double expected = 50;
            double result = rectangle.Area();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Rectangle_Perimeter_ShouldReturnCorrectValue()
        {
            var rectangle = new Rectangle(5, 10);
            double expected = 30;
            double result = rectangle.Perimeter();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Rectangle_ToString_ShouldReturnCorrectString()
        {
            var rectangle = new Rectangle(5, 10);
            string expected = "Прямоугольник: Ширина = 5, Высота = 10";

            string result = rectangle.ToString();

            Assert.Equal(expected, result);
        }

        // 3. Проверка обработки некорректных данных
        [Theory]
        [InlineData(0, 5)]
        [InlineData(5, 0)]
        [InlineData(-1, 5)]
        [InlineData(5, -2)]
        public void Rectangle_InvalidDimensions_ShouldThrowException(double width, double height)
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
        }

        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(3, 0, 5)]
        [InlineData(3, 4, 0)]
        [InlineData(-1, 4, 5)]
        [InlineData(1, 1, 3)]
        [InlineData(5, 1, 2)]
        public void Triangle_InvalidSides_ShouldThrowException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }
    }
}