function palindromeIntegers(array){
    for (let f = 0; f < array.length; f++){
        let arrayAsString = array[f].toString();
        let firstHalf = [];
        let secondHalf = [];
        if (arrayAsString.length % 2 == 0){
            for (i = 0; i < arrayAsString.length / 2; i++){
                firstHalf.push(arrayAsString[i])
            }
            for (k = arrayAsString.length - 1; i > 0; i--){
                secondHalf.push(arrayAsString[k])
            }
        }
        else{
            for (i = 0; i < (arrayAsString.length - 1) / 2; i++){
                firstHalf.push(arrayAsString[i])
            }
            for (k = arrayAsString.length - 1; i > 0; i--){
                secondHalf.push(arrayAsString[k])
            }
        }
        console.log(JSON.stringify(firstHalf) === JSON.stringify(secondHalf));
    }
}
palindromeIntegers([123,323,421,121]);