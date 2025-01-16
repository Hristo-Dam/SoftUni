function towns(input){
    let town = {};

    for (element of input){
        let splitElement = [];
        splitElement = element.split(' | ');

        town.name = splitElement[0];
        town.latitude = Number(splitElement[1]);
        town.logitude = Number(splitElement[2]);

        console.log(`{ town: '${town.name}', latitude: '${town.latitude.toFixed(2)}', longitude: '${town.logitude.toFixed(2)}' }`);
    }
}
towns(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);