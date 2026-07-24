namespace VehicleRadar;

public class Program
{
    public static void Main(string[] args)
    {
       
        var radar = new QuRadar();
        var vehicle1 = new Vehicle("ABC123",DateTime.Now,VehicleType.Private , 80, true);
        var vehicle2 = new Vehicle("XYZ789",DateTime.Now,VehicleType.Truck , 200, false);

        radar.ObserveVehicle(vehicle1);
        radar.ObserveVehicle(vehicle2);
        
        
    }
      
}

