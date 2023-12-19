namespace ExAbstratoProposto.Entities
{
    class IndividualTaxPayer : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualTaxPayer(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double taxe = (AnualIncome < 20000.00) ? 0.15 : 0.25;
            return (AnualIncome * taxe) - (HealthExpenditures * 0.5);
        }

    }
}
