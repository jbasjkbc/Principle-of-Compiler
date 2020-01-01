// Learn more about F# at http://fsharp.org

open System
open ParseAndRun

[<EntryPoint>]
let main argv =
    run (fromFile "ex1.c") [1]
    0 // return an integer exit code
