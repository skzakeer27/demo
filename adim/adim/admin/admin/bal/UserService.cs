using admin.dal;
using admin.model;

namespace admin.bal
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public admins AuthenticateUser(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);

            // Simple authentication, check if user exists and password matches
            if (user != null && user.password == password)
            {
                return user;
            }

            return null;
        }
    }
}
