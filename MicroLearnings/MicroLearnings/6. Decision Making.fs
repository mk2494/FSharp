(*

if expr then
    expr
   
*)

let a : int32 = 10
if (a < 20) then
    printfn "a is less than 20 \n"
    printfn "value of a is : %d" a

(*

if expr then
    expr
else
    expr

*)

if (a < 20) then
    printfn "a is less than 20 \n"
    printfn "value of a is %d" a
else
    printfn "a is not less than 20"
    printfn "value of a is: %d" a


(*

if expr then
    expr
elif expr then
    expr
elif expr then
    expr
else
    expr

*)

if (a=10) then
    printfn "value of a is 10\n"
elif (a=20) then
    printfn "value of is 20\n"
elif (a=30) then
    printfn "value of a is 30\n"
else
    printfn "None of the values match"

(*

if expr then
    expr
    if expr then
        expr
    else
        expr
else
    expr

*)