module Variables

type MyRef<'a> = { mutable contents: 'a }

let variablesFunc() =

    // Immutable variable
    let immutableVariable = 1
    //immutableVariable = 2  // = is the equality operator, not assignment
    //immutableVariable <- 2 // Can't reassign a value to immutable
    printfn "immutableVariable = %A" immutableVariable

    // Mutable variable
    let mutable mutableVariable = 1
    printfn "mutableVariable = %A" mutableVariable
    mutableVariable <- 2
    printfn "mutableVariable = %A" mutableVariable

    // Reference cell
    let referenceVariable = ref 42
    printfn "referenceVariable = %A" referenceVariable
    referenceVariable := 100
    printfn "referenceVariable = %A" referenceVariable
    printfn "!referenceVariable = %A" !referenceVariable
    printfn "referenceVariable.Value = %A" referenceVariable.Value
    printfn "referenceVariable.contents = %A" referenceVariable.contents
    referenceVariable.Value <- 200
    printfn "referenceVariable = %A" referenceVariable
    referenceVariable.contents <- 300
    printfn "referenceVariable = %A" referenceVariable

    // Tuple
    let tuple = 1,2,3,"a string"
    printfn "tuple = %A" tuple
    let x,y,z,s = tuple
    printfn "tuple x=%A; y=%A; z=%A; s=%A" x y z s

    let twople = 1,2
    printfn "tuple fst = %A" (twople |> fst)
    printfn "tuple snd = %A" (twople |> snd)


