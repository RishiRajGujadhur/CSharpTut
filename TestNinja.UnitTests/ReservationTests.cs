using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanbeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            bool result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task CanbeCancelledByAsync_UserIsAdmin_ReturnsTrueAsync()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            bool result = await reservation.CanBeCancelledByAsync(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

    }
}
