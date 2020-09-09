(*

- let keyword is used for variable declaration
- variables in F# are immutable, which means, once assigned it can't be changed
- mutable keyword allows you to declare and assign values in a mutable variable
- use <- operator to re-assign value to a mutable variable

*)

// simple declaration
let x = 10
let y = 20
let z = x + y
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z


// declaration with type specification
let a:int32 = 10
let b:int32 = 20
let c:int32 = a + b
printfn "a : %i" a
printfn "b : %i" b
printfn "c : %i" c


// mutable variables
let mutable d = 10
d <- 20
printfn "d : %i" d
