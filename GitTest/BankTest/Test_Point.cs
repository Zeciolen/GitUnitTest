using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointLib;

namespace GitTests
{
    /// <summary>
    /// Summary description for Test
    /// </summary>
    [TestClass]
    public class Test_Point
    {
        public Test_Point()
        {

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestConstructors()
        {
            int one = 1;
            int two = 2;
            Point newPoint_0 = new Point();
            Point newPoint_1 = new Point(one, two);

            Assert.IsNotNull(newPoint_0);
            Assert.IsNotNull(newPoint_1);
        }

        [TestMethod]
        public void TestGetX()
        {
            int one = 1;
            int two = 2;
            Point newPoint_1 = new Point(one, two);

            Assert.AreEqual(1, newPoint_1.getX());
        }

        [TestMethod]
        public void TestGetY()
        {
            int one = 1;
            int two = 2;
            Point newPoint_1 = new Point(one, two);

            Assert.AreEqual(2, newPoint_1.getY());
        }

        [TestMethod]
        public void TestStretch()
        {
            int one = 1;
            int two = 2;
            Point newPoint_1 = new Point(one, two);
            Point newPoint_2 = new Point(one + 1, two + 2);

            newPoint_1.stretch(2);
            newPoint_2.stretch(4);

            Assert.AreEqual(2, newPoint_1.getX());
            Assert.AreEqual(4, newPoint_1.getY());
            Assert.AreEqual(8, newPoint_2.getX());
            Assert.AreEqual(16, newPoint_2.getY());
        }

        [TestMethod]
        public void TestDistance()
        {
            int one = 1;
            int two = 2;
            Point newPoint_1 = new Point(one, two);
            Point newPoint_2 = new Point(one + 1, two + 2);

            Assert.AreEqual(0, newPoint_1.distance(newPoint_1));
            Assert.AreEqual(2.24, newPoint_1.distance(newPoint_2));
        }

        [TestMethod]
        public void TestRotate()
        {
            Point newPoint_1 = new Point(1, 0);
            newPoint_1.rotate(90);

            Assert.AreEqual(0, Math.Round(newPoint_1.getX(), 0));
            Assert.AreEqual(1, Math.Round(newPoint_1.getY(), 0));
        }

        [TestMethod]
        public void TestToString()
        {
            Point newPoint_1 = new Point(1, 2);
            string aString = newPoint_1.toString();

            Assert.AreEqual("(1.0, 2.0)", aString);
        }

        [TestMethod]
        public void TestLessThanOp()
        {
            Point newPoint_1 = new Point(1, 1);
            Point newPoint_2 = new Point(5, 5);

            Assert.IsTrue(newPoint_1 < newPoint_2);
            Assert.IsFalse(newPoint_2 < newPoint_1);
        }

        [TestMethod]
        public void TestGreatThanOp()
        {
            Point newPoint_1 = new Point(1, 1);
            Point newPoint_2 = new Point(5, 5);

            Assert.IsFalse(newPoint_1 > newPoint_2);
            Assert.IsTrue(newPoint_2 > newPoint_1);
        }
    }
}
