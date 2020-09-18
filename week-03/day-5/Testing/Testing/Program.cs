using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace Testing
{
    public class Program
    {
        static void Main()
        {
        }
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Addition(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Addition(2, 2));
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }

        [Fact]
        public void FirstTest()
        {
            int expected = 0;
            int result = Addition(0, 0);

            Assert.Equal(expected, result);
        }
    }
}
