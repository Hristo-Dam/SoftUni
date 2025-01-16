function perfectNumber(number){
    let devidors = [];
    let devidorsSum = 0;
    for (let i = 1; i < number; i++){
        if (number % i == 0){
            devidors.push(i);
        }
    }

    for (let k = 0; k < devidors.length; k++){
        devidorsSum += Number(devidors[k]);
    }

    if (number == devidorsSum){
        console.log('We have a perfect number!')
    }
    else{
        console.log('It\'s not so perfect.')
    }
}
perfectNumber(6)