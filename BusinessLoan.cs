namespace PRG281Project
{
    public class BusinessLoan: Loan
    {
        public BusinessLoan(int loanNum, string cusLName, string cusFName, int loanAmount, int term, double intRate) : base(loanNum, cusLName, cusFName, loanAmount, term, intRate)
        {
            interestRate(intRate);
        }

        public override double adjustedIntRate()
        {
            return IntRate += 0.2;
        }
    }
}
