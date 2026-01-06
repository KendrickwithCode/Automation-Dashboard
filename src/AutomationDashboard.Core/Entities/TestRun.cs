using AutomationDashboard.Core.Enums;

namespace AutomationDashboard.Core.Entities;

public class TestRun
{
    public TestRun(Guid testSuiteId)
    {
        Id = Guid.NewGuid();
        TestSuiteId = testSuiteId;
        StartedAt = DateTime.UtcNow;
        Status = TestRunStatus.Queued;
    }

    public Guid Id {get; private set;}
    public Guid TestSuiteId {get; private set;}
    public DateTime StartedAt {get; private set;}
    public DateTime? FinishedAt {get; private set;}
    public TestRunStatus Status {get; private set;}
    private readonly List<TestResult> _results = new();
    
    public void MarkRunning()
    {
        Status = TestRunStatus.Running;
    }
    public void Complete(TestRunStatus finalStatus)
    {
        Status = finalStatus;
        FinishedAt = DateTime.UtcNow;
    }
    public void AddResult(TestResult result)
    {
        _results.Add(result);
    }
}