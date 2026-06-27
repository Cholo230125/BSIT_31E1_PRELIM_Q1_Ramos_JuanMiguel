using TransportChallenge;

public class Car : Vehicle, IDriveable
{
    public Car() : base("Car") { }

    public override void Move() => Drive();
    public void Drive() => System.Console.WriteLine($"{Name} is driving down the road.");
}