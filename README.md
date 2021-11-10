A demo project to show test runners crush using ClearScript V8 engine

Tested system:

```bash
andrey@Andreys-MacBook TestProjectNUnit % dotnet --version
6.0.100
```

```bash
andrey@Andreys-MacBook TestProjectNUnit %  sw_vers
ProductName:    macOS
ProductVersion: 12.0.1
BuildVersion:   21A559
```

Run some iterations of simple function using ClearScript, from root of this repository:
```bash
andrey@Andreys-MacBook ClearScriptCrush % dotnet run --project ConsoleApp1
Hello, World!
All done

```

Run the same work via XUnit:
```bash
andrey@Andreys-MacBook ClearScriptCrush % dotnet test TestProjectXUnit
  Determining projects to restore...
  All projects are up-to-date for restore.
  ConsoleApp1 -> /Users/andrey/Programming/CoverGo/ClearScriptCrush/ConsoleApp1/bin/Debug/net6.0/ConsoleApp1.dll
  TestProjectXUnit -> /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectXUnit/bin/Debug/net6.0/TestProjectXUnit.dll
Test run for /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectXUnit/bin/Debug/net6.0/TestProjectXUnit.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.0.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
The active test run was aborted. Reason: Test host process crashed

Test Run Aborted with error System.Exception: One or more errors occurred.
 ---> System.Exception: Unable to read beyond the end of the stream.
   at System.IO.BinaryReader.ReadByte()
   at System.IO.BinaryReader.Read7BitEncodedInt()
   at System.IO.BinaryReader.ReadString()
   at Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.LengthPrefixCommunicationChannel.NotifyDataAvailable()
   at Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.TcpClientExtensions.MessageLoopAsync(TcpClient client, ICommunicationChannel channel, Action`1 errorHandler, CancellationToken cancellationToken)
   --- End of inner exception stack trace ---.

```

run tests with dotnet5 via Rosetta, it passes
```bash

andrey@Andreys-MacBook ClearScriptCrush % dotnet5 test TestProjectXUnit --no-build
Test run for /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectXUnit/bin/Debug/net5.0/TestProjectXUnit.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.11.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 8 s - /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectXUnit/bin/Debug/net5.0/TestProjectXUnit.dll (net5.0)
Test run for /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectXUnit/bin/Debug/net6.0/TestProjectXUnit.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 16.11.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
Testhost process exited with error: It was not possible to find any compatible framework version
The framework 'Microsoft.NETCore.App', version '6.0.0' was not found.
  - The following frameworks were found:
      5.0.11 at [/usr/local/share/dotnet/x64/shared/Microsoft.NETCore.App]
You can resolve the problem by installing the specified framework and/or SDK.
The specified framework can be found at:
  - https://aka.ms/dotnet-core-applaunch?framework=Microsoft.NETCore.App&framework_version=6.0.0&arch=x64&rid=osx.11.1-x64
. Please check the diagnostic logs for more information.

Test Run Aborted.

```


dotnet6 fails for XUnit and NUnit as well

Run the same work via NUnit:
```bash
andrey@Andreys-MacBook ClearScriptCrush %  dotnet test TestProjectNUnit
  Determining projects to restore...
  All projects are up-to-date for restore.
  ConsoleApp1 -> /Users/andrey/Programming/CoverGo/ClearScriptCrush/ConsoleApp1/bin/Debug/net6.0/ConsoleApp1.dll
  TestProjectNUnit -> /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectNUnit/bin/Debug/net6.0/TestProjectNUnit.dll
Test run for /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectNUnit/bin/Debug/net6.0/TestProjectNUnit.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.0.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
The active test run was aborted. Reason: Test host process crashed

Test Run Aborted with error System.Exception: One or more errors occurred.
 ---> System.Exception: Unable to read beyond the end of the stream.
   at System.IO.BinaryReader.ReadByte()
   at System.IO.BinaryReader.Read7BitEncodedInt()
   at System.IO.BinaryReader.ReadString()
   at Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.LengthPrefixCommunicationChannel.NotifyDataAvailable()
   at Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.TcpClientExtensions.MessageLoopAsync(TcpClient client, ICommunicationChannel channel, Action`1 errorHandler, CancellationToken cancellationToken)
   --- End of inner exception stack trace ---.

```



Run the same work via MSTest:
```bash
andrey@Andreys-MacBook ClearScriptCrush %  dotnet test TestProjectMSTest
  Determining projects to restore...
  All projects are up-to-date for restore.
  ConsoleApp1 -> /Users/andrey/Programming/CoverGo/ClearScriptCrush/ConsoleApp1/bin/Debug/net6.0/ConsoleApp1.dll
  TestProjectMSTest -> /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectMSTest/bin/Debug/net6.0/TestProjectMSTest.dll
Test run for /Users/andrey/Programming/CoverGo/ClearScriptCrush/TestProjectMSTest/bin/Debug/net6.0/TestProjectMSTest.dll (.NETCoreApp,Version=v6.0)
Microsoft (R) Test Execution Command Line Tool Version 17.0.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
The active test run was aborted. Reason: Test host process crashed

Test Run Aborted with error System.Exception: One or more errors occurred.
 ---> System.Exception: Unable to read beyond the end of the stream.
   at System.IO.BinaryReader.ReadByte()
   at System.IO.BinaryReader.Read7BitEncodedInt()
   at System.IO.BinaryReader.ReadString()
   at Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.LengthPrefixCommunicationChannel.NotifyDataAvailable()
   at Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.TcpClientExtensions.MessageLoopAsync(TcpClient client, ICommunicationChannel channel, Action`1 errorHandler, CancellationToken cancellationToken)
   --- End of inner exception stack trace ---.
andrey@Andreys-MacBook ClearScriptCrush % 

```
