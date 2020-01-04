// Learn more about F# at http://fsharp.org

open System
open ParseAndComp

[<EntryPoint>]
let main argv =
    compileToFile (fromFile "ex4.c") "ex4.out"
//    run (fromFile "ex1.c") [2];
    0 // return an integer exit code
