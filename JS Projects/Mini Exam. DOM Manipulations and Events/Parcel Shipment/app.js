function solution() {
    const input = document.querySelector('body > div > section:nth-child(1) > div > input[type=text]');

    const registerButton = document.getElementById('registerButton');

    registerButton.addEventListener('click', () => {

        let newElement = document.createElement('li')
        let newItem = input.value;

        let textNode = document.createTextNode(newItem);
        let buttonNode = document.createElement('button');
        buttonNode.textContent = 'Send';
        
        newElement.appendChild(textNode);
        newElement.appendChild(buttonNode);
        
        let listOfParcels = document.querySelector('body > div > section:nth-child(2) > ul');
        listOfParcels.appendChild(newElement);
        
        input.value = '';
        
        let items = Array.from(listOfParcels.children);
        items.sort((a, b) => a.textContent.localeCompare(b.textContent));
        items.forEach(item => listOfParcels.appendChild(item));

        buttonNode.addEventListener('click', () => {
            let sentList = document.querySelector('body > div > section:nth-child(3) > ul');
            let newSentElement = document.createElement('li');
            
            let newSentItem = newElement.textContent;
            newSentElement.textContent = newSentItem;
            
            sentList.appendChild(newSentElement);
            
            newElement.remove();
        });
        
    });
}