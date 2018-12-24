#Ranges and indices
We're adding a type Index, which can be used for indexing. You can create one from an int that counts from the beginning, or with a prefix ^ operator that counts from the end:

```csharp
Index i1 = 3;  // number 3 from beginning
Index i2 = ^4; // number 4 from end
int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine($"{a[i1]}, {a[i2]}"); // "3, 6"
```

We're also introducing a Range type, which consists of two Indexes, one for the start and one for the end, and can be written with a x..y range expression. You can then index with a Range in order to produce a slice:

```csharp
var slice = a[i1..i2]; // { 3, 4, 5 }
```