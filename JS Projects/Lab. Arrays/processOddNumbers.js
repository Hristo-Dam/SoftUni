function oddNumber(arr){
    let result = arr.filter((element, i) => i % 2 == 1)
                    .map(x => x * 2)
                    .reverse();
    console.log(result);
}
oddNumber([1, 2, 3, 4, 5]);