using Ardalis.GuardClauses;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1;

public class ConfigurationService
{
    private const string EnvironmentName = "DOTNET_ENVIRONMENT";
    private const string ConfigFileName = "Config";
    // private readonly Environments? _environments;
    private readonly string? _environments;
    private readonly IConfiguration _configuration;
    
    public ConfigurationService() 
    {
        _environments = Environment.GetEnvironmentVariable(EnvironmentName);

        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"{ConfigFileName}.json", true)
            .AddJsonFile($"{ConfigFileName}.{_environments}.json", true)
            .AddEnvironmentVariables()
            .Build();
    }
    
}