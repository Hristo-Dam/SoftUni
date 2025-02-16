function solve() {
  let input = document.getElementById('text').value;
  const convention = document.getElementById('naming-convention').value;
  const result = document.getElementById('result');

  input = input.toLowerCase().split(' ');

  if (convention === 'Pascal Case') {

    input = input.map(word => word.charAt(0).toUpperCase() + word.slice(1));
    result.textContent = input.join('');

  } else if (convention === 'Camel Case') {

    input = input.map(word => word.charAt(0).toUpperCase() + word.slice(1)).toString();//.replace(',', '');
    input = input.charAt(0).toLowerCase() + input.slice(1);
    input = input.split(',');
    result.textContent = input.join('');
  }
  else{
    result.textContent = 'Error!';
  }
}