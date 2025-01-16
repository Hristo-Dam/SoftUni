function inventory(input){
    let inventory = [];
    let items = input[0].split(', ');
    for (item of items){
        inventory.push(item);
    }

    let commands = [];

    for (let i = 1; i < input.length; i++){
        commands.push(input[i]);
    }

    for (command of commands){
        let splitCommand = [];
        splitCommand = command.split(' - ');

        let currentCommand = {};
        currentCommand.comd = splitCommand[0];
        currentCommand.item = splitCommand[1];

        if (currentCommand.comd == 'Collect'){
            if (!inventory.includes(currentCommand.item)){
                inventory.push(currentCommand.item)
                //console.log(inventory);
            }
        }
        else if (currentCommand.comd == 'Drop'){
            if (inventory.includes(currentCommand.item)){
                //console.log(inventory)
                let index = inventory.indexOf(currentCommand.item);
                inventory.splice(index, 1);
                //console.log(inventory);
            }
        }
        else if (currentCommand.comd == 'Combine Items'){
            let splitItems = []
            splitItems = currentCommand.item.split(':')
            if(inventory.includes(splitItems[0])){
                inventory.push(splitItems[1])
            }
            console.log(inventory);
        }
        else if (currentCommand.comd == 'Renew'){
            if (inventory.includes(currentCommand.item)){
                inventory.pop(currentCommand.item);
                inventory.push(currentCommand.item);
                console.log(inventory);
            }
        }
        else if (currentCommand.comd == 'Craft!'){
            console.log(inventory.join(', '))
        }
    }
    
}

inventory(['Iron, Wood, Sword', 'Collect - Gold', 'Drop - Wood', 'Craft!'])
//inventory(['Iron, Sword','Drop - Bronze','Combine Items - Sword:Bow','Renew - Iron', 'Craft!'])