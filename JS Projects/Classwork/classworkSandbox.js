function func(){
    let arr = [];

    arr[3.4] = 'Oranges';
    
    arr[-1] = 'Apples';

    arr[5] = 'fgjkl';
    
    console.log(arr.length); // 0
    
    console.log(arr.hasOwnProperty(3.4)); // true
    
    arr["1"] = 'Grapes';
    
    console.log(arr.length); // 2
    
    console.log(arr); // [ <1 empty item>, 'Grapes', '3.4': 'Oranges', '-1': 'Apples' ]
}

func();