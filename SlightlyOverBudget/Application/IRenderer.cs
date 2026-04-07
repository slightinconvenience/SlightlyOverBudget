namespace SLightlyOverBudget.Application;
using SlightlyOverBudget.Domain.Entities;
using SlightlyOverBudget.Service;
public interface IRenderer
{
    void ShowTransactionList(IEnumerable<Transaction> transactions, IEnumerable<TransactionSplit> splits, IEnumerable<Category> categories);
    void ShowMonthlySummary(MonthlySummary summary);
    void ShowBudgetStatus(IEnumerable<BudgetStatus> statuses);
    void ShowGoalProgress(IEnumerable<GoalProgress> goals);
    void ShowSavingsProjection(SavingsAccount account, int months);
    void ShowTakeHomeEstimate(decimal hours, decimal gross, decimal takeHome);
    void ShowCategoryList(IEnumerable<Category> categories);
    void ShowMessage(string message);
}