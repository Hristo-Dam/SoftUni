function negativeOrPositive(numbers){
    let result = [];

    for (let num of numbers){

        if (num < 0){

            result.unshift(num);

        } else {

            result.push(num);

        }

        console.log(result.join('\n'));
        
    }
}
negativeOrPositive([7, -2, 8, 9]);