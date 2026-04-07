namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class RecurringRuleSplit
{
    public Guid RuleSplitId {get; init;} 
    public Guid RuleId {get; init;}
    public Guid CategoryId {get; init;}
    public decimal Amount {get; init;}
}