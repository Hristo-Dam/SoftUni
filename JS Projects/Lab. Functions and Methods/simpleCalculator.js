function simpleCalculator(a, b, operator){
    if (operator == 'add'){
        let add = (a, b) => a + b;
        console.log(add(a, b));
    }
    else if (operator == 'subtract'){
        let subtract = (a, b) => a - b;
        console.log(subtract(a, b));
    }
    else if (operator == 'multiply'){
        let multiply = (a, b) => a * b;
        console.log(multiply(a, b));
    }
    else if (operator == 'divide'){
        let divide = (a, b) => a / b;
        console.log(divide(a, b));
    }
}
console.log(simpleCalculator())