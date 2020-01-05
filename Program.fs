// Learn more about F# at http://fsharp.org

open System
open ParseAndComp
//open ParseAndRun

[<EntryPoint>]
let main argv =
    compileToFile (fromFile "ex7.c") "ex7.out"
//    run (fromFile "ex7.c") [2];
    0 // return an integer exit code
