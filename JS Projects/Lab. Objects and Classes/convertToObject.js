function convertToObject(json){

    let jasonParsed = JSON.parse(json);
    let entries = Object.entries(jasonParsed);

    for (const [key, value] of entries) {
        console.log(`${key}: ${value}`);
    }
}
convertToObject('{"name": "George", "age": 40, "town": "Rusi"}');
