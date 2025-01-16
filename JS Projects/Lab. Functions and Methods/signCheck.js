function signCheck(numOne, numTwo, numThree){
    let count = 0;
    if (numOne < 0){
        count++;
    }
    if (numTwo < 0){
        count++;
    }
    if (numThree < 0){
        count++
    }
    
    if (count == 1 || count == 3){
        console.log('Negative')
    }
    else{
        console.log('Positive')
    }
}
