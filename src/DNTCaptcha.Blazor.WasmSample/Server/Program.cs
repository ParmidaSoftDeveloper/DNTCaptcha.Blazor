﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DNTCaptcha.Blazor.WasmSample.Server;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
}