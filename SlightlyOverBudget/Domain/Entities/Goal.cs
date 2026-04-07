namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class Goal
{
    public Guid GoalId {get; init;}
    public string Name {get; init;} = string.Empty;
    public decimal TargetAmount {get; init;}
    public DateOnly? Deadline {get; init;}
    public Guid LinkedCategoryId {get; init;}
}