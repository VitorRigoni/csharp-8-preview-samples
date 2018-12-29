# Default implementations of interface members
Today, once you publish an interface it’s game over: you can’t add members to it without breaking all the existing implementers of it.

In C# 8.0 we let you provide a body for an interface member. Thus, if somebody doesn’t implement that member (perhaps because it wasn’t there yet when they wrote the code), they will just get the default implementation instead.

```csharp
interface ILogger
{
    void Log(LogLevel level, string message);
    void Log(Exception ex) => Log(LogLevel.Error, ex.ToString()); // New overload
}

class ConsoleLogger : ILogger
{
    public void Log(LogLevel level, string message) { ... }
    // Log(Exception) gets default implementation
}
```

The ConsoleLogger class doesn’t have to implement the Log(Exception) overload of ILogger, because it is declared with a default implementation. Now you can add new members to existing public interfaces as long as you provide a default implementation for existing implementors to use.

The biggest motivator behind adding this feature is to enable multiple inheritance while fixing the *Diamond Problem*.
See mora about the diamond problem in: https://en.wikipedia.org/wiki/Multiple_inheritance

**PS:** At the time of writing of these sample projects this feature is still in prototype, so this project will still not compile on dotnet SDK 3.0.100-preview-009812.
