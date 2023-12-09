open Application
open Widget
open Window

[<EntryPoint>]
let main _ = 
    newApplication "de.uriegel.test"
    |> onActivate (fun app ->
        newWindow app
        |> title "Hello Gtk👍"
        |> defaultSize 1200 1000
        |> show)
    |> run 0 0