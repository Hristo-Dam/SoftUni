function personInfo(firstName, lastName, age){

    let person = {};

    person.firstName = firstName;
    person.lastName = lastName;
    person.age = age;

    let entries = Object.entries(person);

    for (let [ key, value ] of entries) {
        console.log(`${key}: ${value}`);
    }
}
personInfo('Peter', 'Pan', 20)