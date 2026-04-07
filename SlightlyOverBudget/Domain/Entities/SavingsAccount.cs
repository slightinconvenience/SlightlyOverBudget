namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class SavingsAccount
{
    public Guid AccountId {get; init;}
    public string Name {get; init;} = string.Empty;
    public decimal CurrentBalance {get; set;}
    public decimal APY {get; init;}
    public DateOnly OpenDate {get; init;}
    public DateOnly LastUpdatedDate {get; init;}
}