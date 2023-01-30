# dotnet-web-learning

**Create Project:**<br/>
```bash
# create new project
dotnet new webapi -n MyStartApi
# ...or with output flag
dotnet new console -o Calculator
```
Go to created project... `MyStartApi`

**Build:**<br/>
```bash
# clean packages
dotnet clean
# build for application
dotnet build
```

**Run:**<br/>
```bash
# get packages
dotnet restore
# normal
dotnet run
# ..or in hot reload mode
dotnet watch run
```

**Create basic gitignore file:**<br/>
```bash
dotnet new gitignore
```

**References:**<br/>
- https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/internal
- https://learn.microsoft.com/pt-br/dotnet/standard/assembly/
- https://learn.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates
- https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-6.0
- https://www.youtube.com/watch?v=xWTJqAp2AVw&ab_channel=CentraldotNET
- https://andrielleazevedo.wordpress.com/2011/12/11/c-namespaces/
- https://www.youtube.com/watch?v=6s4lomHKl-Q&ab_channel=MarcoDiniz