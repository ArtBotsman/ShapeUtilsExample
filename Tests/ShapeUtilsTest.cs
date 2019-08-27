using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeUtils;

// маленький пример тестов
// Сразу передупреждаю тэсты писал редко и могу что-то не знать
namespace Tests
{
    [TestClass]
    public class ShapeUtilsTest
    {
        [TestMethod]
        public void TestTriangle()
        {
            var expected = 6.78;
            var tr = new Triangle(4, 4, 7);
            Assert.AreEqual(tr.IsRightAngled(), false);            
            Assert.AreEqual(expected, Math.Round(tr.GetSquare(), 2));

            expected = 6;
            tr = new Triangle(3, 4, 5);
            Assert.AreEqual(tr.IsRightAngled(), true);
            Assert.AreEqual(expected, tr.GetSquare());
        }
    }
}
