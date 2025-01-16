function focus() {
    Array.from(document.querySelectorAll('div input')).forEach(currentElement => {
        currentElement.addEventListener('focus', onFocus);
        currentElement.addEventListener('blur', Myreset);
    });



    function onFocus(event){
        event.targent.parentNode.className = 'focused'; //focused е взето от css-a
    }

    function Myreset(event){
        event.terget.parentNode.removeAttribute('class');
    }
}