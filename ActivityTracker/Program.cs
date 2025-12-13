using System.Text;
using ActivityTracker;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("=== Activity Tracker Docker ===");

var goal = 10000;
var tracker = new Tracker(goal);
Console.WriteLine($"Ціль на день: {goal} кроків.");

Console.WriteLine("Йдемо на прогулянку... (+2000 кроків)");
tracker.AddSteps(2000);
PrintStats(tracker);

Console.WriteLine("Біжимо... (+5500 кроків)");
tracker.AddSteps(5500);
PrintStats(tracker);

Console.WriteLine("Йдемо додому... (+3000 кроків)");
tracker.AddSteps(3000);
PrintStats(tracker);

void PrintStats(Tracker t)
{
    Console.WriteLine($"-> Поточні кроки: {t.CurrentSteps}");
    Console.WriteLine($"-> Прогрес: {t.GetProgress():F1}%");
    if (t.GetProgress() >= 100)
    {
        Console.WriteLine("-> Ціль досягнуто! Вітаємо!");
    }
    Console.WriteLine();
}