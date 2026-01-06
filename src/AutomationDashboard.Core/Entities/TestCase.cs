namespace AutomationDashboard.Core.Entities;

public class TestCase
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Selector { get; private set; } // Playwright test ID
    public bool IsAutomated { get; private set; }

    public TestCase(string name, string selector, bool isAutomated)
    {
        Id = Guid.NewGuid();
        Name = name;
        Selector = selector;
        IsAutomated = isAutomated;
    }
}
