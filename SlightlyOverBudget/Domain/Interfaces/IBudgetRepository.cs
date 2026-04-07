using SlightlyOverBudget.Domain.Entities;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface IBudgetRepository
{
    Task<IEnumerable<Budget>> GetByMonthAsync(Guid profileId, int month, int year);
    Task<Budget?> GetByCategoryAndMonthAsync(Guid profileId, Guid categoryId, int month, int year);
    Task AddAsync(Guid profileId, Budget budget);
    Task AddRangeAsync(Guid profileId, IEnumerable<Budget> budgets);
    Task UpdateAsync(Guid profileId, Budget budget);
    Task DeleteAsync(Guid profileId, Guid budgetId);
}
