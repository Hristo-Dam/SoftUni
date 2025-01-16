function comic(pictures, args){


    for (let i = 0; i < args.length; i++){
        let command = args[i].split(' ');

        if (command[0] === 'End'){
            if (pictures.length > 0){
                console.log(`Pictures left: ${pictures.join(', ')}`);
            }
            else{
                console.log('The comic is complete');
            }
            break;
        }
        else if (command[0] === 'Done'){
            let pictureCode = pictures.pop()
            console.log(`${pictureCode} is ready for printing!`);
        }
        else if (command[0] === 'Add'){
            let pictureCode = command[1];
            pictures.unshift(pictureCode);
        }
        else if(command[0] == 'Remove'){
            let startIndex = Number(command[1]);
            let endIndex = Number(command[2]);

            pictures.splice(startIndex, endIndex + 1);
            //console.log(pictures);
            console.log('Removd!')
        }
    }
}

// comic(['R22', 'P89', 'K12'], 
//     ['Done', 'End', 'Remove 0 1'])
comic(['K12', 'P90', 'A13', 'B13', 'C34', 'D56'], 
    ['Add J98', 'Remove 1 4', 'End'])
    