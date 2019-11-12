using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestArea.Tests
{
    [TestClass]
    public class TestAreaTests
    {
        [TestMethod]
        //Площадь круга с радиусом 5
        public void CircleArea_radius_5()
        {
            double radius = 5;
            double expected = 78.54;
            AreaDLL ar = new AreaDLL();
            double actual = ar.Circle(radius);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Площадь прямоугольного треугольника со сторонами 3; 4; 5
        public void CircleTriangle_3_4_5()
        {
            double a = 3;
            double b = 4;
            double c = 5;           
            object expected = Tuple.Create(6.0, true);//Ожидаемое значение
            AreaDLL ar = new AreaDLL();            
            object actual = ar.Triangle(a, b, c);//Фактическое значение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Площадь треугольника со сторонами 5.5; 7.7; 8.8
        public void CircleTriangle_5_7_8()
        {
            double a = 5.5;
            double b = 7.7;
            double c = 8.8;
            object expected = Tuple.Create(20.96, false);//Ожидаемое значение
            AreaDLL ar = new AreaDLL();
            object actual = ar.Triangle(a, b, c);//Фактическое значение
            Assert.AreEqual(expected, actual);
        }
    }
}
