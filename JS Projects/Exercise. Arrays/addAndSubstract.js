function addAndSubstract(array){
    let firstSum = 0;
    for (let num of array){
        firstSum += num;
    }

    for (let i = 0; i < array.length; i++){
        if (array[i] % 2 == 0){
            array[i] += i;
        }
        else{
            array[i] -= i;
        }
    }

    let newSum = 0;
    for (let num of array){
        newSum += num;
    }

    console.log(array);
    console.log(firstSum);
    console.log(newSum);
}
//addAndSubstract([1, 2, 3, 4, 5])
addAndSubstract([5, 15, 23, 56, 35])