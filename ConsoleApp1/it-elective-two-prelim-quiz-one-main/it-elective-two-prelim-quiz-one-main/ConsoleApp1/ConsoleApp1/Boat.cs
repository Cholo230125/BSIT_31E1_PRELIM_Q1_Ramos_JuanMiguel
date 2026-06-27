using TransportChallenge;

public class Boat : Vehicle, ISailable
{
    public Boat() : base("Boat") { }

    public override void Move() => Sail();
    public void Sail() => System.Console.WriteLine($"{Name} is sailing across the water.");
}