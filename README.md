# Logálaí

A simplistic logging library for .NET 8.0

## What is it?

Logálaí (*Irish word for Logger*) is a lightweight and easy to use logging system for .NET 8.0 applications. It can log three different types of messages - error, warning, and info. This is designed to be a quick, easy, and resource light logging system. Currently tested and verified on Windows only.

## Building

The most recent stable version of Logálaí can be found on the [Releases](https://github.com/jclar0/Logalai/releases) page.

However, you can compile the most up-to-date builds with Visual Studio 2022 and the .NET desktop development workload.

Clone the Git repository and then open it in Visual Studio. You can then press F5 to build. Nothing complicated here!

## Sample Usage

```csharp
using Logalai.Core;

internal class Program
    {
        public void Main()
        {
            // Create a new instance of the Log class
            Log l = new Log();

            // Log an error, warning, or informational message to the console
            l.Error("This is an error!");
            l.Warning("This is a warning!");
            l.Info("This is informational!");
        }
```