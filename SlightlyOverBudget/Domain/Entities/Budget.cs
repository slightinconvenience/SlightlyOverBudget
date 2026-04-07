namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class Budget
{
    public Guid BudgetId {get; init;}
    public Guid CategoryId {get; init;}
    public int Month {get; init;}
    public int Year {get; init;}
    public decimal Amount {get; init;}
}