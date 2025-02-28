document.addEventListener('DOMContentLoaded', function() {

    const button = document.getElementById('button');

        button.addEventListener('click', () => {
            button.textContent = Number(button.textContent) + 1;
        });
        
    // // const target = e.currentTarget;
    // // const targetText = target.textContent;
    // // target.textContent = Number(targetText) + 1;
    // }
    //currentTarget is the element that the event listener is attached to
    //target is the element that triggered the event
});