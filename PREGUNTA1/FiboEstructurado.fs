// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let generafibo n =
    let mutable a = 0
    let mutable b = 1
    let mutable c = 1
    for i in 0..n do
       printf "%d " a
       a <- b
       b <- c
       c <- a + b




[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine(generafibo 5)


    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
