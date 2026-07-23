using VehicleRadar;
public class QuRadar
{

    
 public List<Rules> rules = new List<Rules>();

    public QuRadar()
    {
        rules.Add(new TruckSpeedRule());
        rules.Add(new CarSpeedRule());
        rules.Add(new SeatBeltRule());
    }

   






}