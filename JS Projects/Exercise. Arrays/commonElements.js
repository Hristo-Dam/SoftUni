function commonElements(arrOne, arrTwo){
    let commonElements = [];
    for (element of arrOne){
        if (arrTwo.includes(element)){
            commonElements.push(element);
        }
    }
    console.log(commonElements.join('\n'));
}
commonElements(['Hey', 'hello', 2, 4, 'Peter', 'e'], ['Petar', 10, 'hey', 4, 'hello', '2']);