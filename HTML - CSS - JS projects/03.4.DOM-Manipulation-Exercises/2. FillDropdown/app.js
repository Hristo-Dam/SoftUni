function addItem() {
    let myText = document.getElementById('newItemText').value;
    let myValue = document.getElementById('newItemValue').value;
    let menu = document.getElementById('menu');

    let option = document.createElement('option');
    option.value = myValue;
    option.text = myText;

    menu.appendChild(option);

    document.getElementById('newItemText').textContent = '';
    document.getElementById('newItemValue').textContent = '';

}