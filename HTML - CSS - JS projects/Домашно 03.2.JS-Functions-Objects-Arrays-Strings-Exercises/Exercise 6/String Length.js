function stringLength(a, b, c){
    let sum = a.length + b.length + c.length
    let avg = Math.floor(sum / 3);
    console.log(sum);
    console.log(avg);
}

let input = ["chocolate", "ice cream", "cake"];
stringLength(input[0], input[1], input[2]);