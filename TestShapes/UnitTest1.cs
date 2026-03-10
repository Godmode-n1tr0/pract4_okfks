using System.Drawing;
using pract4_okfks;

namespace TestShape
{
    public class UnitTest1
    {
        [Fact]
        public void Create_Shape()
        {
            var rect = new pract4_okfks.Rectangle(4, 5);
            var triangle = new Triangle(3, 4, 5);

            Assert.NotNull(rect);
            Assert.NotNull(triangle);
        }
        [Fact]
        public void Rectagle_Area_Correct()
        {
            var rect = new pract4_okfks.Rectangle(4, 5);
            Assert.Equal(20, rect.Area());
        }
        [Fact]
        public void Rectagle_Perimetr_Correct()
        {
            var rect = new pract4_okfks.Rectangle(4, 5);
            Assert.Equal(18, rect.Perimeter());
        }
        [Fact]
        public void Rectangle_Inv_Data()
        {
            Assert.Throws<ArgumentException>(() => new pract4_okfks.Rectangle(-2, 5));
        }
        [Fact]
        public void Triangle_Area_Correct()
        {
            var rect = new Triangle(3, 4, 5);
            Assert.Equal(6, rect.Area());
        }
        [Fact]
        public void Triangle_Perimetr_Correct()
        {
            var rect = new Triangle(3, 4, 5);
            Assert.Equal(12, rect.Perimeter());
        }

        [Fact]
        public void Triangle_Inv_Data()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, -2, 5));
        }
    }
}