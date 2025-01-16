function passwordGenerator(input){
    let [first, second, third] = input;
    count = 0;

    let comb = first.concat(second).toLowerCase().split("");
    //console.log(comb);

    let vowels = ['a', 'e', 'o', 'i', 'u'];

    third = third.toUpperCase()

    for (let i = 0; i < comb.length; i++){

        if (vowels.includes(comb[i])){

            comb[i] = third[count];
            //console.log(comb)

            if(count == third.length - 1){
                count = 0;
            }
            else{
                count++
            }
        }
    }
    //console.log(comb);
    comb.reverse();
    let result = '';
    for (let letter of comb){
        result += letter;
    }
    console.log(`Your generated password is ${result}`);
}
passwordGenerator(['ilovepizza', 'ihatevegetables','orange'])
    