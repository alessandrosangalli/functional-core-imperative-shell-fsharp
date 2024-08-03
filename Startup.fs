namespace EcommerceApi

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

type Startup(configuration: IConfiguration) =
    member _.Configuration = configuration

    member _.ConfigureServices(services: IServiceCollection) = services.AddControllers() |> ignore

    member _.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        if env.IsDevelopment() then
            app.UseDeveloperExceptionPage() |> ignore

        app
            .UseRouting()
            .UseEndpoints(fun endpoints -> endpoints.MapControllers() |> ignore)
            .UseHttpsRedirection()
            .UseAuthorization()
            .UseStaticFiles()
            .UseDefaultFiles()
        |> ignore
