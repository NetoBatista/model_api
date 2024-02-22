namespace Model.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        string Get(string userId);
        bool Add(string userName);
        bool Update(string userName, string userId);
        bool Delete(string userId);
    }
}
