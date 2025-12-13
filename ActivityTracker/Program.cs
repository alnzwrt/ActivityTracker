using ActivityTracker;

Console.WriteLine("=== Activity Tracker Docker ===");

// Ініціалізація
var goal = 10000;
var tracker = new Tracker(goal);
Console.WriteLine($"Ціль на день: {goal} кроків.");

// Симуляція активності
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