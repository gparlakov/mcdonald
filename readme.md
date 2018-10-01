# Mcdonald verse singer - Console app

The console app can output the McDonald child's verse. It has two modes:

1. Auto - just run the mcdonald.consoleApp.exe (from the dist.zip)
```bash
mcdonald.consoleApp.exe 
# results in five verse cow, cat, dog...
``` 
2. Pass in animals as parameters
```bash
mcdonald.consoleApp.exe cat meow pig oink

# results in two verse cat-meow and pig-oink
``` 

# Project description

## Structure
This is a DotNetCore app and can be build with **Dot Net Core SDK 2.x**
1. mcdonald\mcdonald.csproj - the core business logic - where the `ISinger` and `IAnimal` live along with their implementations `Singer` and `Animal`
2. mcdonald.consoleApp\mcdonald.consoleApp.csproj - the UI - console app that uses the mcdonald.csproj
## Tests
 mcdonald.tests\mcdonald.tests.csproj
* Tests for the core - `SingerTests` 
* Tests for the UI - treating the app as a black box and testing the output as it depends on the input `ConsoleTests` 

## Tooling
 * VSCode can be used for editor 
 * C# for vs code (omnisharp) helps in C# editing
 * the watchTests can be used for test driven development