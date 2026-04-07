namespace SlightlyOverBudget.Service;
public interface ITaxCalculator
{
    decimal ComputeGross(decimal hourlyRate, decimal hoursWorked);
    decimal ComputeTakeHome(decimal gross, decimal effectiveTaxRate);
}