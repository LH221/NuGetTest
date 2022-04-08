
namespace NuGetTest
{
    public interface ITestService
    {
        string ReturnString(string inputString);
    }

    public class TestService : ITestService
    {
        public string ReturnString(string inputString)
        {
            return inputString;
        }
    }
}

