using System;

using Moq;
using Xunit;

namespace Test {

    public class FizzBuzzTest {
        [Fact]
        public void TestFizz() {

            Mock<consumer.Infrastructure.IServiceProxy> mockedProxy = new Mock<consumer.Infrastructure.IServiceProxy>();
            mockedProxy.Setup(g => g.GetValue()).Returns(84);

            consumer.FizzBuzz fb = new consumer.FizzBuzz();
            fb.ServiceProxy = mockedProxy.Object;

            int value = 0;
            string returnValue = fb.DoFizzBuzz(ref value);

            Assert.Equal(returnValue, "Fizz");

        }
    }
}
