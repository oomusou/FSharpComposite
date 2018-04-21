namespace ClassLibrary

type Apple = 
    | MacBookPro of double
    | IPadAir of double
    | AppleWatch of double
    | AppleCombo of Apple List

module Product =
    let macbookPro = MacBookPro 60000.0
    let ipadAir = IPadAir 10000.0
    let appleWatch = AppleWatch 10000.0
    let appleCombo = (AppleCombo) [ macbookPro; ipadAir; appleWatch ]
        
    let rec getPrice product = 
        match product with
        | MacBookPro(price) 
        | IPadAir(price) 
        | AppleWatch(price)    -> price
        | AppleCombo(products) -> products
                                  |> List.sumBy (fun elm -> getPrice elm)
                                  |> (fun elm -> elm * 0.9)
