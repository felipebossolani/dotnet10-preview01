Console.WriteLine("Whats new in C# 14, dotnet 10 preview 01");
Console.WriteLine("Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14");

Console.WriteLine("--------------");
Console.WriteLine("Unbound generic types and nameof, in this example (List<>)");
Console.WriteLine("Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14#unbound-generic-types-and-nameof");
Console.WriteLine(nameof(List<>));

Console.WriteLine("--------------");
Console.WriteLine("Simple lambda parameters with modifiers");
Console.WriteLine("Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14#simple-lambda-parameters-with-modifiers");
var p = new TryParseDelegate();
p.Parse("42", out int result);
Console.WriteLine(result);

Console.WriteLine("--------------");
Console.WriteLine("The field keyword");
Console.WriteLine("Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14#the-field-keyword");
var fk = new FieldKeyword();
fk.Message = "Field keyword";
Console.WriteLine(fk.Message);
