open System

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let teenage name age = 
    if age >= 20 then
        name + " is no longer a teenager."
    elif age >= 13 then
        name + " is a teenager."
    elif age > 0 then
        name + " is not yet a teenager."
    else 
        "Error. The age can not be negative."

[<EntryPoint>]
let main argv =
    Console.Write("Please write the name of the student : ")
    let studentname = Console.ReadLine() 
    Console.Write("Please write the age of the student : ")
    let studentage = Console.ReadLine()
    let mutable studentageint = 0
    let res, studentageint = Int32.TryParse studentage 
    let teen = if res then teenage studentname studentageint else "Error. The age must be an integer."
    printfn "%A" teen
    Console.Write("Press a key to continue ... ")
    let aPressedKey = Console.ReadKey()
    0 // return an integer exit code
