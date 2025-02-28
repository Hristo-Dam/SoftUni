function focused() {
    const input = Array.from(document.querySelectorAll('input [type="text"]'));
    
    input.forEach(x => {
        x.addEventListener('focus', (e) => {
            const element = e.currentTarget.parentNode;
            element.style.background = 'grey';
        });

        x.addEventListener('blur', (e) => {
            const element = e.currentTarget.parentNode;
            element.style.background = 'white';
        });
    });
}