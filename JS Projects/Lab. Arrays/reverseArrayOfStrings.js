function reverseStrings(array){
    let temp = 0;
    //swap elements
    for (let i = 0; i < array.length / 2; i++){
        temp = array[i]
        array[i] = array[array.length - 1 - i];
        array[array.length - 1 - i] = temp;
    }
}