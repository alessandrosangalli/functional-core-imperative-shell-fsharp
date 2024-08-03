namespace functional_core_imperative_shell_fsharp.Controllers

open Microsoft.AspNetCore.Mvc
open functional_core_imperative_shell_fsharp.Core.Product
open functional_core_imperative_shell_fsharp.Core.Order

[<ApiController>]
[<Route("api/[controller]")>]
type OrderController() =
    inherit ControllerBase()

    [<HttpPost>]
    member _.CreateOrder([<FromBody>] products: Product list) =
        let order = Order.createOrder products
        order
