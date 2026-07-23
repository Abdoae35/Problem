namespace VehicleRadar;
public class Violation
{
   

    public string? description { get; set; }
    public double fineAmount { get; set; }

    public Violation(string? description, double fineAmount)
    {
       
        this.description = description;
        this.fineAmount = fineAmount;
    }

  
}