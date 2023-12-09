module Window

let title title win =
    GtkDotNet.Window.Title (win, title)

let defaultSize w h win =
    GtkDotNet.Window.DefaultSize (win, w, h)    
