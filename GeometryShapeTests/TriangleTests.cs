using System;
using Xunit;
using GeometryShape;

namespace GeometryShapeTests
{
    public class TriangleTests
    {

        [Fact]
        public void Triangle_Area_ShouldReturnCorrectValue()
        {

            var triangle = new Triangle(3, 4, 5);
            double expected = 6; 
            double result = triangle.Area();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Triangle_Perimeter_ShouldReturnCorrectValue()
        {
  
            var triangle = new Triangle(3, 4, 5);
            double expected = 13; 
            double result = triangle.Perimeter();
            Assert.Equal(expected, result);
        }
    }
}