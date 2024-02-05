List<int> birds = new List<int>(){0, 2, 5, 3, 7, 8, 4, 10, 11};
int BirdCount_Today()
{
    return birds[birds.Count - 1];
}
void BirdCount_IncrementTodaysCount()
{
    birds[birds.Count - 1]++;
}
bool BirdCount_HasDayWithoutBirds()
{
    if (birds[birds.Count - 1] == 0)
    return true;
    else return false;
}
int BirdCount_CountForFirstDays()
{
    int s = 0;
    for (int i = 0; i < 8; i++)
    {
        s += birds[i]; 
    }
    return s;
}
void BirdCount_BusyDays()
{
    foreach (var item in birds)
    {
        if (item >= 5)
        System.Console.WriteLine(item);
    }
}
System.Console.WriteLine(BirdCount_Today());
BirdCount_IncrementTodaysCount();
System.Console.WriteLine(BirdCount_HasDayWithoutBirds());
System.Console.WriteLine(BirdCount_CountForFirstDays());
BirdCount_BusyDays();