using lab.Crosscutting.Constants;

namespace lab.Crosscutting.Exceptions {
    public class InternalServerErrorException : BaseException {
        public InternalServerErrorException(string message) : base(ErrorConstants.DefaultType, message)
        {
        }
    }
}
