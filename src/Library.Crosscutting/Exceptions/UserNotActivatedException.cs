using System.Security.Authentication;

namespace lab.Crosscutting.Exceptions {
    public class UserNotActivatedException : AuthenticationException {
        public UserNotActivatedException(string message) : base(message)
        {
        }
    }
}
