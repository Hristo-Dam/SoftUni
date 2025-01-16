function calcPrice(input){
    let weight = input[1]/1000
    let pricePerKg = input[2]
    let finalPrice = weight * pricePerKg

    console.log('I need ' + Number(finalPrice.toFixed(2)) + ' to buy ' + Number(weight.toFixed(2)) + ' kilograms ' + input[0] + '.');
}

let input = ['orange', 2500, 1.80]
calcPrice(input);