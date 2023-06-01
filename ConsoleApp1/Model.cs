using System.Globalization;

namespace ConsoleApp1;

public class Model: SiemensMobile
{
    public Model(string company, int prop1, double prop2, double classProp1, int classProp2) : base(company, prop1, prop2)
    {
        ClassProp1 = classProp1;
        ClassProp2 = classProp2;
    }

    private double ClassProp1
    {
        get;
        set;
    }

    private int ClassProp2
    {
        get;
        set;
    }

    private int ClassSomething(int x, int y)
    {
        return ClassProp2 + x + y;
    }

    private string OneMoreMethod()
    {
        return ClassProp1.ToString(CultureInfo.InvariantCulture);
    }
}