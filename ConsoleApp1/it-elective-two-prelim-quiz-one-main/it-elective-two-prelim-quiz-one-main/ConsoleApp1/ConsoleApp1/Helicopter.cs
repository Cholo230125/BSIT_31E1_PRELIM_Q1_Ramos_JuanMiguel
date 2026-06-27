public class Helicopter : Vehicle, IFlyable, IDriveable
{
    public Helicopter() : base("Helicopter") { }

    public override void Move() => Fly();
    public void Fly() => System.Console.WriteLine($"{Name} is hovering in the air.");
    public void Drive() => System.Console.WriteLine($"{Name} is taxiing on the runway.");
}