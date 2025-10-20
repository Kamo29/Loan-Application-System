namespace PRG281Project
{
   public interface ILoanConst
{
    int shortTerm { get; }
    int medTerm { get; }
    int longTerm { get; }
    int maxAmount { get; }
    string compName { get; }

        string ToString();
    }

public class LoanConst : ILoanConst
{
    public int shortTerm => 1;
    public int medTerm => 3;
    public int longTerm => 5;
    public int maxAmount => 100000;
    public string compName => "Loan Company";
}
}
