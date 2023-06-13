using ConsoleClassLibrary;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Quality q = new Quality(10, 10, 10);
            double Actual = q.qCalculation();
            double Total = 10;
            Assert.AreEqual(Total, Actual);
        }
        [Test]
        public void Test2()
        {
            Quality q = new Quality(14, 15, 20.5);
            double Actual = q.qCalculation();
            double Total = 43.05;
            Assert.AreEqual(Total, Actual);
        }
        [Test]
        public void Test3()
        {
            Quality q = new Quality(5, 10, 15);
            double Actual = q.qCalculation();
            double Total = 7.5;
            Assert.AreEqual(Total, Actual);
        }
        [Test]
        public void Test4()
        {
            Quality q = new Quality(12, 34, 12);
            double Actual = q.qCalculation();
            double Total = 48.96;
            Assert.AreEqual(Total, Actual);
        }
    }
}