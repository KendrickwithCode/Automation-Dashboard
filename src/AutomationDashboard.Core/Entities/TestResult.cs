using AutomationDashboard.Core.Enums;

namespace AutomationDashboard.Core.Entities;

public class TestResult
{
    public TestResult(Guid testCaseId, TestResultStatus status,
                      TimeSpan duration, string? errorMessage = null,
                      string? screenshotPath = null)
    {
        Id = Guid.NewGuid();
        TestCaseId = testCaseId;
        Status = status;
        Duration = duration;
        ErrorMessage = errorMessage;
        ScreenshotPath = screenshotPath;
    }

    public Guid Id { get; private set; }
    public Guid TestCaseId { get; private set; }
    public TestResultStatus Status { get; private set; }
    public string? ErrorMessage { get; private set; }
    public string? ScreenshotPath { get; private set; }
    public TimeSpan Duration { get; private set; }
}
