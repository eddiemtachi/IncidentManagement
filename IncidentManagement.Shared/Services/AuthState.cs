namespace IncidentManagement.Shared.Services
{
    public class AuthState
    {
        public bool IsLoggedIn { get; private set; }
        public string? CurrentUser { get; private set; }
        public string? CurrentUserRole { get; private set; }

        public void Login(string user, string role)
        {
            IsLoggedIn = true;
            CurrentUser = user;
            CurrentUserRole = role;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            CurrentUser = null;
            CurrentUserRole = null;
        }
    }
}
