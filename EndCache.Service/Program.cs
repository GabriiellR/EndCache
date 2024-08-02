using EndCache.Service;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddEndCache(p =>
        {
            p.ConnectionString = "localhost";
        });


    }).ConfigureAppConfiguration((context, services) =>
    {
        
    }).Build();

host.Run();