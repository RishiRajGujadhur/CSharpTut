using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }

        public async Task<bool> CanBeCancelledByAsync(User user)
        {
            // Simulate some async work like querying a database or an external service
            await Task.Delay(1000);

            return (user.IsAdmin || MadeBy == user);
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}