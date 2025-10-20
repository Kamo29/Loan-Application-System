namespace PRG281Project
{
    public abstract class Loan : LoanConst
    {
        private int loanNum;
        private string cusLName;
        private string cusFName;
        private int loanAmount;
        private double intRate;
        private int term;

        public Loan(int loanNum, string cusLName, string cusFName, int loanAmount, int term, double intRate)
        {
            this.LoanNum = loanNum;
            this.CusLName = cusLName;
            this.CusFName = cusFName;
            this.LoanAmount = loanAmount;
            this.Term = term;
            this.IntRate = intRate;

            if(this.Term != shortTerm && this.Term != medTerm && this.Term != longTerm)
            {
                this.Term = 1;
            }
        }

        public int LoanNum { get => loanNum; set => loanNum = value; }
        public string CusLName { get => cusLName; set => cusLName = value; }
        public string CusFName { get => cusFName; set => cusFName = value; }
        public int LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double IntRate { get => intRate; set => intRate = value; }
        public int Term { get => term; set => term = value; }

        //checking if the loan amount is not over the max
        public override string ToString()
        {
            if (LoanAmount > maxAmount)
            {
                return "Ivalid input for loan, it is over the maximum amount of 100000";
                Console.Clear();
            }

            else
            {
                return $"Comapny Name: {compName}\nLoan Number: {loanNum}\nCustomer: {cusFName} {CusLName}\nLoan Amount: R{LoanAmount}\nInterest Rate: {IntRate}%\nLoan Term: {term} years\nAmount Owed: R{amountOwed(loanAmount, IntRate, term)}";
            }
        }

        public double amountOwed(int loanAmount, double intRate, int term)
        {
            double debt = 0;
            
            // Calculate the loan fee based on the interest rate and loan duration
            double interestAmount = (LoanAmount * IntRate / 100) * Term;
            double loanFee = LoanAmount + interestAmount;

            // Add the original loan amount and loan fee to the total amount owed
           debt += loanFee;
           

            return debt;
        }

        //calculation to adjust the interest rate
        public void interestRate(double intRate)
        {
            IntRate = Math.Round(intRate + adjustedIntRate());
        }
         
        public abstract double adjustedIntRate();//being overridden by the other methods in Personal and Business
    }
}
