using VehicleRadar;
public class QuRadar
{

  private static int countViolatedVehicles = 0;

    
 public List<Rules> rules = new List<Rules>();

    public QuRadar()
    {
        rules.Add(new CarSpeedRule());
        rules.Add(new TruckSpeedRule());
        rules.Add(new SeatBeltRule());
        
    }

   public void ObserveVehicle(Vehicle vehicle)
    {
        foreach (var rule in rules)
        {
            var violation = rule.checkViolation(vehicle);
            if (violation != null)
            {
               
                Fine.addViolation(violation);
            }
        }
        Fine fine = new Fine(vehicle.plateNumber ?? "", Fine.violations.Sum(v => v.fineAmount));
        if (Fine.violations.Count > 0)
        {  
            fine.printFine();
            fine.getAllFines();
        }
        Fine.violations.Clear();
        

    }






}