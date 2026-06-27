using TransportChallenge;

public class Airplane : Vehicle, IFlyable
{
    public Airplane() : base("Airplane") { }

    public override void Move() => Fly();
    public void Fly() => System.Console.WriteLine($"{Name} is soaring through the clouds.");
}