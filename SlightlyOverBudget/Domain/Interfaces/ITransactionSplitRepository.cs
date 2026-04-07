using SlightlyOverBudget.Domain.Entities;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface ITransactionSplitRepository
{
    Task<IEnumerable<TransactionSplit>> GetByTransactionAsync(Guid profileId, Guid transactionId);
    Task<IEnumerable<TransactionSplit>> GetByMonthAsync(Guid profileId, int month, int year);
    Task<IEnumerable<TransactionSplit>> GetByCategoryAsync(Guid profileId, Guid categoryId);
    Task AddAsync(Guid profileId, TransactionSplit split);
    Task AddRangeAsync(Guid profileId, IEnumerable<TransactionSplit> splits);
    Task DeleteByTransactionAsync(Guid profileId, Guid transactionId);
}
