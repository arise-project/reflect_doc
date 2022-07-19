# reflect_doc

build docs from .net type metadata for programming offline

------------------
Usage examples:
------------------

Read all types:

dotnet run -- C:\Users\ep\.nuget\packages\itext7

Read type in assembly:

dotnet run -- Log C:\Users\ep\.nuget\packages\serilog\2.10.0\lib\netstandard2.1\Serilog.dll

Read type in assemblies in directory:

dotnet run -- Rectangle C:\Users\ep\.nuget\packages\itext7 itext

------------------