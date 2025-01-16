function employees(namesArray){
    let nameAndNum = {};

    for (element of namesArray){
        nameAndNum.name = element;
        nameAndNum.personalNum = element.length
        console.log(`Name: ${nameAndNum.name} -- Personal Number: ${nameAndNum.personalNum}`);
    }
}
employees([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ])
    