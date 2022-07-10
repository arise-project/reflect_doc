galliumos@galliumos:/media/galliumos/Ventoy/proj/reflect_doc$ dotnet run -- System.IO.DirectoryInfo
/media/galliumos/Ventoy/usr/dotnet/sdk/3.1.419/NuGet.targets(128,5): error : Unable to load the service index for source https://api.nuget.org/v3/index.json. [/media/galliumos/Ventoy/proj/reflect_doc/reflect_doc.csproj]
/media/galliumos/Ventoy/usr/dotnet/sdk/3.1.419/NuGet.targets(128,5): error :   Resource temporarily unavailable [/media/galliumos/Ventoy/proj/reflect_doc/reflect_doc.csproj]

The build failed. Fix the build errors and run again.


galliumos@galliumos:/media/galliumos/Ventoy/proj/reflect_doc$ dotnet run -- System.IO.DirectoryInfo
Unhandled exception. System.ArgumentException: Type System.IO.DirectoryInfo doesn't exist in the current app domain
   at reflect_doc.Program.GetEntityType(String typeName) in /media/galliumos/Ventoy/proj/reflect_doc/Program.cs:line 26
   at reflect_doc.Program.Main(String[] args) in /media/galliumos/Ventoy/proj/reflect_doc/Program.cs:line 30
