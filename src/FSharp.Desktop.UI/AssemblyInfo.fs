﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Desktop.UI")>]
[<assembly: AssemblyProductAttribute("FSharp.Desktop.UI")>]
[<assembly: AssemblyDescriptionAttribute("F# MVC for WPF.")>]
[<assembly: AssemblyVersionAttribute("0.6.0")>]
[<assembly: AssemblyFileVersionAttribute("0.6.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.6.0"
