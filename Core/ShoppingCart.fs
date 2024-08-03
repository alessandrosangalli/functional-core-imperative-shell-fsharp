namespace functional_core_imperative_shell_fsharp.Core

open functional_core_imperative_shell_fsharp.Core.Product

module ShoppingCart =

    type ShoppingCart = { Products: Product list }

    let addProduct cart product =
        { cart with
            Products = product :: cart.Products }

    let removeProduct cart productId =
        { cart with
            Products = cart.Products |> List.filter (fun p -> p.Id <> productId) }
