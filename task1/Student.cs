namespace task1;

public class Student : Person
{
    private int numCources = 0;
    private List<string> cources = new List<string>();
    private List<int> grades = new List<int>(); 
    public Student(string name, string address) : base(name, address){}
    public void AddGrade(int newgrade)
    {
        grades.Add(newgrade);
    }
     public List<string> GetCources()
    {
        return cources;
    }
    public void AddCourceGrade(string cource,int grade)
    {
        cources.Add(cource);
        grades.Add(grade);
    }
    public void PrintGrades()
    {
        foreach (var item in grades)
        {
            System.Console.Write(item + " ");
        }
    }
    public double GetAverage()
    {
        double s = 0;
        foreach (var item in grades)
        {
            s += item;
        }
        return s/grades.Count;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
