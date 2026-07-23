namespace VehicleRadar;

public class Vehicle
{

  
    public Vehicle(string? plateNumber, DateTime? date, VehicleType? vehicleType, double speed, bool seatBelt)
    {
        this.plateNumber = plateNumber;
        this.date = date;
        this.vehicleType = vehicleType;
        this.speed = speed;
        this.seatBelt = seatBelt;
    }

   public string? plateNumber { get; set; }
   public DateTime? date { get; set; }
   public VehicleType? vehicleType { get; set; }
   public double speed { get; set; }
   public bool seatBelt { get; set; } 



    
}

public enum VehicleType
{
    Private,
    Truck,
    Bus
    
}