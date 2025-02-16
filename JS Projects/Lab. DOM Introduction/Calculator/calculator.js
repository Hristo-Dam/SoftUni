document.addEventListener('DOMContentLoaded', function(){
    document.getElementById('calc').addEventListener('click', function(event){
        event.preventDefault();
        clac();
    });
});

function clac(){
    let num1 = document.getElementById('num1').value;
    let num2 = document.getElementById('num2').value;

    let operator = document.getElementById('operator').value;

    let result;

    if (operator == 'add'){
        result = Number(num1) + Number(num2);
    }
    else if (operator == 'subtract'){
        result = Number(num1) - Number(num2);
    }
    else if (operator == 'multiply'){
        result = Number(num1) * Number(num2);
    }
    else if (operator == 'devide'){
        result = Number(num1) / Number(num2);
    }

    document.getElementById('result').textContent = result;
}