namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class UserConfig
{
    public Guid ProfileId {get; init;}
    public decimal HourlyRate {get; set;}
    public decimal EffectiveTaxRate {get; set;}
    public string DefaultCurrency {get; set;} = string.Empty;
}