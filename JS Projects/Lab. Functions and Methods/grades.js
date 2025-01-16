function formatGrade(grade){
    let formated = '';
    if (grade < 3.00){
        formated = 'Fail';
    }
    else if (grade >= 3.00 && grade < 3.50){
        formated = 'Poor';
    }
    else if (grade >= 3.50 && grade < 4.50){
        formated = 'Good';
    }
    else if (grade >= 4.50 && grade < 5.50){
        formated = 'Very good';
    }
    else if (grade >= 5.50){
        formated = 'Excellent'
    }
    let result = `${formated} (${grade.toFixed(2)})`;
    return result;
}
console.log(formatGrade(5));