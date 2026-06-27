namespace TransportChallenge
{
    public interface IDriveable
    {
        string Drive() => "Driving on the road.";
    }

    public interface IFlyable
    {
        string Fly() => "Flying in the sky.";
    }

    public interface ISailable
    {
        string Sail() => "Sailing on the water.";
    }
}