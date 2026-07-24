namespace VehicleRadar;

public class Program
{
    public static void Main(string[] args)
    {
       
        var radar = new Radar();

        //Data for testing
        var vehicle1 = new Vehicle("ABC123",DateTime.Now,VehicleType.Private , 200, false);
        var vehicle2 = new Vehicle("XYZ789",DateTime.Now,VehicleType.Truck , 200, true);


        //observe vehicles and check for violations
        radar.ObserveVehicle(vehicle1);
        radar.ObserveVehicle(vehicle2);

        //get all violated rules with their counts
        radar.GetAllViolatedRules();
        
        
    }
      
}

