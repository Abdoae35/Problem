
class Violation
{
    public string RuleName { get; set; }
    public string Description { get; set; }
    public int PenaltyPoints { get; set; }
    public decimal FineAmount { get; set; }

    public Violation(string ruleName, string description, int penaltyPoints, decimal fineAmount)
    {
        RuleName = ruleName;
        Description = description;
        PenaltyPoints = penaltyPoints;
        FineAmount = fineAmount;
    }
}