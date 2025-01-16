function operation(input){
    let n = input[0]
    let x = input[1]
    let result
    if (x >= n){
        result = n * x
    }
    else{
        result = n / x
    }
    console.log(result)
}

let input = [3, 2]
operation(input)