namespace PatrenPrototip;

public abstract class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public abstract Car Clone();
}