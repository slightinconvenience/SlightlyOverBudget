namespace SlightlyOverBudget.Domain.Interfaces;
using SlightlyOverBudget.Domain.Entities;
public interface IUserConfigRepository
{
    Task<UserConfig?> GetAsync(Guid profileId);
    Task SaveAsync(UserConfig config);
}
