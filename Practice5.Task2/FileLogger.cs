using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Practice5.Task2
{
  public class FileLogger : ILogger
  {
    public void Debug(string message)
    {
      Log(message, ILogger.LogLevel.Debug);
    }

    public void Error(string message)
    {
      Log(message, ILogger.LogLevel.Error);
    }

    public void Fatal(string message)
    {
      Log(message, ILogger.LogLevel.Fatal);
    }

    public void Info(string message)
    {
      Log(message, ILogger.LogLevel.Info);
    }

    public void Trace(string message)
    {
      Log(message, ILogger.LogLevel.Trace);
    }

    public void Warning(string message)
    {
      Log(message, ILogger.LogLevel.Warning);
    }

    public void Log(string message, ILogger.LogLevel logLevel)
    {
      StackTrace stacktrace = new StackTrace();
      StackFrame prevframe = stacktrace.GetFrame(1);
      MethodBase method = prevframe.GetMethod();
      string className = method.ReflectedType.Name;

      StreamWriter streamWriter = new StreamWriter("./logs.txt", true);

      streamWriter.WriteLine($"<{DateTime.Now}> | <{className}> | <{logLevel}> | <{message}>");

      streamWriter.Close();
    }
  }
}
