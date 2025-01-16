function positiveOrNegative(input){
    let negative = 0
    let zero = 0
    let result = ""
    for (let i = 0; i < input.length; i++){
        if (input[i] < 0){
            negative++
        }
        else if (input[i] == 0){
            zero++
        }
    }

    if (negative % 2 == 1 && zero == 0){
        result = "Negative"
    }
    else{
        result = "Positive"
    }
    console.log(result)
}

let input = [2, 3, -1]
positiveOrNegative(input)