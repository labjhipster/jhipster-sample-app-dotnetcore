using lab.Crosscutting.Constants;

namespace lab.Crosscutting.Exceptions {
    public class EmailNotFoundException : BaseException {
        public EmailNotFoundException() : base(ErrorConstants.EmailNotFoundType, "Email address not registered")
        {
        }
    }
}
