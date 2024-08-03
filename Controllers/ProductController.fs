namespace functional_core_imperative_shell_fsharp.Controllers

open Microsoft.AspNetCore.Mvc
open functional_core_imperative_shell_fsharp.Core.Product

[<ApiController>]
[<Route("api/[controller]")>]
type ProductController() =
    inherit ControllerBase()

    let products = System.Collections.Generic.List<Product>()

    [<HttpGet>]
    member _.Get() = products

    [<HttpPost>]
    member _.Post([<FromBody>] product: Product) =
        products.Add(product)
        product
