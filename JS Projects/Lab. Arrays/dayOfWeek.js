function dayOfWeek(number){

    let days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]

    if(number < 1 || number > 7){
        console.log('Invalid day!');
    }
    else{
        console.log(days[number - 1]);
    }
}
dayOfWeek(9)