using SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllAsync(Guid profileId);
    Task<IEnumerable<Transaction>> GetByMonthAsync(Guid profileId, int month, int year);
    Task<IEnumerable<Transaction>> GetByTypeAsync(Guid profileId, TransactionType type);
    Task<Transaction?> GetByIdAsync(Guid profileId, Guid transactionId);
    Task AddAsync(Guid profileId, Transaction transaction);
    Task UpdateAsync(Guid profileId, Transaction transaction);
    Task DeleteAsync(Guid profileId, Guid transactionId);
}
