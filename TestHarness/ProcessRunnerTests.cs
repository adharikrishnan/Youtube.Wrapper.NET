using Youtube.Wrapper.NET.Common;

namespace TestHarness;

public class ProcessRunnerTests
{
    [Fact]
    public void Test_ProcessRunner()
    {
        var output = ProcessRunner.Run("/home/ad-99/Desktop/c#_workspace/Youtube.Wrapper.NET/Executables/y-dlp", "-P \"/home/ad-99/Desktop/c#_workspace/Youtube.Wrapper.NET/Executables\" https://www.youtube.com/watch?v=uLdfmXBXkaE");
    }
}