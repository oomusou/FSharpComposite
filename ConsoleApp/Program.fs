// Learn more about F# at http://fsharp.org

open System
open ClassLibrary

[<EntryPoint>]
let main argv =
    [ 
        Product.macbookPro
        Product.ipadAir
        Product.appleWatch
        Product.appleCombo 
    ]
    |> ShoppingCart.calculatePrice 
    |> printf "%.0f"
    
    0
