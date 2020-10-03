using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payment_Processing_System.Tests
{
    [TestClass]
    public class PhysicalProductTest
    {
        [TestMethod]
        public void PhysicalProductTest_HandleOrder_ShouldReturn_Rule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock
                mock.Mock<IPayment>().Setup(x => x.HandleOrder()).Returns("generate a packing slip for shipping , generate a commission payment to the agent");
                var sut = mock.Create<PhysicalProduct>();

                // Act
                var actual = sut.HandleOrder();

                // Assert - assert on the mock
                Assert.AreEqual("generate a packing slip for shipping , generate a commission payment to the agent", actual);
            }
        }
    }
}
