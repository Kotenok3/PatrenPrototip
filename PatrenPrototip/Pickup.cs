namespace PatrenPrototip;

public class Pickup : Car
{
    public bool AllWheelDrive { set; get; }

    public Pickup(string model, int year, bool allWheelDrive) : base(model, year)
    {
        AllWheelDrive = allWheelDrive;
    }

    public override Car Clone()
    {
        return new Pickup(Model, Year, AllWheelDrive);
    }
}