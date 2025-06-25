using StackToAnalyze;
namespace BracketsTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Program.IsCorrectString("(([[]]))"));
    }
}