namespace Practice5.Task2
{
  public interface ILogger
  {
    enum LogLevel
    {
      Trace,
      Info,
      Debug,
      Warning,
      Error,
      Fatal,
    }

    void Trace(string message);

    void Info(string message);

    void Debug(string message);

    void Warning(string message);

    void Error(string message);

    void Fatal(string message);

    void Log(string message, LogLevel logLevel);
  }


}
