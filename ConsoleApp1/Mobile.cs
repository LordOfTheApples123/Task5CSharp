namespace ConsoleApp1;

public interface IMobile
{

    string Company
    {
        get;
        set;
    }

    public string Hello();

    public void WriteHello();
}