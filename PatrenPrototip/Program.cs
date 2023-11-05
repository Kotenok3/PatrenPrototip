
using PatrenPrototip;

var factory = new CarFactory();

var loganOrig = new Sedan("Renault Logan", 2018);
var ramOrig = new Pickup("RAM 1500 TRX", 2022, true);
var teslaOrig = new Electric("Tesla model 3", 2018, 100);

factory.RegisterPrototype("Logan", loganOrig);
factory.RegisterPrototype("RAM",ramOrig);
factory.RegisterPrototype("Tesla",teslaOrig);

var teslaClone1 = (Electric)teslaOrig.Clone();
var teslaClone2 = (Electric)factory.CreateCar("Tesla");

teslaClone1.BatteryLevel = 60;
teslaClone2.BatteryLevel = 10;

Console.WriteLine($"Original Tesla:{teslaOrig}");
Console.WriteLine($"Tesla clone using class:{teslaClone1}");
Console.WriteLine($"Tesla clone using factory{teslaClone2}");


