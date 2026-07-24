using VehicleRadar;



public abstract class Rules
{

  public abstract Violation? checkViolation(Vehicle vehicle);


}

public class TruckSpeedRule : Rules
{
    public override Violation checkViolation(Vehicle vehicle)
    {
        if (vehicle.vehicleType == VehicleType.Truck && vehicle.speed > 60)
        {
           
            return new Violation(
                $"speed of {vehicle.speed} exceeded max allowed 60",
                300
            );
        }
        else
        return null;
    }
}

public class CarSpeedRule : Rules
{
    public override Violation? checkViolation(Vehicle vehicle)
    {
       if(vehicle.vehicleType == VehicleType.Private && vehicle.speed > 80)
        {
           

            return new Violation(
                $"speed of {vehicle.speed} exceeded max allowed 80",
                300
            );


        
        }
        else
        return null;
    }
}

public class SeatBeltRule : Rules
{
    public override Violation checkViolation(Vehicle vehicle)
    {
        if(vehicle.seatBelt == false)
        {
           
            return new Violation(
                $"Seatbelt not fastened",
                100
            );
        }
        else
        return null;
    }
}