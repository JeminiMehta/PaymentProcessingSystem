using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Payment_Processing_System.Tests
{
    [TestClass]
    public class PhysicalProductTest
    {
        /// <summary>
        /// HandleOrder method test for PhysicalProduct
        /// </summary>
        [TestMethod]
        public void PhysicalProductTest_HandleOrder_ShouldReturn_Rule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock
                mock.Mock<IPayment>().Setup(x => x.HandleOrder()).Returns("generate a packing slip for shipping , generate a commission payment to the agent.");
                var sut = mock.Create<PhysicalProduct>();

                // Act
                var actual = sut.HandleOrder();

                // Assert - assert on the mock
                Assert.AreEqual("generate a packing slip for shipping , generate a commission payment to the agent.", actual);
            }
        }

        /// <summary>
        /// HandleOrder method test for Book
        /// </summary>
        [TestMethod]
        public void BookTest_HandleOrder_ShouldReturn_Rule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock
                mock.Mock<IPayment>().Setup(x => x.HandleOrder()).Returns("create a duplicate packing slip for the royalty department , generate a commission payment to the agent.");
                var sut = mock.Create<Book>();

                // Act
                var actual = sut.HandleOrder();

                // Assert - assert on the mock
                Assert.AreEqual("create a duplicate packing slip for the royalty department , generate a commission payment to the agent.", actual);
            }
        }

        /// <summary>
        /// HandleOrder method test for MemberShip
        /// </summary>
        [TestMethod]
        public void MemberShipTest_HandleOrder_ShouldReturn_Rule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock
                mock.Mock<IPayment>().Setup(x => x.HandleOrder()).Returns("activate that membership , e-mail the owner and inform them of the activation/upgrade.");
                var sut = mock.Create<MemberShip>();

                // Act
                var actual = sut.HandleOrder();

                // Assert - assert on the mock
                Assert.AreEqual("activate that membership , e-mail the owner and inform them of the activation/upgrade.", actual);
            }
        }

        /// <summary>
        /// HandleOrder method test for Upgrade MemberShip
        /// </summary>
        [TestMethod]
        public void UpgradeMemberShipTest_HandleOrder_ShouldReturn_Rule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock
                mock.Mock<IPayment>().Setup(x => x.HandleOrder()).Returns("apply the upgrade , e-mail the owner and inform them of the activation/upgrade.");
                var sut = mock.Create<UpgradeMemberShip>();

                // Act
                var actual = sut.HandleOrder();

                // Assert - assert on the mock
                Assert.AreEqual("apply the upgrade , e-mail the owner and inform them of the activation/upgrade.", actual);
            }
        }

        /// <summary>
        /// HandleOrder method test for Video "Learning to Ski"
        /// </summary>
        [TestMethod]
        public void VideoLearningtoSkiTest_HandleOrder_ShouldReturn_Rule()
        {
            using (var mock = AutoMock.GetLoose())
            {
                // Arrange - configure the mock
                mock.Mock<IPayment>().Setup(x => x.HandleOrder()).Returns("add a free “First Aid” video to the packing slip (the result of a court decision in 1997).");
                var sut = mock.Create<VideoLearningtoSki>();

                // Act
                var actual = sut.HandleOrder();

                // Assert - assert on the mock
                Assert.AreEqual("add a free “First Aid” video to the packing slip (the result of a court decision in 1997).", actual);
            }
        }
    }
}
