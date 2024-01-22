using admin.model;

namespace admin.dal
{
    public class UserRepository:IUserRepository
    {
        private static List<admins> _users = new List<admins>
    {
        new admins {  username = "admin", password = "adminpassword" },
        new admins { username = "user",password ="userpassword"},
        new admins {username = "user1",password ="userspassword"}
        // Add more users as needed
    };

        public admins GetUserByUsername(string username)
        {
            return _users.Find(u => u.username == username);
        }
    }
}
