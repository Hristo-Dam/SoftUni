function calculator(number, operator, secondNumber){
    let sum = 0;
    let firstOperant = Number(number);
    let secondOperant = Number(secondNumber);
    
    if(operator.toString() === '+'){
        sum = firstOperant + secondOperant;
    }
    else if(operator.toString() === '-'){
        sum = firstOperant - secondOperant;
    }
    else if(operator.toString() === '*'){
        sum = firstOperant * secondOperant;
    }
    else if(operator.toString() === '/'){
        sum = firstOperant / secondOperant;
    }
    return sum;
}
console.log(calculator('3', '*', '5'));