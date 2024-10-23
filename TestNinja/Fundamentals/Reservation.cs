using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    // Base class for reservations
    public abstract class BaseReservation
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

    public class AdminReservation : BaseReservation
    {
        // Overriding with different rules for admin reservations
        public override async Task<bool> CanBeCancelledByAsync(User user)
        {
            await Task.Delay(500); 

            return user.IsAdmin;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
