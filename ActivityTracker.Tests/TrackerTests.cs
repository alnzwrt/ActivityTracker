using System.Diagnostics;
using Xunit;
namespace ActivityTracker;

public class TrackerTests
{
    [Fact]
    public void Constructor_ShouldSetDailyGoal()
    {
        int goal = 10000;

        var tracker = new Tracker(goal);

        Assert.Equal(goal, tracker.DailyGoal);
    }
    [Fact]
    public void AddSteps_ShouldIncreaseCurrentSteps()
    {
        var tracker = new Tracker(5000);

        tracker.AddSteps(1000);

        Assert.Equal(1000, tracker.CurrentSteps);
    }
    [Fact]
    public void GetProgress_ShouldReturnCorrectPercentage()
    {
        var tracker = new Tracker(1000);
        tracker.AddSteps(500);

        double progress = tracker.GetProgress();

        Assert.Equal(50.0, progress);
    }
    [Fact]
    public void Reset_ShouldSetStepsToZero()
    {
        var tracker = new Tracker(5000);
        tracker.AddSteps(2000);

        tracker.Reset();

        Assert.Equal(0, tracker.CurrentSteps);
    }
}
