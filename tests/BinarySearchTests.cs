using NUnit.Framework;
using src;

namespace tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        private readonly int[] _arrayEmpty = { };
        private readonly int[] _arrayOfOne = {1};
        private readonly int[] _arrayOfThree = {1, 3, 5};
        private readonly int[] _arrayOfFour = {1, 3, 5, 7};

        [Test]
        public void TestEmpty()
        {
            Assert.AreEqual(-1, BinarySearch.Chop(3, _arrayEmpty));
        }

        [Test]
        public void TestSingle()
        {
            Assert.AreEqual(-1, BinarySearch.Chop(3, _arrayOfOne));
            Assert.AreEqual(0, BinarySearch.Chop(1, _arrayOfOne));
        }

        [Test]
        public void TestTripleFirst()
        {
            Assert.AreEqual(0, BinarySearch.Chop(1, _arrayOfThree));
        }

        [Test]
        public void TestTripleSecond()
        {
            Assert.AreEqual(1, BinarySearch.Chop(3, _arrayOfThree));
        }

        [Test]
        public void TestTripleThird()
        {
            Assert.AreEqual(2, BinarySearch.Chop(5, _arrayOfThree));
        }

        [Test]
        public void TestTripleNotFound()
        {
            Assert.AreEqual(-1, BinarySearch.Chop(0, _arrayOfThree));
            Assert.AreEqual(-1, BinarySearch.Chop(2, _arrayOfThree));
            Assert.AreEqual(-1, BinarySearch.Chop(4, _arrayOfThree));
            Assert.AreEqual(-1, BinarySearch.Chop(6, _arrayOfThree));
        }

        [Test]
        public void TestQuadripleFindFirst()
        {
            Assert.AreEqual(0, BinarySearch.Chop(1, _arrayOfFour));
        }

        [Test]
        public void TestQuadripleFindSecond()
        {
            Assert.AreEqual(1, BinarySearch.Chop(3, _arrayOfFour));
        }

        [Test]
        public void TestQuadripleFindThird()
        {
            Assert.AreEqual(2, BinarySearch.Chop(5, _arrayOfFour));
        }

        [Test]
        public void TestQuadripleFindFourth()
        {
            Assert.AreEqual(3, BinarySearch.Chop(7, _arrayOfFour));
        }

        [Test]
        public void TestQuadripleNotFound()
        {
            Assert.AreEqual(-1, BinarySearch.Chop(0, _arrayOfFour));
            Assert.AreEqual(-1, BinarySearch.Chop(2, _arrayOfFour));
            Assert.AreEqual(-1, BinarySearch.Chop(4, _arrayOfFour));
            Assert.AreEqual(-1, BinarySearch.Chop(6, _arrayOfFour));
            Assert.AreEqual(-1, BinarySearch.Chop(8, _arrayOfFour));
        }
    }
}