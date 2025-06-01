
namespace ASP.netCore.MVCCRUD.day14.demo1.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

public class AppConfigurationService
{
    
    
    public static IConfiguration _configuration { get; set; }
    
    //static method
    static AppConfigurationService()
    {
        //_configuration = new ConfigurationBuilder()
        //    .Add(new JsonConfigurationSource( {Path = "appsettings.json", ReloadOnChange = true}).Build();

        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // sets base path for appsettings.json
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }




}