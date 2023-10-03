module Program

open System

[<EntryPoint>]
let main argv =
    printfn "Choose an option:"
    printfn "1. Start Server"
    printfn "2. Start Client"
    let choice = Console.ReadLine()
    match choice with
    | "1" ->
        // Start the server
        Server.main argv
        0 // Return 0 to indicate success
    | "2" ->
        // Start the client
        Client.main argv
        0 // Return 0 to indicate success
    | _ -> 
        printfn "Invalid choice"
        1 // Return 1 to indicate an error