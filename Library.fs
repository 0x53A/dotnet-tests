namespace paket_fsharp_test

open Newtonsoft

module Say =
    let hello name =
        printfn "Hello %s" name
