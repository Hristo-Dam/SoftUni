function matchFullName(names){
    const regEx= /\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b/g;
    let nameList = [];
    let matches = regEx.exec(names)
    while (matches !== null){
        nameList.push(matches.shift());
        matches = regEx.exec(names);
    }
    console.log(nameList.join(" "))
}
matchFullName('Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan    Ivanov')