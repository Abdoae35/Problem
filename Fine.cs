using VehicleRadar;

public class Fine
{
     public Fine(string plateNumber,double totalFineAmount)
     {
          this.plateNumber = plateNumber;
          this.totalFineAmount = totalFineAmount;
     }
     public string? plateNumber { get; set; }
     public double totalFineAmount { get; set; }
     public static List<Violation> violations { get; set; } = new List<Violation>();

     public static void addViolation(Violation violation)
     {
          violations.Add(violation);
     }

    public  void printFine()
    {
        Console.WriteLine($"Plate Number: {plateNumber}");
        Console.WriteLine($"Total Fine Amount: {totalFineAmount}");
        Console.WriteLine($"Violations: {violations.Count}");
        foreach (var violation in violations)
        {
            Console.WriteLine($"- {violation.description} (Fine: {violation.fineAmount})");
        }
    }


    


}





