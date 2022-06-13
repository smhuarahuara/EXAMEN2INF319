// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let rec fib n =
    if n=0 then 0
    elif n=1 then 1
    elif n=2 then 1
    else fib (n-1) + fib (n-2)

let genera n =
    for i in 0..n do
       //usando la definicion de funcion lambda
       let fiblam = (fun n -> fib(n)) i
       printf "%d " (fiblam) 

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine(genera 5)


    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
