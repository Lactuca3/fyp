# Final Year Project

An F# Electron app centered around Fable 2 and Elmish designed to help Year 1 DECA students learn about CPU Design. Includes a CPU Instruction Set Architecture DSL, Assembler, and Simulator


## Requirements

* .NET Core SDK 3.0
* Node (for `npm`)
* Python 2


## How to develop

This project uses .NET Core 3 local tools. Therefore, run `dotnet tool restore` to restore the necessary CLI tools before doing anything else.

Then, to run the app locally in "live mode":

`dotnet fake build -t Dev`

(`Dev` is the default target, so you can also just run `dotnet fake build`.)

After the app starts, edit the renderer project in `/src/Renderer` and see the changes appear in real-time thanks to hot module reloading.

Place static files in the root `/static` folder as required by electron-webpack. See the code for the “Static assets” page (and the helpers in `Utils.fs`) to see how to use them.


### Release build to unpacked directory

`dotnet fake build -t DistDir`


### Release build to packed installer

`dotnet fake build -t Dist`


### NuGet package management

Use `dotnet paket` (after running `dotnet tool restore`).

## Improvements welcome!

If you see anything here that looks wrong, suboptimal or just weird, you may very well be right. Don't be shy about opening an issue or PR.
