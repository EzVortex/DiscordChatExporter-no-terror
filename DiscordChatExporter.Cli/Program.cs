using System;
using System.Threading.Tasks;
using CliFx;

namespace DiscordChatExporter.Cli;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        // Bypass region restriction
        Environment.SetEnvironmentVariable("SLAVA_UKRAINI", "1");

        return await new CommandLineApplicationBuilder()
            .AddCommandsFromThisAssembly()
            .Build()
            .RunAsync(args);
    }
}
