namespace ExAbstratoProposto.Entities
{
    class CompanyTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public CompanyTaxPayer(string name, double anualIncome, int employee)
            :base(name, anualIncome)
        {
            Employees = employee;
        }

        public override double Taxes()
        {
            double taxe = (Employees <= 10) ? 0.16 : 0.14;
            return AnualIncome * taxe;
        }
    }
}
