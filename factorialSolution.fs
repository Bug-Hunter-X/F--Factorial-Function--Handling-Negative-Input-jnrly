let rec factorial n = 
    match n with
    | 0 -> 1
    | n when n > 0 -> n * factorial (n - 1)
    | _ -> failwith "Factorial is not defined for negative numbers"

let result = factorial (-5) //this will throw an exception

let result2 = factorial 5 //this will return the correct result