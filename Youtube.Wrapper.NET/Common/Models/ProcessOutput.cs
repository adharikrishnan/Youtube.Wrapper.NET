using System.Diagnostics;

namespace Youtube.Wrapper.NET.Common.Models;

/// <summary>
/// Model class to return the output from a process in a standard form. 
/// </summary>
public class ProcessOutput
{
    /// <summary>
    /// Default Constructor
    /// </summary>
    public ProcessOutput()
    {
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ProcessOutput"/> Class with a given Process Instance.
    /// </summary>
    /// <param name="process">The Process Instance.</param>
    public ProcessOutput(Process process)
    {
        this.ExitCode = process.ExitCode;
        this.StandardOutput = process?.StandardOutput.ReadToEnd();
        this.StandardError = process?.StandardError.ReadToEnd();
        this.ProcessStatus = ProcessStatus.Success;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ProcessOutput"/> Class with an Exit Code.
    /// </summary>
    /// <param name="exitCode">The Process Exit Code.</param>
    /// <param name="status">The Process Status.</param>
    public ProcessOutput(int exitCode, ProcessStatus status)
    {
        this.ExitCode = exitCode;
        this.ProcessStatus = status;
    }

    /// <summary>
    ///  Creates a new instance of the <see cref="ProcessOutput"/> Class with an Exit Code, Standard Output (string) and Error Output (string).
    /// </summary>
    /// <param name="exitCode">The Exit Code.</param>
    /// <param name="standardOutput">The Standard Output.</param>
    /// <param name="standardError">The Standard Error.</param>
    /// /// <param name="status">The Process Status.</param>
    public ProcessOutput(int exitCode, string standardOutput, string standardError, ProcessStatus status)
    {
        this.ExitCode = exitCode;
        this.StandardOutput = standardOutput;
        this.StandardError = standardError;
        this.ProcessStatus = status;
    }

    /// <summary>
    /// The Exit Code as an Integer.
    /// </summary>
    public int ExitCode { get;}

    /// <summary>
    /// The Standard Output from a process as a string.
    /// </summary>
    public string? StandardOutput { get; }

    /// <summary>
    /// The Standard Error from a process as a string.
    /// </summary>
    public string? StandardError { get; }
    
    /// <summary>
    /// The Process Status.
    /// </summary>
    public ProcessStatus ProcessStatus { get; }
}

/// <summary>
/// The Process Status Enum.
/// </summary>
public enum ProcessStatus
{
    Success = 0,
    Error = 1
}