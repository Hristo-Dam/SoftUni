function catsInfo(catArray){
    let cats = [];

    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
            this.meow = () => console.log(`${name}, age ${age} says Meow`);
        }
    }

    for (let i = 0; i < catArray.length; i++){
        let catData = catArray[i].split(' ');
        let [name, age] = catData;
        cats.push(new Cat(name, age))
        cats[i].meow();
    }
}
catsInfo(['Mellow 2', 'Tom 5']);