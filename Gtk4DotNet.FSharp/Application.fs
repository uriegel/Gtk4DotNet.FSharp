module Application

let newApplication id = 
    GtkDotNet.Application.New id

let onActivate (onAction: GtkDotNet.SafeHandles.ApplicationHandle -> unit) app = 
    GtkDotNet.Application.OnActivate (app, onAction)

let newWindow app =
    GtkDotNet.Application.NewWindow(app)

let run c p app = 
    GtkDotNet.Application.Run (app, c, p)    