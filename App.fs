#light

namespace FSharpClickMe

    open System
    open System.Windows
    open System.Windows.Controls

    type App() as this =
        inherit Application()
        
        do
            this.Startup.Add(fun _ -> this.RootVisual <- new Page())