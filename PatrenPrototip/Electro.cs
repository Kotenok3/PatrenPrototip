namespace PatrenPrototip;

public class Electric : Car
{
    public int BatteryLevel { set; get; }
    
    public Electric(string model, int year, int batteryLevel) : base(model, year)
    {
        BatteryLevel = batteryLevel;
    }

    public override Car Clone()
    {
        return new Electric(Model, Year, BatteryLevel);
    }

    public override string ToString()
    {
        return $"Model:{Model}, Year:{Year}, Battery level:{BatteryLevel}";
    }
}