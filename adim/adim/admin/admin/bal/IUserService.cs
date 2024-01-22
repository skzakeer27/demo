using admin.model;

namespace admin.bal
{
    public interface IUserService
    {
        admins AuthenticateUser(string username, string password);
    }
}
