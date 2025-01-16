function setValues(input){
    let result = [input[0]];
    let a = input[1].split(' ')
    let b = input[2].split(' ')
    let c = input[3].split(' ')
    result[a[0]] = a[2]
    result[b[0]] = b[2]
    result[c[0]] = c[2]
    for (let i = 0; i < result.length; i++){
        if (result[i] == null || result[i] == undefined){
            console.log(0);
        }
        else{
            console.log(result[i])
        }
    }
}

let input = ['2', '0 - 5', '0 - 6', '0 - 7']
setValues(input)