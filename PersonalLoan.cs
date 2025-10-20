namespace PRG281Project
{
    internal class PersonalLoan : Loan
    {
        public PersonalLoan(int loanNum, string cusLName, string cusFName, int loanAmount, int term, double intRate) : base(loanNum, cusLName, cusFName, loanAmount, term, intRate)
        {
            interestRate(intRate);
        }

        public override double adjustedIntRate()
        {
            return IntRate += 0.01;
        }
    }
}
