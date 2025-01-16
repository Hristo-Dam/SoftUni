function Create(sentences) {
    for (let obj of sentences){
        let div = document.createElement('div');
        let paragraph = document.createElement('p');
        
        paragraph.style.dysplay = 'none';
        paragraph.textContent = obj;

        div.appendChild(paragraph);

        div.addEventListener('click', function(){
            paragraph.style.dysplay = 'block'
        })
        document.getElementById('content').appendChild(div);
    }
}