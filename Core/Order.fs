namespace functional_core_imperative_shell_fsharp.Core

open functional_core_imperative_shell_fsharp.Core.Product

module Order =

    type Order =
        { Id: string
          Products: Product list
          Total: decimal }

    let createOrder products =
        let total = products |> List.sumBy (fun p -> p.Price)

        { Id = System.Guid.NewGuid().ToString()
          Products = products
          Total = total }
