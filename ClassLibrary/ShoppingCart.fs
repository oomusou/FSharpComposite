namespace ClassLibrary

module ShoppingCart =
    let calculatePrice products = 
        products
        |> List.sumBy (fun elm -> Product.getPrice elm)