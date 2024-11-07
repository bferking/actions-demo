using demo_app;

namespace demo_app_tests;

public class Tests
{
    [Test]
    public void TestProgramOutput()
    {
        // Arrange
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        Program.Main();

        // Assert
        var expected = "Hello, from the demo app!" + Environment.NewLine;
        Assert.That(sw.ToString(), Is.EqualTo(expected));
    }
}