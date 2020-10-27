using System;
using Microsoft.Extensions.Configuration;

namespace env_var_configuration_example
{
    class Program
    {
        static void Main(string[] args)
        {

            Environment.SetEnvironmentVariable("THIS__IS__AN__EXAMPLE__KEY", "example-value");

            var builder = new ConfigurationBuilder()
           .AddEnvironmentVariables();

            var configuration = builder.Build();

            var works = configuration.GetValue<string>("THIS:IS:AN:EXAMPLE:KEY");
            Console.WriteLine($"This works, and the value is: `{works}`");

            var doesNotWork = configuration.GetValue<string>("THIS__IS__AN__EXAMPLE__KEY");
            Console.WriteLine($"This does not work: {doesNotWork}");
        }
    }
}
