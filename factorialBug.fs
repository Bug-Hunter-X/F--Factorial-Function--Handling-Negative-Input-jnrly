let rec factorial n = 
    if n = 0 then 1
    else if n < 0 then failwith "Factorial is not defined for negative numbers"
    else n * factorial (n - 1)

let result = factorial (-5)