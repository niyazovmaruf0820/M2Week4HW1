namespace task1;

public class Teacher : Person
{
    private int numCources = 0;
    private List<string> cources = new List<string>();

    public Teacher(string name, string address) : base(name, address) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public bool AddCource(string cource)
    {
        bool a = cources.Exists(e => e == cource);
        if (a == false) cources.Add(cource);
        else a = false;
        return a;
    }
    public bool RemoveCource(string cource)
    {
        bool a = cources.Exists(e => e == cource);
        if (a == true) cources.Remove(cource);
        else a = false;
        return a;
    }
    public List<string> GetCources()
    {
        return cources;
    }
}
