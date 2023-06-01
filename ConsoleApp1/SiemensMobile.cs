namespace ConsoleApp1;

public abstract class SiemensMobile : IMobile
{
    protected SiemensMobile(string company, int prop1, double prop2)
    {
        Company = company;
        Prop1 = prop1;
        Prop2 = prop2;
    }

    public string Company { get; set; }

    private int Prop1 { get; set; }
    private double Prop2 { get; set; }
    

    public string Hello()
    {
        return "helloWorld!";
    }

    public void WriteHello()
    {
        Console.WriteLine(Hello());

    }

    public int AbstractClassMethod1(int x)
    {
        return x + Prop1;
    }
    
    public double AbstractClassMethod2(double x, double y)
    {
        return y + Prop1/Prop2;
    }
    
    
}