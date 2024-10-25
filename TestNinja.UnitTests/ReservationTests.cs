using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        private readonly ICancellable _reservation;

        // Constructor injection
        public ReservationTests(ICancellable reservation)
        {
            _reservation = reservation;
        }

        [TestMethod]
        public async Task CanBeCancelledByAsync_UserIsAdmin_ReturnsTrueAsync()
        {
            // Arrange
            var adminUser = new User { IsAdmin = true };

            // Act
            bool result = await _reservation.CanBeCancelledByAsync(adminUser);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task CanBeCancelledByAsync_UserIsNotAdmin_ReturnsTrueAsync()
        {
            // Arrange
            var adminUser = new User { IsAdmin = false };

            // Act
            bool result = await _reservation.CanBeCancelledByAsync(adminUser);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
