using System;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            var LogString = new LocalFileLogger<string>("LogString.txt");
            LogString.LogInfo("Привет мир");
            LogString.LogWarning("Предупреждение");
            LogString.LogError("Oшибка", new ArgumentNullException());

            var LogPeople = new LocalFileLogger<People>("LogPeople.txt");
            LogPeople.LogInfo("Привет мир");
            LogPeople.LogWarning("Предупреждение");
            LogPeople.LogError("Oшибка", new NullReferenceException());


        }
    }
}
