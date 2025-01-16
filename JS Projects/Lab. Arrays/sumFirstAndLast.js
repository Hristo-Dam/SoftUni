function sumFirstAndLast(array){
    let sum = Number(array.shift()) + Number(array.pop());
    console.log(sum)
}
sumFirstAndLast([1, 2, 3, 4, 5])