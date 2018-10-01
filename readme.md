# Mcdonald verse singer - Console app

The console app can sing the McDonald child's verse. It has two modes:

1. Auto - just run the mcdonald.consoleApp.exe (from the dist.zip)
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