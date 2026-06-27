using System;
using System.Collections.Generic;

public static class TransportResolver
{
    private static readonly Dictionary<string, Func<Vehicle>> _registry =
        new Dictionary<string, Func<Vehicle>>(StringComparer.OrdinalIgnoreCase)
        {
            { "car", () => new Car() },
            { "plane", () => new Airplane() },
            { "boat", () => new Boat() },
            { "helicopter", () => new Helicopter() },
            
        
            { "motorcycle", () => new BonusMotorcycle() },
            { "submarine", () => new BonusSubmarine() },
            { "drone", () => new BonusDrone() }
        };

    public static Vehicle? Resolve(string transportType)
    {
        if (string.IsNullOrWhiteSpace(transportType)) return null;

        if (_registry.TryGetValue(transportType.Trim(), out var creator))
        {
            return creator();
        }

        return null; 
    }
}

public class BonusMotorcycle : Vehicle, IDriveable
{
    public BonusMotorcycle() : base("Motorcycle") { }
    public override void Move() => Drive();
    public void Drive() => System.Console.WriteLine($"{Name} is cruising down the highway.");
}

public class BonusSubmarine : Vehicle, ISailable, IDiveable
{
    public BonusSubmarine() : base("Submarine") { }
    public override void Move() => Dive();
    public void Sail() => System.Console.WriteLine($"{Name} is sailing on the surface.");
    public void Dive() => System.Console.WriteLine($"{Name} is diving deep into the ocean.");
}

public class BonusDrone : Vehicle, IFlyable
{
    public BonusDrone() : base("Drone") { }
    public override void Move() => Fly();
    public void Fly() => System.Console.WriteLine($"{Name} is buzzing through the air.");
}