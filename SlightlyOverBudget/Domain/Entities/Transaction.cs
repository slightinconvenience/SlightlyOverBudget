namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class Transaction
{
  public Guid TransactionId {get; init;}
  public DateOnly Date {get; init;}
  public string? Notes {get; set;}
  public TransactionType Type {get; init;}
  public Guid? RecuringRuleId {get; init;}
}