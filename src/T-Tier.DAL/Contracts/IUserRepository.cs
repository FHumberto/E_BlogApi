using T_Tier.DAL.Entities;

namespace T_Tier.DAL.Contracts;

public interface IUserRepository
{
    Task<bool> DeleteUserWithDependenciesAsync(string userId);
    Task<bool> SoftDeleteAsync(User user);
}