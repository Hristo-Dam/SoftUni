class Vehicle {
    constructor(type, mobel, parts, fuel){
        this.type = type;
        this.mobel = mobel;
        this.parts = {
            engine: parts.engine,
            power: parts.power,
            quality: parts.engine * parts.power
        }
        this.fuel = fuel;
        this.drive = (fuelLoss) => this.fuel -= fuelLoss;
    }
}

function vehicle(){
    let parts = { engine: 6, power: 100 };
    let vehicle = new Vehicle('a', 'b', parts, 200);

    vehicle.drive(100);
    console.log(vehicle.fuel);
    console.log(vehicle.parts.quality);
}

vehicle();