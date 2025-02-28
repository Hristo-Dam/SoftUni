document.addEventListener('DOMContentLoaded', function() {

    const button = document.getElementById('add');

    button.addEventListener('click', function(){

        let newElement = document.createElement('li');
        let newItem = document.getElementById('newItemText').value;

        let textNode = document.createTextNode(newItem);

        newElement.appendChild(textNode);
        document.getElementById('items').appendChild(newElement);

        document.getElementById('newItemText').value = '';
    });
});