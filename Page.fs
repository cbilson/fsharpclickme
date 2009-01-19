#light

namespace FSharpClickMe

    open System
    open System.Windows
    open System.Windows.Controls

    type Page() as this =
        inherit UserControl()
        
        do
            let btn = new Button()
            btn.HorizontalAlignment <- HorizontalAlignment.Center
            btn.VerticalAlignment <- VerticalAlignment.Center
            btn.Content <- "Click Me!"
            btn.Click.Add(fun _ -> btn.Content <- "Clicked")
            
            this.Content <- btn
