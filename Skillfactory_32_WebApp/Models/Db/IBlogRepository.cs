namespace Skillfactory_32_WebApp.Models.Db
{
    public interface IBlogRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}
