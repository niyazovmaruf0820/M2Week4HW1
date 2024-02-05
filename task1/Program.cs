using task1;

Teacher teacher = new Teacher("Alijon", "Tarafoi Mardon");
System.Console.WriteLine(teacher.ToString());
teacher.AddCource("C#");
teacher.AddCource("C++");
System.Console.WriteLine(teacher.AddCource("C++"));
System.Console.WriteLine(teacher.RemoveCource("C++"));
System.Console.WriteLine(teacher.RemoveCource("JS"));
teacher.AddCource("Go lang");
foreach (var item in teacher.GetCources())
{
    System.Console.WriteLine(item);
}


Student student = new Student("Maruf", "Nodira 78");
System.Console.WriteLine(student.ToString());
student.AddCourceGrade("C#", 100);
student.AddGrade(92);
student.AddGrade(92);
student.PrintGrades();  
System.Console.WriteLine(student.GetAverage());  
foreach (var item in student.GetCources())
{
    System.Console.WriteLine(item);
}