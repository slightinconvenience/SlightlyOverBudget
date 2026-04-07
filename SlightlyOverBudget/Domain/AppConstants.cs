namespace SlightlyOverBudget.Domain;
public static class AppConstants
{
    // Display
    public const string CurrencySymbol        = "$";
    public const string DateFormat            = "MM/dd/yyyy";
    public const string MonthYearFormat       = "MMMM yyyy";

    // Category defaults — seeded on first run
    public const string DefaultIncomeCategories  = "Salary,Freelance,Rental Income,Investment Income,Other Income";
    public const string DefaultExpenseCategories = "Rent,Groceries,Utilities,Transportation,Dining,Entertainment,Healthcare,Clothing,Household,Subscriptions,Other Expense";

    // Category color palette (Spectre.Console color names)
    public static readonly string[] AllowedColors =
    {
        "red", "green", "blue", "yellow", "cyan", "magenta",
        "orange1", "purple", "grey", "white"
    };

    // Projections
    public const int ProjectionMonthsDefault  = 12;

    // Budget
    public const int BudgetSeedLookbackMonths = 1;

    // Reporting
    public const int RecentTransactionCount   = 25;

    // Recurring
    public const int RecurringLookAheadDays   = 0;  // lazy: generate up to today only

    // Roster / validation
    public const decimal MinHourlyRate        = 0m;
    public const decimal MaxHourlyRate        = 9999m;
    public const decimal MinEffectiveTaxRate  = 0m;
    public const decimal MaxEffectiveTaxRate  = 0.99m;
}