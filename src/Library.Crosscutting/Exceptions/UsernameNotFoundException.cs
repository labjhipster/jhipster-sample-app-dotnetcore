using System.Security.Authentication;

namespace lab.Crosscutting.Exceptions {
    public class UsernameNotFoundException : AuthenticationException {
        public UsernameNotFoundException(string message) : base(message)
        {
        }
    }
}
