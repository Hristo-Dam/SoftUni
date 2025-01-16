function firstAndLastKNumbers(numbers){
    let k = numbers.shift();
    console.log(numbers.slice(0, k).join(' '));
    console.log(numbers.slice(numbers.length-k, numbers.length).join(' '));
}
firstAndLastKNumbers([3, 6, 7, 8, 9]);