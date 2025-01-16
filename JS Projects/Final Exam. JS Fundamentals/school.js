// class Teacher {
//     constructor(name) {
//         this.name = name;
//         this.classes = [];
//     }

//     addClass(className, numberOfStudents) {
//         this.classes.push({ className, numberOfStudents });
//     }
// }
class Teacher {
    constructor(name, classes = []) {
        this.name = name;
        this.classes = classes;
    }

    addClass(className, numberOfStudents) {
        this.classes.push({ className, numberOfStudents });
    }
}
function school(input){
    let teachers = [];

    for (let i = 0; i < input.length; i++){

        let command = input[i].split(' ');

        if (command.includes('arrives')){

            let teacherName = '';

            if (command.length == 2){
                teacherName = command[0];
            }
            else{
                teacherName = command[0] + ' ' + command[1];
            }

            let teacher = new Teacher(teacherName);
            teachers.push(teacher);
            console.log(teachers.map(t => t.name) + '   Arrives Command');
        }
        else if (command[0].includes(':')){

            let teacherName = command[0].slice(0, command[0].length - 1);
            console.log(teacherName);

            let className = command[1].slice(0, command[1].length - 1);
            console.log(className);
            let numberOfStudents = Number(command[2]);
            console.log(numberOfStudents);

            let teacher = teachers.find(t => t.name === teacherName);
            if (teacher) {
                teacher.addClass(className, numberOfStudents);
                console.log(teachers.map(t => t.classes));
            }

            // let teacher = teachers.find(t => t.name === teacherName);

            // let className = command[1];
            // let numberOfStudents = Number(command[2]);

            // teacher.addClass(className, numberOfStudents);
            // console.log(teachers.map(t => t.classes));

        }
        else if (command[1].includes(':')){

        }
        else if (command.includes('Quit')){

            let teacherName = '';
            if (command.length == 2){
                teacherName = command[0];
            }
            else{
                teacherName = command[0] + ' ' + command[1];
            }
            console.log(teacherName);

            teachers = teachers.filter(t => t.name !== teacherName);
            console.log(teachers.map(t => t.name) + '   Quit Command');
        }
    }
}

// school([
//     'Dan Miller arrives', 
//     'Janet: 12A, 30', 
//     'Dan Miller: 9A, 25', 
//     'Jorge arrives', 
//     'Jorge: 8B, 25', 
//     '12A + 2', '9A + 3', 
//     '8B + 4', 
//     'Liam arrives', 
//     'Liam: 10A, 25', '10A + 3', 
//     'Dan Miller Quit', 
//     'Liam: 11G, 32'
// ])