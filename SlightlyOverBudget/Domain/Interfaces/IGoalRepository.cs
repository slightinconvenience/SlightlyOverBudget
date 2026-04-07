using SlightlyOverBudget.Domain.Entities;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface IGoalRepository
{
    Task<IEnumerable<Goal>> GetAllAsync(Guid profileId);
    Task<Goal?> GetByIdAsync(Guid profileId, Guid goalId);
    Task AddAsync(Guid profileId, Goal goal);
    Task UpdateAsync(Guid profileId, Goal goal);
    Task DeleteAsync(Guid profileId, Guid goalId);
}
