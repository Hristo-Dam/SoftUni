function furniture(input){
    let inputArray = input;
    let result = [];
    let totalPrice = 0;

    const regEx = /\B>>\b(?<name>\w+)\b<<(?<price>\d+[\.|,]\d+|\d+)!(?<quantity>\d+)\b/g;

    for (let i = 0; i < input.length; i++) {
        if (input[i] == 'Purchase'){
            console.log('Bought furniture:');
            result.forEach(furniture => console.log(furniture));
            console.log('Total money spend: ' + totalPrice.toFixed(2));
        }

        regEx.lastIndex = 0;
        let matches = regEx.exec(inputArray[i]);
        //console.log(matches);

        if (matches != null){
            let furnitureName = matches.groups['name'];
            let furniturePrice = matches.groups['price'];
            let furnitureQuantity = matches.groups['quantity'];

            result.push(furnitureName);
            totalPrice += furniturePrice * furnitureQuantity;
        }
    }
}
// furniture([">>TV<<300.77!5",
//     ">>Sofa<<312.23!3",
//     ">Invalid<<!5",
//     "Purchase"]);

furniture([">>Sofa<<312.23!3",
    ">>TV<<300!5",
    ">Invalid<<!5",
    "Purchase"]);

furniture(['>>Laptop<<312.2323!3',
    '>>TV<<300.21314!5',
    '>Invalid<<!5',
    '>>TV<<300.21314!20',
    '>>Invalid<!5',
    '>>TV<<30.21314!5',
    '>>Invalid<<!!5',
    'Purchase'])
    