using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker.Tests;

public class Tracker
{
    public int DailyGoal { get; private set; }
    public int CurrentSteps { get; private set; }

    public Tracker(int goal)
    {
        DailyGoal = goal; 
    }
    public void AddSteps(int steps)
    {
        // Поки що пусто!
    }
}