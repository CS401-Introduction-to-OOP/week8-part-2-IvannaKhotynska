namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        bool IsOpen = true;
        Console.WriteLine("The network is open");
    }
    public override void Close()
    {
        bool IsOpen = false;
        Console.WriteLine("The network is closed");
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine("The dispose was called");
    }

}