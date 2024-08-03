namespace functional_core_imperative_shell_fsharp.Controllers

open Microsoft.AspNetCore.Mvc
open functional_core_imperative_shell_fsharp.Core.Product
open functional_core_imperative_shell_fsharp.Core.ShoppingCart

[<ApiController>]
[<Route("api/[controller]")>]
type ShoppingCartController() =
    inherit ControllerBase()

    let mutable cart = { Products = [] }

    [<HttpGet>]
    member _.Get() = cart

    [<HttpPost("add")>]
    member _.AddProduct([<FromBody>] product: Product) =
        cart <- ShoppingCart.addProduct cart product
        cart

    [<HttpPost("remove")>]
    member _.RemoveProduct([<FromBody>] productId: string) =
        cart <- ShoppingCart.removeProduct cart productId
        cart
