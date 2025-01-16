function building(floor, rooms){
    floor = +floor;
    rooms = +rooms;
    let firstFloorBuild = false;
    let floorString = '';

    for (let i = floor; i > 0; i--){
        for (let k = 0; k < rooms; k++){
            if (!firstFloorBuild){
                floorString += `L${i}${k} `;
            }
            else if(i % 2 == 0){
                floorString += `O${i}${k} `;
            }
            else if(i % 2 != 0){
                floorString += `A${i}${k} `;
            }
        }
        firstFloorBuild = true;
        console.log(floorString.toString());
        floorString = '';
    }
}
building(5, 16);