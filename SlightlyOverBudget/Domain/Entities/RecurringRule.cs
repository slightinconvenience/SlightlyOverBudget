namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class RecurringRule
{
    public Guid RuleId {get; init;}
    public string Name {get; init;} = string.Empty;
    public TransactionType Type {get; init;}
    public RecurringFrequency Frequency {get; init;}
    public DateOnly StartDate {get; init;}
    public DateOnly? EndDate {get; init;}
    public DateOnly? LastGeneratedDate {get; init;}
}