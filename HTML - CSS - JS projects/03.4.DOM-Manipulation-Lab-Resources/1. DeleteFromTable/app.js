function deleteByEmail() {
    //TODO:
    let emailToDelete = document.getElementByName("email")[0].value;
    let secondColumn = document.querySelectorAll("#customers tr td:nth-child(2)");

    let hasFound = false;
    let index = 0;

    for (let row of secondColumn){
        let chilndren = row.children;
        let email = children[children.length -1].textContent;

        if (row.textContent == email){
            let table = document.getElementById('customers');
            table.deleteRow(index);
            hasFound = true;
            break;
        }

        index++
    }

    let result = document.getElementById('result');
    if (hasFound){
        result.textContent = 'Deleted.';
    }else{
        result.textContent = 'Not found.'
    }
}