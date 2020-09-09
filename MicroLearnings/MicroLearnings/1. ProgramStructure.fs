(*
- functions work like data types
- declare and use a function like any other variable
- to make the program work like a procedural program, many applications keep a single top level statement
*)

open System
(* multi line comment *)
// single line comment


// function called sign, takes in num as parameter
let sign num = 
	if num > 0 then "positive"
	elif num < 0 then "negative"
	else "zero"

// main function calls sign
let main() =
	Console.WriteLine("sign 5 : {0}", (sign 5))

// call main() function
main()

