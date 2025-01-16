function convertToJSON(firstName, lastName, hairColor){
    let person = {};
    person.name = firstName;
    person.lastName = lastName;
    person.hairColor = hairColor;

    let JSONString = JSON.stringify(person);
    console.log(JSONString);
}
convertToJSON('George', 'Jones', 'Brown')
