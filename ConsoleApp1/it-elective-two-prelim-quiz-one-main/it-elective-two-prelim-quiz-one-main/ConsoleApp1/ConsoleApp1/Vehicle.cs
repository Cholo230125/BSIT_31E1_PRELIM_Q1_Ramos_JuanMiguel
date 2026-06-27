
public abstract class Vehicle
{
    public string Name { get; protected set; }

    protected Vehicle(string name)
    {
        Name = name;
    }

    public abstract void Move();
}

public interface IDriveable { void Drive(); }
public interface IFlyable { void Fly(); }
public interface ISailable { void Sail(); }
public interface IDiveable { void Dive(); }