function race(input){
    class Racer{
        constructor(name, distance){
            this.name = name;
            this.distance = distance;
        }
    }

    let names = input[0].split(", ");
    let regExForLetters = /[A-Za-z]/g;
    let regExForDigits = /\d/g;

    let racersWithDistances = [];

    for (let i = 1; i < input.length; i++) {
        if (input[i].match(regExForLetters).join("") == "endofrace"){

        }
        else{
            let nameOfCurrentRacer = input[i].match(regExForLetters).join("");
            //console.log(nameOfCurrentRacer);
    
            let distanceOfCurrentRacer = input[i].match(regExForDigits).map(Number).reduce((a, b) => a + b);
            //console.log(distanceOfCurrentRacer);

            if (names.includes(nameOfCurrentRacer)){
                racersWithDistances.push(new Racer(nameOfCurrentRacer, distanceOfCurrentRacer));
                //console.log(racersWithDistances);
            }
        }
    }
    
    racersWithDistances.sort((a, b) => b.distance - a.distance);

    // racersWithDistances.forEach(racer => {
    //     console.log(`Racer: ${racer.name}, Distance: ${racer.distance}`);
    // });

    // console.log("-----------------");

    for (let k = 0; k < 3; k++) {
        if (k == 0){
            console.log("1st place: " + racersWithDistances[k].name);
        }
        else if (k == 1){
            console.log("2nd place: " + racersWithDistances[k].name);
        }
        else if (k == 2){
            console.log("3rd place: " + racersWithDistances[k].name);
        }
    }
}

race(["George, Peter, Bill, Tom",
    "G4e@55or%6g6!68e!!@",
    "R1@!3a$y4456@",
    "B5@i@#123ll",
    "G@e54o$r6ge#",
    "7P%et^#e5346r",
    "T$o553m&6",
    "end of race"])    