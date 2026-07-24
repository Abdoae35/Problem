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

    public void printFine()
    {
        Console.WriteLine($"Traffic for car: {plateNumber}");
        Console.WriteLine($"Total Fine Amount: {totalFineAmount}");
        Console.WriteLine($"Violations: {violations.Count}");
        foreach (var violation in violations)
        {
            Console.WriteLine($"- {violation.description} : {violation.fineAmount} EGP");
        }
    }

    public void getAllFines()

    {
        Console.WriteLine();
        Console.WriteLine($"Get all fines for car: {plateNumber}");
        Console.WriteLine($"Plate Number: {plateNumber}");
        Console.WriteLine($"Total Fine Amount: {totalFineAmount}");
        
    }


    


}





