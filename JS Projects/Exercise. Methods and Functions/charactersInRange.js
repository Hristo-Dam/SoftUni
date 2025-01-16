function charactersInRange(firstChar, secondChar){
    let firstCharCode = firstChar.charCodeAt();
    let secondCharCode = secondChar.charCodeAt();

    let startChar = 0;
    let endChar = 0;

    let result = [];

    if (firstCharCode < secondCharCode){
        startChar = firstCharCode + 1;
        endChar = secondCharCode - 1
    }
    else{
        startChar = secondCharCode + 1;
        endChar = firstCharCode - 1
    }
    for (let i = startChar; i <= endChar; i++){
        result.push(String.fromCharCode(i));
    }
    console.log(result.join(" "))
}
charactersInRange('a', 'd')