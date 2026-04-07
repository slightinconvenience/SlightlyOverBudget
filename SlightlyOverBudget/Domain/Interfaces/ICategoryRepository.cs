using SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllAsync(Guid profileId);
    Task<IEnumerable<Category>> GetByTypeAsync(Guid profileId, CategoryType type);
    Task<Category?> GetByIdAsync(Guid profileId, Guid categoryId);
    Task AddAsync(Guid profileId, Category category);
    Task UpdateAsync(Guid profileId, Category category);
    Task DeleteAsync(Guid profileId, Guid categoryId);
}
