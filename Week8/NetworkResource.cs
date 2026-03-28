namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        bool IsOpen = true;
    }
    public override void Close()
    {
        Dispose();
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine("The dispose was called");
    }

}