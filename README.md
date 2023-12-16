# Logálaí

A simplistic logging library for .NET 8.0

## What is it?

Logálaí (*Irish word for Logger*) is a lightweight and easy to use logging system for .NET 8.0 applications. It can log three different types of messages - error, warning, and info. Logálaí will also create a log file which contains every logged message and save it, so you can look back on what happened in the program if you need to.

## Sample Usage

```csharp
using Logalai.Core;

namespace Example
{
    public class Program
    {
        public void Main()
        {
            Log log = new Log();
            
            log.Error("This is an error message.");
            log.Warning("This is a warning message.");
            log.Info("This is a message.");
        }
    }
}
```