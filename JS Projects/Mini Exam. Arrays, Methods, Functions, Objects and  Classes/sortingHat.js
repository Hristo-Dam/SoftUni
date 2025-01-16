function sortingHat(array){
    let houses = {};
    array.forEach((element) => {
        let splitedElements = element.split(' - ');
        let houseNumber = splitedElements[0];
        let studentInfo = splitedElements[1];

        if (!houses[houseNumber]) {
            houses[houseNumber] = [];
        }

        houses[houseNumber].push(studentInfo);
    });

    for (let houseNumber in houses) {

        console.log(`House № ${houseNumber}`);

        for (student of houses[houseNumber]){
            let studentForPrint = student.replaceAll(':', ' - ');
            console.log(`--- ${studentForPrint}`);
        }
    }
}

sortingHat([
    '1 - Ron Weasley: Pure-blood, Type: Squib',
    '1 - Harry Potter: half-bloods, Wizardkind: Wizard',
    '2 - Hermione Granger: Muggle-born'
])