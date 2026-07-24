namespace VehicleRadar;
public class Violation
{
   

    public string? description { get; set; }
    public string? category { get; set; }
    public double fineAmount { get; set; }

    public Violation(string? description, double fineAmount, string? category)
    {
       
        this.description = description;
        this.fineAmount = fineAmount;
        this.category = category;
    }

    public static string seatBelt = "SeatBelt Is not fastened";
    public static string speedLimit = "Speed Limit Exceeded";


    

  
}