function addItem(){
  const inputText = document.getElementById('newItemText');

  const newLi = document.createElement('li');
  newLi.textContent = inputText.value;

  const items = document.getElementById('items').appendChild(newLi);

  inputText.value = '';

  const aTag = document.createElement('a');
  aTag.textContent = '[Delete]';
  aTag.href = '#';
  
  aTag.addEventListener('click', (e) =>{
    newLi.remove();
  });
}

// document.addEventListener('DOMContentLoaded', function() {

//     document.getElementById('add').addEventListener('click', function(){

//         let newElement = document.getElementById('newItemText').value; // Get the value of the input field
//         let list = document.getElementById("items"); // Get the list
      
//         if (newElement.length === 0) return;
      
//         let listItem = document.createElement("li"); // Create a new list item
//         listItem.textContent = newElement; // Set the text content of the list item to the value of the input field
      
//         let anchorLink = document.createElement("a"); // Create a new anchor element
//         let linkText = document.createTextNode("[Delete]"); // Create a new text node

//         anchorLink.appendChild(linkText); // Add the text node to the anchor element
//         anchorLink.href = "#"; // Set the href attribute of the anchor element to #
//         anchorLink.addEventListener("click", deleteItem); // Add an event listener to the anchor element
      
//         listItem.appendChild(anchorLink); // Add the anchor element to the list item
//         list.appendChild(listItem); // Add the list item to the list
      
//         function deleteItem() {
//           listItem.remove();
//         }

//         document.getElementById('newItemText').value = '';
//     });
// });