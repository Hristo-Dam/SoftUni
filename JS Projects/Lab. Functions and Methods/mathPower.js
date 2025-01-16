function mathPower(number, power){
    let result = number;
    for (let i = 0; i < power - 1; i++){
        result *= number
    }
    return result;
}
console.log(mathPower(2, 2));