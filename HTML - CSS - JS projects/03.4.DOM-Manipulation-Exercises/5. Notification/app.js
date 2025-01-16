function notify(message) {
    let divNote = document.getElementById('notification');
    divNote.textContent = message;
    divNote.style.display = 'block';

    setTimeout(function(){
        divNote.style.display = 'none';
    }, 2000)
}