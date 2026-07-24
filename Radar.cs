using VehicleRadar;
public class Radar
{
 private List<Violation> observedViolation = new List<Violation>();
 
   
  

    
 public List<Rules> rules = new List<Rules>();

    public Radar()
    {
        rules.Add(new CarSpeedRule());
        rules.Add(new TruckSpeedRule());
        rules.Add(new SeatBeltRule());
        
    }

    public void GetAllViolatedRules()
    {
        Console.WriteLine();
        Console.WriteLine("All Violated Rules:");
        foreach (var violation in observedViolation.GroupBy(v => v.category))
        {
            Console.WriteLine($"{violation.Key}: {violation.Count()}");
        }
    }

   public void ObserveVehicle(Vehicle vehicle)
    {
        foreach (var rule in rules)
        {
            var violation = rule.checkViolation(vehicle);
            if (violation != null)
            {
               
                Fine.addViolation(violation);
                observedViolation.Add(violation);
                
            }
        }
        Fine fine = new Fine(vehicle.plateNumber ??"", Fine.violations.Sum(v => v.fineAmount));
        if (Fine.violations.Count > 0)
        {  
            fine.printFine();
            fine.getAllFines();
        }
        Fine.violations.Clear();
        

    }






}