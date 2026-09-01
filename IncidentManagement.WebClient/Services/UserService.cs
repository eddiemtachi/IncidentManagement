using IncidentManagement.Shared.Models;

namespace IncidentManagement.WebClient.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();

        // Expose users as read-only so consumers can’t modify directly
        public IReadOnlyList<User> Users => _users;

        public UserService()
        {
            // Seed mock users
            _users.AddRange(new List<User>
            {
                new User
                {
                    UserId = 1,
                    Username = "Edward Mtachi",
                    Email = "admin@ims.com",
                    Password = "test01",
                    PhoneNumber = "0721234567",
                    WhatsAppNumber = "0721234567",
                    Role = "Admin",
                    Roles = new List<string> { "Admin" },
                    IsActive = true
                },
                new User
                {
                    UserId = 2,
                    Username = "Real Madrid",
                    Email = "manager01@example.com",
                    Password = "test01",
                    PhoneNumber = "0739876543",
                    WhatsAppNumber = "",
                    Role = "Estate Manager",
                    Roles = new List<string> { "Estate Manager" },
                    IsActive = true
                },
                new User
                {
                    UserId = 3,
                    Username = "John Wick",
                    Email = "admin01@example.com",
                    Password = "test01",
                    PhoneNumber = "",
                    WhatsAppNumber = "0745555555",
                    Role = "Admin",
                    Roles = new List<string> { "Admin" },
                    IsActive = true
                },
                new User
                {
                    UserId = 4,
                    Username = "Manchester United",
                    Email = "inactive@example.com",
                    Password = "test01",
                    PhoneNumber = "0711111111",
                    WhatsAppNumber = "",
                    Role = "Tenant",
                    Roles = new List<string> { "Tenant" },
                    IsActive = false
                }
            });
        }

        /// <summary>
        /// Adds a new user to the mock list (used by Sign Up).
        /// Mimics async API call for future database integration.
        /// </summary>
        public Task<User> CreateUserAsync(User user)
        {
            user.UserId = _users.Any() ? _users.Max(u => u.UserId) + 1 : 1;
            user.IsActive = true;

            // Ensure Roles list is initialized
            if (user.Roles == null || !user.Roles.Any())
                user.Roles = new List<string> { user.Role };

            _users.Add(user);

            return Task.FromResult(user);
        }

        /// <summary>
        /// Adds a user directly (synchronous).
        /// </summary>
        public void AddUser(User user)
        {
            user.UserId = _users.Any() ? _users.Max(u => u.UserId) + 1 : 1;
            user.IsActive = true;

            if (user.Roles == null || !user.Roles.Any())
                user.Roles = new List<string> { user.Role };

            _users.Add(user);
        }

        /// <summary>
        /// Soft delete (deactivate) a user.
        /// </summary>
        public void SoftDeleteUser(long userId)
        {
            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                user.IsActive = false;
            }
        }

        /// <summary>
        /// Reactivate a user.
        /// </summary>
        public void ReactivateUser(long userId)
        {
            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                user.IsActive = true;
            }
        }

        /// <summary>
        /// Update user details including roles.
        /// </summary>
        public void UpdateUser(User updatedUser)
        {
            var existing = _users.FirstOrDefault(u => u.UserId == updatedUser.UserId);
            if (existing != null)
            {
                existing.Username = updatedUser.Username;
                existing.Email = updatedUser.Email;
                existing.PhoneNumber = updatedUser.PhoneNumber;
                existing.WhatsAppNumber = updatedUser.WhatsAppNumber;

                // Keep both Role (single) and Roles (list) in sync
                existing.Roles = updatedUser.Roles ?? new List<string>();
                existing.Role = existing.Roles.FirstOrDefault() ?? string.Empty;
            }
        }
    }
}
