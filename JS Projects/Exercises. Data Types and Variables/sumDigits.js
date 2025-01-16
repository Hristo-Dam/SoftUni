function sumDigits(number){
    number = number.toString();
    let sum = 0;

    for(let i = 0; i < number.length; i++){
        sum += Number(number[i]);
    }
    return sum;
}

sumDigits(1234);