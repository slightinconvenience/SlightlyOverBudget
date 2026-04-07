using SlightlyOverBudget.Domain.Entities;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface ISavingsAccountRepository
{
    Task<IEnumerable<SavingsAccount>> GetAllAsync(Guid profileId);
    Task<SavingsAccount?> GetByIdAsync(Guid profileId, Guid accountId);
    Task AddAsync(Guid profileId, SavingsAccount account);
    Task UpdateAsync(Guid profileId, SavingsAccount account);
    Task DeleteAsync(Guid profileId, Guid accountId);
}
