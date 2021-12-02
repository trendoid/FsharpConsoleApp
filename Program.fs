// For more information see https://aka.ms/fsharp-console-apps
printfn "Console App: Started!"

open System.IO
let baseDirectory = __SOURCE_DIRECTORY__
let filePath = "Text.txt"
let fullPath = Path.Combine(baseDirectory, filePath)

let readFilesTask (path1) =
   task {
        let! content = File.ReadAllTextAsync(path1)
        return content
   }

printfn "Content: %s" (readFilesTask(fullPath).Result)
