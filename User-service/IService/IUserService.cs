using User_service.Entities;

namespace User_service.IService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> CreateUser(User user);

        Task<User> UpdateUser(User user);
        Task<bool> DeleteUser(int id);
    }
}
