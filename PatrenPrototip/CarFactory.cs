namespace PatrenPrototip;

public class CarFactory
{
    private Dictionary<string, Car> prototypes = new Dictionary<string, Car>();

    public void RegisterPrototype(string key, Car prototype)
    {
        prototypes[key] = prototype;
    }

    public Car CreateCar(string key)
    {
        if (prototypes.ContainsKey(key))
        {
            return prototypes[key].Clone();
        }
        else
        {
            throw new ArgumentException("Прототип с заданным ключом не найден");
        }
    }
}