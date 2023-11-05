namespace PatrenPrototip;

public class Sedan : Car
{
    public Sedan(string model, int year) : base(model, year) { }

    public override Car Clone()
    {
        return new Sedan(Model, Year);
    }
}