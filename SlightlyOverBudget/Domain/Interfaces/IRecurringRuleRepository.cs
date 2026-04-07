using SlightlyOverBudget.Domain.Entities;

namespace SlightlyOverBudget.Domain.Interfaces;

public interface IRecurringRuleRepository
{
    Task<IEnumerable<RecurringRule>> GetAllAsync(Guid profileId);
    Task<IEnumerable<RecurringRule>> GetActiveAsync(Guid profileId, DateOnly asOf);
    Task<RecurringRule?> GetByIdAsync(Guid profileId, Guid ruleId);
    Task AddAsync(Guid profileId, RecurringRule rule);
    Task UpdateAsync(Guid profileId, RecurringRule rule);
    Task UpdateLastGeneratedDateAsync(Guid profileId, Guid ruleId, DateOnly date);
    Task DeleteAsync(Guid profileId, Guid ruleId);

    Task<IEnumerable<RecurringRuleSplit>> GetSplitsAsync(Guid profileId, Guid ruleId);
    Task AddSplitAsync(Guid profileId, RecurringRuleSplit split);
    Task AddSplitsAsync(Guid profileId, IEnumerable<RecurringRuleSplit> splits);
    Task DeleteSplitsByRuleAsync(Guid profileId, Guid ruleId);
}
