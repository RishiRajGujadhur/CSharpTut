using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public async Task CanbeCancelledByAsync_UserIsAdmin_ReturnsTrueAsync()
        {
            // Arrange
            var reservation = new AdminReservation();

            //  Act
            bool result = await reservation.CanBeCancelledByAsync(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public async Task CanbeCancelledByAsync_UserIsNotAdmin_ReturnsTrueAsync()
        {
            // Arrange
            var reservation = new UserReservation();

            // Act
            bool result = await reservation.CanBeCancelledByAsync(new User { IsAdmin = false });

            // Assert
            Assert.IsFalse(result);
        }

    }
}
