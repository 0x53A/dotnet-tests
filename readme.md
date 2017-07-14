
``dotnet --version``:

> 2.1.0-preview1-006784

* ``dotnet restore``: ✔
* ``dotnet build``: ✔
* ``dotnet publish``: ✘

> C:\Program Files\dotnet\sdk\2.1.0-preview1-006784\Sdks\Microsoft.NET.Sdk\build\Microsoft.NET.Publish.targets(41,11): error MSB4057: The target "Build" does not exist in the project. [C:\source\dotnet-tests\paket-fsharp-test.fsproj]

* open in VS 15.3 preview 4: ✘

```
---------------------------
Microsoft Visual Studio
---------------------------
One or more projects in the solution were not loaded correctly.

Please see the Output Window for details.
---------------------------
OK   
---------------------------
```

> C:\source\dotnet-tests\paket-fsharp-test.fsproj : error  : Project file is incomplete. Expected imports are missing.
