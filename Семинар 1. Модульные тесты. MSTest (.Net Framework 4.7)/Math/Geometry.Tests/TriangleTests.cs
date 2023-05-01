using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Geometry.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(1, -2, -3)]
        [DataRow(-1, 2, 3)]
        [DataRow(1, -2, 3)]
        [DataRow(-1, -2, -3)]
        public void CreateNegative(float a, float b, float c)
        {
            Assert.ThrowsException<NegativeException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }
        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(3, 4, 4)]
        [DataRow(1, 1, 1)]
        public void CreateWrong(float a, float b, float c)
        {
            Assert.ThrowsException<UnexistingException>(() =>
            {
                var triangle = new Triangle(a, b, c);
            });
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        public void CreateRight(float a, float b, float c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreNotEqual(null, triangle);
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(3, 4, 5)]
        public void CheckSquare(float a, float b, float c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(triangle.s, 6);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(1, 1, 1, false)]
        public void CheckIsRectangular(float a, float b, float c, bool isRectangular)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(isRectangular, triangle.isRectangular);
        }

        [TestMethod]
        [DataRow(3, 3, 4, true)]
        [DataRow(3, 4, 3, true)]
        [DataRow(4, 3, 3, true)]
        [DataRow(3, 4, 5, false)]
        public void CheckIsIsosceles(float a, float b, float c, bool isIsosceles)
        {
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(isIsosceles, triangle.isIsosceles);
        }

        /*
TODO Добавьте в класс Triangle конструктор из трёх параметров - длины сторон треугольника a, b, c (Сделано)
TODO Убедитесь, что невозможно создать треугольник с неположительными сторонами (меньше либо равными нулю)  (Сделано)
TODO Убедитесь, что невозможно создать треугольник сумма двух сторон которого меньше третьей (Сделано)
TODO Убедитесь, что можно создать треугольник где сумма двух любых сторон больше либо равна третьей (Сделано)
TODO Добавьте свойство на чтение - площадь, реализуйте его (формула Герона) (Сделано)
TODO Проверьте получение значения площади через свойство для разных случаев  (Сделано)
TODO Добавьте свойство bool - является ли треугольник прямоугольным (Сделано)
TODO Проверьте работу свойства для прямоугольного и непрямоугольного треугольника (Сделано)
TODO Добавьте свойство bool - является ли треугольник равнобедренным (Сделано)
TODO Проверьте работу свойства для равнобедреннего и неравнобедренного треугольника (Сделано)
TODO Добавьте проверку на то, что треугольник может быть равнобедренным и прямоугольным одновременно (Сделано)
*/
    }
}
