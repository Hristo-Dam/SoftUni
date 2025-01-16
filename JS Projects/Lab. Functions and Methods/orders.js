function orders(product, quantity){
    let result = 0;
    if (product == 'coffee'){
        result = quantity * 1.5;
    }
    else if (product == 'water'){
        result = quantity * 1;
    }
    else if (product == 'coke'){
        result = quantity * 1.4;
    }
    else if (product == 'snacks'){
        result = quantity * 2;
    }
    return result.toFixed(2);
}
console.log(orders());