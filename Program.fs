// main entry point for F# application
[<EntryPoint>]
let main argv =

    // basic assigment of values
    let x = 42
    let hi = "Hello"

    // Branching with if
    let Greeting name =
        if System.String.IsNullOrWhiteSpace(name) then
            "whoever you are"
        else
            name

    let sayHiTo me =
        printfn "Hi, %s" (Greeting me)

    // check length of agrument array
    if argv.Length > 0 then
        sayHiTo argv.[0]
    else
        sayHiTo ""


    let PrintNumbers min max =
        // sub functions
        let square x =
            x * x

        // Looping with for
        for x in min..max do
            printfn "%i %i" x (square x)

    PrintNumbers 1 10


    0 // return 0 from entry point