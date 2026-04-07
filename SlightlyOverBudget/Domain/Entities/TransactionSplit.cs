namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class TransactionSplit
{
    public Guid SplitId {get; init;}
    public Guid TransactionId {get; init;}
    public Guid CategoryId {get; init;}
    public decimal Amount {get; init;}
}