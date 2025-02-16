function solve() {
    const input = document.getElementById('input');
    const result = document.querySelector('#result');

    const selectMenuTo = document.getElementById('selectMenuTo');
    const button = document.querySelector('button');

    let binaryElement = document.createElement('option');
    binaryElement.textContent = 'Binary';
    binaryElement.value = 'binary';
    selectMenuTo.appendChild(binaryElement);

    let hexadecimalElement = document.createElement('option');
    hexadecimalElement.textContent = 'Hexadecimal';
    hexadecimalElement.value = 'hexadecimal';
    selectMenuTo.appendChild(hexadecimalElement);

    button.addEventListener('click', () => {
        if (selectMenuTo.value === 'binary') {
            result.value = Number(input.value).toString(2);
        } else if (selectMenuTo.value === 'hexadecimal') {
            result.value = Number(input.value).toString(16).toUpperCase();
        }
    })
}