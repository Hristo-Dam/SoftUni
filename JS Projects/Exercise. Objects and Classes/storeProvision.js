function storeProvision(storageArray, deliveryArray){
    let itemsInStorage = [];

    for (let i = 0; i < storageArray.length; i += 2){
        let obj = {};
        obj.product = storageArray[i];
        obj.quantity = Number(storageArray[i + 1]);
        itemsInStorage.push(obj);
    }
    //console.log(itemsInStorage);

    for (let k = 0; k < deliveryArray.length; k += 2){
        let obj = {};
        let itemExists = false;

        for (let item of itemsInStorage){

            if(item.product == deliveryArray[k]){
                item.quantity += Number(deliveryArray[k + 1]);
                itemExists = true;
            }
        }

        if (!itemExists)
        {
            obj.product = deliveryArray[k];
            obj.quantity = Number(deliveryArray[k + 1]);
            itemsInStorage.push(obj);
        }
    }
    //console.log(itemsInStorage);
    
    for (let item of itemsInStorage) {
        console.log(`${item.product} -> ${item.quantity}`);
    }

}
storeProvision(
    ['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Juice', '2'],
    ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']
);
