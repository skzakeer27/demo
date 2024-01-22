using admin.model;

namespace admin.dal
{
    public interface IUserRepository
    {
        admins GetUserByUsername(string username);

    }
}
