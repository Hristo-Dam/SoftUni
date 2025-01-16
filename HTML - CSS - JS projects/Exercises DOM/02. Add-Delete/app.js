function solve() {
  const list = document.getElementById('items');
  const li = document.createElement('li');
  const myInput = document.getElementById('newText');

  let currentValue = myInput.value;

  li.textContent = currentValue;
  li.innerHTML = currentValue + '<a href="#">[Delete]</a>';
  list.appendChild(li);
  
  myInput.value = '';

  li.addEventListener('click', (event) => {
    const currentElement = event.currentTarget;
    currentElement.parentNode.removeChild(currentElement);
  });
}
