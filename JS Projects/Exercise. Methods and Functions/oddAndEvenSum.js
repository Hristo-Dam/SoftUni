function oddAndEvenSum(number){
    let numberAsStirng = number.toString();
    let currentNum = 0;
    let evenSum = 0;
    let oddSum = 0;

    for (let i = 0; i < numberAsStirng.length; i++){

        currentNum = (Number(numberAsStirng[i]))

        if (currentNum % 2 == 0){
            evenSum += currentNum;
        }
        else{
            oddSum += currentNum;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}
oddAndEvenSum(1000435)