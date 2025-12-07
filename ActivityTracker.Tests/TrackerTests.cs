using System.Diagnostics;
using Xunit;
namespace ActivityTracker.Tests;

public class TrackerTests
{
    [Fact]
    public void Constructor_ShouldSetDailyGoal()
    {
        int goal = 10000;

        var tracker = new Tracker(goal);

        Assert.Equal(goal, tracker.DailyGoal);
    }
}
