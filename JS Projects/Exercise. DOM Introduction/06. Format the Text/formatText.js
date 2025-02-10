function solve() {
  let input = document.getElementById('input').value;
  let sentences = input.split('.').filter(x => x !== '');
  let output = document.getElementById('output');

  while (sentences.length > 0) {
      let paragraphText = sentences.splice(0, 3).join('. ') + '.';
      let p = document.createElement('p');
      p.textContent = paragraphText.trim();
      output.appendChild(p);
  }
}