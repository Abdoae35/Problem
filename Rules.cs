using VehicleRadar;



public abstract class Rules
{

  public abstract Violation checkViolation(Vehicle vehicle);


}

public class TruckSpeedRule : Rules
{
    public override Violation checkViolation(Vehicle vehicle)
    {
        if (vehicle.vehicleType == VehicleType.Truck && vehicle.speed > 60)
        {
            Fine.violations.Add(new Violation(
                $"-speed of {vehicle.speed} exceeded max allowed 60",
                300
            ));
            return new Violation(
                $"-speed of {vehicle.speed} exceeded max allowed 60",
                300
            );
        }
        return null;
    }
}

public class CarSpeedRule : Rules
{
    public override Violation checkViolation(Vehicle vehicle)
    {
       if(vehicle.vehicleType == VehicleType.Private && vehicle.speed > 80)
        {
            return new Violation(
                $"-speed of {vehicle.speed} exceeded max allowed 80",
                300
            );
        }
        return null;
    }
}

public class SeatBeltRule : Rules
{
    public override Violation checkViolation(Vehicle vehicle)
    {
        if(vehicle.seatBelt == false)
        {
            Fine.violations.Add(new Violation(
                $"- Seatbelt not fastened",
                100
            ));
            return new Violation(
                $"- Seatbelt not fastened",
                100
            );
        }
        return null;
    }
}