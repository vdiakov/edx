open System
let goldenratio = (1.0 + Math.Sqrt(5.0))/2.0

let product x = (x, x*goldenratio)

[<EntryPoint>]
let main argv = 
    printfn "Please, input several numbers separated by space."
    printfn "Press enter after the last one."
    printfn "For example: 1 2.2 3.3 4.4 5.5 6"
    let sNumbers = Console.ReadLine()

    try
    let lstProducts = [for num in sNumbers.Split() -> product (float (num))]
    printfn "You have inserted %A correct numbers." lstProducts.Length
    printfn "Here are the corresponding results prepared using goldenratio:"

    printfn "%A" lstProducts
    with
      | :? System.FormatException -> printfn "Wrong Input (System.FormatException)"

    Console.WriteLine("Press a key to close ...")
    let readenKey = Console.ReadKey() |> ignore
    0