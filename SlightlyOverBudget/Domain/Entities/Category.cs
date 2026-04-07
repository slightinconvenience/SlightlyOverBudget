namespace SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Domain.Enums;
public class Category
{
    public Guid CategoryId {get; init;}
    public string Name {get; init;} = string.Empty;
    public CategoryType Type {get; init;}
    public string Color {get; init;} = string.Empty;
    public string Icon {get; init;} = string.Empty;
    public bool IsDefault {get; init;}
}