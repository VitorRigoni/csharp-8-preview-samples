#Async streams
The async/await feature of C# 5.0 lets you consume (and produce) asynchronous results in straightforward code, without callbacks:

```csharp
async Task<int> GetBigResultAsync()
{
    var result = await GetResultAsync();
    if (result > 20) return result; 
    else return -1;
}
```

It is not so helpful if you want to consume (or produce) continuous streams of results, such as you might get from an IoT device or a cloud service. Async streams are there for that.

We introduce `IAsyncEnumerable<T>`, which is exactly what you'd expect; an asynchronous version of `IEnumerable<T>`.
The language lets you await foreach over these to consume their elements, and yield return to them to produce elements.

```csharp
async IAsyncEnumerable<int> GetBigResultsAsync()
{
    await foreach (var result in GetResultsAsync())
    {
        if (result > 20) yield return result; 
    }
}
```

##Known issues

- Dotnet core 3.0-preview1 has a compiler bug that forces you to use the `async` keyword even if you don't use `await` inside the method.
For more details, please refer to the github issue: https://github.com/dotnet/roslyn/issues/31608
- Another compiler bug on preview 1 when using this feature is related to some types having being renamed. The workaround for now is adding the MSBuildFix.cs file that adds the missing types.