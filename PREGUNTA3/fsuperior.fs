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

let fsuperior = fun op arg->op arg

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    //genera serie fibo recursiva
    Console.WriteLine(fsuperior genera 5)
    //genera serie fibo estructurada
    Console.WriteLine(fsuperior generafibo 5)


    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
