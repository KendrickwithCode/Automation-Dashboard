namespace AutomationDashboard.Core.Entities;

public class TestSuite
{
    public TestSuite(string name, string description = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
    }

    public Guid Id {get; private set;}
    public string Name {get; private set;}
    public string Description {get; private set;}
    private readonly List<TestCase> _testCases = new();

    public void AddTestCase(TestCase testCase)
    {
        _testCases.Add(testCase);
    }
}