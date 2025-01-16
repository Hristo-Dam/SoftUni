function addItem() {
    const list = document.getElementById('items');
    const li = document.createElement('li');
    const myInput = document.getElementById('newItemText');

    let currentValue = myInput.value;

    li.textContent = currentValue
    list.appendChild(li);
    
    myInput.value = '';
}