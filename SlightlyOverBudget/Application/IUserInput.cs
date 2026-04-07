namespace SLightlyOverBudget.Application;
public interface IUserInput
{
    string PromptText(string label);
    decimal PromptDecimal(string label);
    DateOnly PromptDate(string label);
    T PromptChoice<T>(string label, IEnumerable<T> options);
    bool PromptConfirm(string label);
}