using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    // Define the interface
    public interface ICancellable
    {
        Task<bool> CanBeCancelledByAsync(User user);
    }

    // Base class for reservations implementing ICancellable
    public class BaseReservation : ICancellable
    {
        public User MadeBy { get; set; }

        public virtual async Task<bool> CanBeCancelledByAsync(User user)
        {
            await Task.Delay(500);

            return user.IsAdmin;
        }
    }

    // Reservation for standard users
    public class UserReservation : BaseReservation
    {
        public override async Task<bool> CanBeCancelledByAsync(User user)
        {
            await Task.Delay(500); // Simulate async work

            return user.IsAdmin || MadeBy == user;
        }
    }

    // Admin-specific reservation
    public class AdminReservation : BaseReservation
    {
        public override async Task<bool> CanBeCancelledByAsync(User user)
        {
            await Task.Delay(500);

            return user.IsAdmin;
        }
    }

    // User class
    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
