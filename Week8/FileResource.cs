namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        bool IsOpen = true;
        Console.WriteLine("The file is open");
    }
    public override void Close()
    {
        bool IsOpen = false;
        Console.WriteLine("The file is closed");

    }
    public void Dispose()
    {
        Close();
        Console.WriteLine("The dispose was called");
    }

}