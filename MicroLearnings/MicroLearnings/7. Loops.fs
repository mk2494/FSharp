(*

for..to loop

for var = start-expr to end-expr do
    ..// loop body

for..downto loop

for var = start-expr downto end-expr do
    ..// loop body

*)

let main() =
    for i = 1 to 20 do
        printfn "i: %i" i
    for i = 20 downto 1 do
        printfn "i: %i" i
main()

(*

loop over collection

for pattern in enumerable-expression do
    body-expression

*)
let list1 = [ 1; 2; 3; 4; 5]
for i in list1 do
    printfn "%d" i

seq = { for i in 1 .. 10 -> (i, i*i) }
for (a, asquared) in seq do
    printfn "%d squared is %d" a asquared

(*

while loop

while test-expression do
    body-expression

*)
let mutable a = 0
while (a < 10) do
    printfn "value of a : %d" a
    a <- a+1
