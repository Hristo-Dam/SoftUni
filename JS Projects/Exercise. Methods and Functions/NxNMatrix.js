function NxNMatrix(number){
    let oneRow = [];
    for (f = 0; f < number; f++){
        oneRow.push(number)
    }

    for (k = 0; k < number; k++){
        console.log(oneRow.join(' '));
    }
}
NxNMatrix(5);