# Nullable reference types

The purpose of this feature is to help prevent the ubiquitous null reference exceptions that have riddled object-oriented programming for half a century now.

It stops you from putting null into ordinary reference types such as string – it makes those types non-nullable! It does so gently, with warnings, not errors. But on existing code there will be new warnings, so you have to opt in to using the feature (which you can do at the project, file or even source line level).

```csharp
string s = null; // Warning: Assignment of null to non-nullable reference type`
```

What if you do want null? Then you can use a nullable reference type, such as string?:

```csharp
string? s = null; // Ok
```

When you try to use a nullable reference, you need to check it for null first. The compiler analyzes the flow of your code to see if a null value could make it to where you use it:

```csharp
void M(string? s)
{
    Console.WriteLine(s.Length); // Warning: Possible null reference exception
    if (s != null)
    {
        Console.WriteLine(s.Length); // Ok: You won't get here if s is null
    }
}
```

The upshot is that C# lets you express your "nullable intent", and warns you when you don’t abide by it.

# Adding Nullable Reference Types feature

To enable this feature on a project level, add to your `.csproj` file:
```xml
<NullableReferenceTypes>true</NullableReferenceTypes>
```

To enable this feature on a file level or source line, add: `#nullable enable` and `#nullable disable` to the source code.

```csharp
#nullable enable // we've just enabled this feature for everything below this line.
void M(string? s)
{
    #nullable disable
    Console.WriteLine(s.Length); // This will not show any compiler warnings.
    #nullable enable
    Console.WriteLine(s.Length); // This one shows "Warning: Possible null reference exception".
}
```